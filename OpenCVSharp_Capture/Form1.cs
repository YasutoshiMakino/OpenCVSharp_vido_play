using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace OpenCVSharp_Capture
{
    public partial class Form1 : Form
    {
        //定数の定義
        public static class Define
        {
            public const int MP4 = 0;
            public const int CSV = 1;
            public const int DATA_LENGTH = 100000;

            public const int V_FRAMERATE_VID = 60;
            public const int V_FRAMERATE_GOPRO = 120;
            public const int H_FRAMERATE = 1000;
            public const int DRAW_SCALE = 200;
            
            public const int TIME_SCALE_SHORT = 3;
            public const int TIME_SCALE_STANDARD = 10;
            public const int TIME_SCALE_LONG = 20;

            public const int VIDEO_SCALE = 3;
            public const int GOPRO_SCALE = 2;

            public const int HAPLOG_HEADER_ROW = 13;

            public const int SAVE_DURATION = 53;    //保存する秒数のデフォルト値
        }

        //キャプチャ関係
        VideoCapture capture;
        Mat img = new Mat();
        Mat small_img = new Mat();
        int max_frame, fps;
        int size_scale = Define.VIDEO_SCALE;
        int v_framerate = Define.V_FRAMERATE_GOPRO;

        private System.Windows.Forms.Timer tmr;
        int counter = 0;
        int interval = 10;

        //ファイル関係
        bool mp4_flg = false;   //mp4ファイルが開かれていればtrue
        bool csv_flg = false;   //csvファイルが開かれていればture
        bool csv_direct_flg = false;//直接時間指定するときのフラグ
        FourCC FileCodec = FourCCValues.MJPG;    
        
        string mp4_file_path, csv_file_path;
        double[] csv_data = new double[Define.DATA_LENGTH];
        double[] csv_time = new double[Define.DATA_LENGTH];
        int csv_data_len = 0;

        int data_len = 0;
        int time_scale = Define.TIME_SCALE_SHORT;
        int draw_scale = Define.DRAW_SCALE;
        int csv_frame_offset = 0;
        int csv_current_diff = 0;
        int current_frame = 0;
        bool csv_stop_flag = false;

        //動画再生関係
        bool play_flg = false;  //再生中ならtrue;
        int diff_frame = 0;

        //スレッド内での文字列の表示用
        //デリゲートでCallBack関数を定義
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (ResText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                ResText.Text = text;
            }
        }

        private void SetText2(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (ResText2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText2);
                Invoke(d, new object[] { text });
            }
            else
            {
                ResText2.Text = text;
            }
        }

        public Form1()
        {
            InitializeComponent();
            capture = new VideoCapture("C:\\S_test\\s1_R002.mp4");

            max_frame = (int)capture.Get(VideoCaptureProperties.FrameCount);
            fps = (int)capture.Get(VideoCaptureProperties.Fps);

 //           ResText2.Text = fps.ToString();

            SaveSeconds.Text = Define.SAVE_DURATION.ToString();

            this.VideoTimeBar.Maximum = max_frame;
            this.radioSpeed1.Checked = true;
            this.radioMJPG.Checked = true;
            this.rScaleNormal.Checked = true;
            this.timeScaleShort.Checked = true;
            this.RawHapLog.Checked = true;
            this.FilenameBox.Text = "s11_001";
            this.GoProCheck.Checked = true;
        }


        //Timer関数一定の時間で画像を表示
        private void timer_Tick(object sender, System.EventArgs e)
        {
            counter++;

            //画の更新
            capture.Read(img);
            
            //空になっていたら止める
            if (img.Empty()) {
                tmr.Stop();
                play_flg = false;
                return;
            }

            if (GoProCheck.Checked) size_scale = Define.GOPRO_SCALE;
            else size_scale = Define.VIDEO_SCALE;

            Cv2.Resize(img, small_img, new OpenCvSharp.Size(img.Cols / size_scale, img.Rows / size_scale));
            pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(small_img);
            pictureBox1.Refresh();
            this.VideoTimeBar.Value = counter;
            
            //           SetText(capture.Get(VideoCaptureProperties.PosFrames).ToString());
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);
        }

        //絵とグラフの一括更新
        public void DrawRefresh(int current_cnt) {
            capture.Set(VideoCaptureProperties.PosFrames, current_cnt);

            //画の更新
            capture.Read(img);

            if (GoProCheck.Checked) size_scale = Define.GOPRO_SCALE;
            else size_scale = Define.VIDEO_SCALE;
            Cv2.Resize(img, small_img, new OpenCvSharp.Size(img.Cols / size_scale, img.Rows / size_scale));
            pictureBox1.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(small_img);
            pictureBox1.Refresh();
            this.VideoTimeBar.Value = current_cnt;

            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);
        }

        //スクロールバー上をクリックしたときの挙動
        private void ScrollBar_Click(object sender, MouseEventArgs e)
        {
            const int margin = 10;
            int Form_x = this.Left;
            int trackbar_x = this.VideoTimeBar.Bounds.X + margin + 8;    //領域左のマージン分(+8は値を見て決定)
            int trackbar_wid = this.VideoTimeBar.Bounds.Width - margin * 2; //領域左右のマージン分
            int mouse_x = System.Windows.Forms.Cursor.Position.X;
            int position = 0;

            double Bar_pos = ((double)(mouse_x - Form_x - trackbar_x) / trackbar_wid);  //マウスの現在位置からフォームの位置とトラックバーの位置を引いてトラックバーの幅で割る
            position = (int)(Bar_pos * max_frame);  //マウスのトラックバー上での割合に，トラックバーの目盛り分をかける
            if (position < 0)   //値が0より小さかったら0にクリップ
            {
                this.VideoTimeBar.Value = 0;
                counter = 0;
            }
            else if (position > max_frame)　//値がmax_frameより大きかったらmax_frameにクリップ
            {
                this.VideoTimeBar.Value = max_frame;
                counter = max_frame;
            }
            else
            {
                this.VideoTimeBar.Value = position;
                counter = position;
            }
            DrawRefresh(counter);
        }

        #region ファイルオープン関係

        //動画ファイルのオープン
        private void MP4open_Click(object sender, EventArgs e)
        {
            mp4_file_path = OpenFile(Define.MP4);

            //キャンセルを押したときように，mp4_file_pathがnullなら何もせずにreturn
            if (mp4_file_path == null) return;
            else { 
                capture = new VideoCapture(mp4_file_path);
                max_frame = (int)capture.Get(VideoCaptureProperties.FrameCount);
                fps = (int)capture.Get(VideoCaptureProperties.Fps);

                this.VideoTimeBar.Maximum = max_frame;
            }

        }


        //CSVファイルのオープン
        private void CSV_Open_Click(object sender, EventArgs e)
        {
            csv_file_path = OpenFile(Define.CSV);
            for (int i = 0; i < Define.DATA_LENGTH; i++) csv_data[i] = 0;  //配列を初期化
            if (csv_file_path == null) return;
            else
            {
                data_len = OpenCSV(csv_file_path);
                SetText(data_len.ToString());
                this.FilenameBox.Text = System.IO.Path.GetFileNameWithoutExtension(csv_file_path) + "_";
            }
        }

        //ファイルを開く　引数：ファイルタイプ（MP4，CSV）　返り値：ファイルパス
        public String OpenFile(int filetype)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            if (filetype == Define.MP4 && mp4_flg) ofd.InitialDirectory = System.IO.Path.GetDirectoryName(mp4_file_path);
            else if (filetype == Define.CSV && csv_flg) ofd.InitialDirectory = System.IO.Path.GetDirectoryName(csv_file_path);
            else ofd.InitialDirectory = @"C:\S_test";    //はじめに表示されるフォルダを指定           

            if (filetype == Define.MP4) ofd.Filter = "mp4ファイル(*.mp4)|*.mp4|すべてのファイル(*.*)|*.*";  //[ファイルの種類]に表示される選択肢を指定する
            else if (filetype == Define.CSV) ofd.Filter = "csvファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 1;            //[ファイルの種類]ではじめに選択されるものを指定する
            ofd.Title = "開くファイルを選択してください";//タイトルを設定する
            ofd.RestoreDirectory = true;            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (filetype == Define.MP4)
                {
                    mp4_flg = true;
                    mp4_file.Text = System.IO.Path.GetFileName(ofd.FileName);
                }
                else if (filetype == Define.CSV)
                {
                    csv_flg = true;
                    csv_file.Text = System.IO.Path.GetFileName(ofd.FileName);
                }
                return ofd.FileName;
            }

            else return null;
        }

        //CSVファイルを開く　引数：ファイルパス，返り値：データ長
        public int OpenCSV(String filename)
        {
            // 読み込みたいCSVファイルのパスを指定して開く
            StreamReader sr;

            try
            {
                sr = new StreamReader(filename);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("ファイルが使用中です");
                return 0;
            }

            int i = 0;
            // 末尾まで繰り返す
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();            // CSVファイルの一行を読み込む
                string[] values = line.Split(',');      // 読み込んだ一行をカンマ毎に分けて配列に格納する

                if (!RawHapLog.Checked)//切り出した後のデータならそのまま読み込み
                {
                    csv_time[i] = double.Parse(values[0]);
                    csv_data[i] = double.Parse(values[1]);
                }  // csv_dataに値を格納
                else if (i > Define.HAPLOG_HEADER_ROW) //切り出し前なら，データのヘッダ部分は無視して読み込み
                {
                    csv_time[i - Define.HAPLOG_HEADER_ROW] = double.Parse(values[0]);
                    csv_data[i - Define.HAPLOG_HEADER_ROW] = double.Parse(values[1]);
                }
                i++;
            }

            csv_data_len = i - 1; //読み込んだデータ長を保存
            csv_flg = true;
            return i - 1;
        }


        #endregion

        #region 動画再生関係
        //再生ボタン
        private void Play_Movie_Click(object sender, EventArgs e)
        {
            if (!play_flg)
            {
                if (mp4_flg)
                {
                    play_flg = true;
                    Play_Movie.Text = "Stop Movie";
                    tmr = new System.Windows.Forms.Timer();
                    tmr.Tick += new System.EventHandler(timer_Tick);
                    tmr.Interval = interval ;
                    tmr.Start();
                }
            }
            else { 
                tmr.Stop();
                play_flg = false;
                Play_Movie.Text = "Play Movie";
            }
        }


        //一コマ送り
        private void OneFwd_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter > max_frame) counter = max_frame;
            DrawRefresh(counter);
        }

        //一コマ戻し
        private void OneBack_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0) counter = 0;
            DrawRefresh(counter);
        }

        //10コマ送り
       private void TenFwd_Click(object sender, EventArgs e)
        {
            counter += 10;
            if (counter > max_frame) counter = max_frame;
            DrawRefresh(counter);
        }

        //10コマ戻し
        private void TenBack_Click(object sender, EventArgs e)
        {
            counter -= 10;
            if (counter < 0) counter = 0;
            DrawRefresh(counter); 
        }

        //50コマ送り
        private void FiftyFwd_Click(object sender, EventArgs e)
        {
            counter += 50;
            if (counter > max_frame) counter = max_frame;
            DrawRefresh(counter);
        }
        
        //50コマ戻し
        private void FiftyBack_Click(object sender, EventArgs e)
        {
            counter -= 50;
            if (counter < 0) counter = 0;
            DrawRefresh(counter);
        }

        #endregion



        //描画領域のピクセル数分だけ，中心周りにデータをピックアップ
        public double[] ChooseData(double[] data, int data_num)
        {
            double[] draw_data = new double[GraphBox.Width];
            int k = 0;
            int current_counter = 0;

            if (csv_stop_flag) current_counter = csv_frame_offset;
            else current_counter = csv_frame_offset + counter - csv_current_diff;

            current_frame = (int)((double)current_counter / v_framerate * Define.H_FRAMERATE) + diff_frame;
            for (int i = 0; i < GraphBox.Width; i++)
            {
                k = current_frame + i * time_scale - GraphBox.Width * time_scale / 2;
                if (k < 0) draw_data[i] = 0.0;
                else if (k > data_num) draw_data[i] = 0.0;
                else draw_data[i] = csv_data[k];
            }
            //SetText("動画開始時より" + ((double)counter/v_framerate).ToString("F2") + "秒経過");
            return draw_data;
        }

        //GraphBoxというPictureBoxにグラフを描画
        //引数：(double)データ，　(int)データのサイズ
        public void DrawGraph(double[] data, int data_num)
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(GraphBox.Width, GraphBox.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);


            Rectangle rect = new Rectangle(0, 0, GraphBox.Width, GraphBox.Height);
            //領域を黒で塗る
            g.FillRectangle(Brushes.Black, rect);

            //タイミング線を描く
            g.DrawLine(Pens.Red, GraphBox.Width / 2, 0, GraphBox.Width / 2, GraphBox.Height);

            for (int i = 0; i < GraphBox.Width-1; i++) {
                g.DrawLine(Pens.White, GraphBox.Width - i, (int)(GraphBox.Height - (data[i] * draw_scale / 3)), 
                    GraphBox.Width - (i + 1), (int)(GraphBox.Height - (data[i+1] * draw_scale / 3)));
            }
            //Graphicsオブジェクトのリソースを解放する
            g.Dispose();
            //PictureBox1に表示する
            GraphBox.Image = canvas;
            if (current_frame < Define.DATA_LENGTH)
            {
                if (current_frame >= 0) SetText2(csv_time[current_frame].ToString());
            }
        }

        //再生速度の変化 intervalを書き換え，再生中であれば一旦止めてintervalを書き換えて再再生
        public void ChangeSpeed(int scale)
        {

            interval = (int)(1000 / v_framerate) * scale;
            if (play_flg)
            {
                tmr.Stop();
                tmr = new System.Windows.Forms.Timer();
                tmr.Tick += new System.EventHandler(timer_Tick);
                tmr.Interval = interval;
                tmr.Start();
            }
        }

        //再生速度ラジオボタンの選択
        private void radioSpeed1_CheckedChanged(object sender, EventArgs e) { ChangeSpeed(1); }
        private void radioSpeed2_CheckedChanged(object sender, EventArgs e) { ChangeSpeed(2); }
        private void radioSpeed3_CheckedChanged(object sender, EventArgs e) { ChangeSpeed(4); }
        private void radioSpeed4_CheckedChanged(object sender, EventArgs e) { ChangeSpeed(8); }


        //ファイルコーデック選択ラジオボタン
        private void radioMJPG_CheckedChanged(object sender, EventArgs e) { FileCodec = FourCCValues.MJPG; }
        private void radioH264_CheckedChanged(object sender, EventArgs e) { FileCodec = FourCCValues.H264; }

        public void ChangeCSV (int diff)
        {
            diff_frame += diff;
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width); 
//            ResText2.Text = "CSVファイルのズレは"+diff_frame.ToString() + " フレーム";

        }

        private void FiveBackCSV_Click(object sender, EventArgs e) { ChangeCSV(-5 * time_scale); }
        private void OneBackCSV_Click(object sender, EventArgs e) { ChangeCSV(-1); }
        private void OneFwdCSV_Click(object sender, EventArgs e) { ChangeCSV(1); }
        private void FiveFwdCSV_Click(object sender, EventArgs e) { ChangeCSV(5 * time_scale); }
        private void ResetCSV_Click(object sender, EventArgs e){ ChangeCSV(-1*diff_frame);} //リセットのために，現在のdiff_frame分だけ引く

        private void CutSave_Click(object sender, EventArgs e)
        {
            int i = 0;

            string mp4_folder_path = System.IO.Path.GetDirectoryName(mp4_file_path);
            string csv_folder_path = System.IO.Path.GetDirectoryName(csv_file_path);

            StreamWriter sw = new StreamWriter(csv_folder_path + "\\" + FilenameBox.Text + ".csv", false, Encoding.UTF8);
            VideoWriter write = new VideoWriter(mp4_folder_path + "\\" + FilenameBox.Text + ".mp4", FileCodec, capture.Fps, new OpenCvSharp.Size(capture.FrameWidth, capture.FrameHeight));
            capture.Set(VideoCaptureProperties.PosFrames, counter);


            for (int j = 0; j < int.Parse(SaveSeconds.Text) * Define.H_FRAMERATE; j++)
            {
               /* if (j + current_frame > csv_data_len)
                {
                    short_idx = j / Define.H_FRAMERATE * v_framerate;
                    break;
                }*/
//                else 
                  sw.WriteLine(csv_time[j + current_frame] + "," + csv_data[j + current_frame]);
            }
            sw.Dispose();

            while (true)
            {
                capture.Read(img);
                if (img.Empty()) break;
                else if (i > int.Parse(SaveSeconds.Text) * fps) break;
                else write.Write(img);
                i++;
             }

            SetText("変換終了");
            write.Dispose();
            System.Media.SystemSounds.Asterisk.Play();
        }

        //CSVの表示スケール変更
        private void timeScaleShort_CheckedChanged(object sender, EventArgs e)
        {
            time_scale = Define.TIME_SCALE_SHORT;
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);
        }

        private void timeScaleStd_CheckedChanged(object sender, EventArgs e)
        {
            time_scale = Define.TIME_SCALE_STANDARD;
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);
        }

        private void timeScaleLong_CheckedChanged(object sender, EventArgs e)
        {
            time_scale = Define.TIME_SCALE_LONG;
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);
        }


        private void StopCSV_Click(object sender, EventArgs e)
        {
            if (csv_stop_flag) { 
                StopCSV.BackColor = Color.Transparent;
                csv_stop_flag = false;
                csv_current_diff = counter; //再開した瞬間のcounter値を格納
            }

            else { 
                StopCSV.BackColor = Color.DarkRed;
                csv_stop_flag = true;
                csv_frame_offset = counter; //止めた瞬間のカウンター値を格納
            }
            
        }

        private void GoProCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (GoProCheck.Checked) v_framerate = Define.V_FRAMERATE_GOPRO;
            else v_framerate = Define.V_FRAMERATE_VID;
        }

        //時間指定テキストボックスの変更時
        private void SecDet_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < csv_data_len - 10; i++)
                {
                    if (csv_time[i] == double.Parse(SecDet.Text)) { diff_frame = i - (int)((double)counter / v_framerate * Define.H_FRAMERATE); } 
                    //diff_frameにすべて変化を格納する．ただし，動画のcounter分のフレームは補償ししてやる必要がある
                }
                //グラフの更新
                double[] draw_data = ChooseData(csv_data, data_len);
                DrawGraph(draw_data, GraphBox.Width);
            }
        }

        private void rScaleNormal_CheckedChanged(object sender, EventArgs e)
        {
            draw_scale = Define.DRAW_SCALE;
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);
        }

        private void rScale1_2_CheckedChanged(object sender, EventArgs e)
        {
            draw_scale = Define.DRAW_SCALE / 2;
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);

        }

        private void rScale1_4_CheckedChanged(object sender, EventArgs e)
        {
            draw_scale = Define.DRAW_SCALE / 4;
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);

        }

        private void rScale1_8_CheckedChanged(object sender, EventArgs e)
        {
            draw_scale = Define.DRAW_SCALE / 8;
            //グラフの更新
            double[] draw_data = ChooseData(csv_data, data_len);
            DrawGraph(draw_data, GraphBox.Width);
        }

        private void VideoTimeBar_Scroll(object sender, EventArgs e)
        {
            counter = this.VideoTimeBar.Value;
            DrawRefresh(counter);
        }

        //間引いて保存
        private void DownSampling_Click(object sender, EventArgs e)
        {
            SetText("変換中");
            int i = 0;

            VideoWriter write = new VideoWriter(mp4_file_path + "_out.mp4", FileCodec ,capture.Fps, new OpenCvSharp.Size(capture.FrameWidth, capture.FrameHeight));
            capture.Set(VideoCaptureProperties.PosFrames, counter);

           
            while (true)
            {
                capture.Read(img);
                if (img.Empty()) break;

                if (i % 2 == 0) write.Write(img);
                i++;


            }
            MessageBox.Show("変換終了");
            SetText("変換終了");
            write.Dispose();

        }


    }
}
