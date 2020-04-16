namespace OpenCVSharp_Capture
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MP4_Open = new System.Windows.Forms.Button();
            this.VideoTimeBar = new System.Windows.Forms.TrackBar();
            this.ResText = new System.Windows.Forms.Label();
            this.GraphBox = new System.Windows.Forms.PictureBox();
            this.CSV_Open = new System.Windows.Forms.Button();
            this.Play_Movie = new System.Windows.Forms.Button();
            this.OneBack = new System.Windows.Forms.Button();
            this.OneFwd = new System.Windows.Forms.Button();
            this.ResText2 = new System.Windows.Forms.Label();
            this.TenBack = new System.Windows.Forms.Button();
            this.TenFwd = new System.Windows.Forms.Button();
            this.mp4_file = new System.Windows.Forms.Label();
            this.csv_file = new System.Windows.Forms.Label();
            this.radioSpeed1 = new System.Windows.Forms.RadioButton();
            this.radioSpeed2 = new System.Windows.Forms.RadioButton();
            this.radioSpeed3 = new System.Windows.Forms.RadioButton();
            this.SpeedGroup = new System.Windows.Forms.GroupBox();
            this.radioSpeed4 = new System.Windows.Forms.RadioButton();
            this.FiveFwdCSV = new System.Windows.Forms.Button();
            this.FiveBackCSV = new System.Windows.Forms.Button();
            this.OneFwdCSV = new System.Windows.Forms.Button();
            this.OneBackCSV = new System.Windows.Forms.Button();
            this.CSVgroup = new System.Windows.Forms.GroupBox();
            this.DrawScale = new System.Windows.Forms.GroupBox();
            this.rScale1_8 = new System.Windows.Forms.RadioButton();
            this.rScale1_4 = new System.Windows.Forms.RadioButton();
            this.rScale1_2 = new System.Windows.Forms.RadioButton();
            this.rScaleNormal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SecDet = new System.Windows.Forms.TextBox();
            this.StopCSV = new System.Windows.Forms.Button();
            this.RawHapLog = new System.Windows.Forms.CheckBox();
            this.timeScaleStd = new System.Windows.Forms.RadioButton();
            this.timeScaleLong = new System.Windows.Forms.RadioButton();
            this.timeScaleShort = new System.Windows.Forms.RadioButton();
            this.ResetCSV = new System.Windows.Forms.Button();
            this.SaveSeconds = new System.Windows.Forms.TextBox();
            this.DownSampling = new System.Windows.Forms.Button();
            this.GoProCheck = new System.Windows.Forms.CheckBox();
            this.CutSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMJPG = new System.Windows.Forms.RadioButton();
            this.radioH264 = new System.Windows.Forms.RadioButton();
            this.FiftyBack = new System.Windows.Forms.Button();
            this.FiftyFwd = new System.Windows.Forms.Button();
            this.FilenameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rScalex2 = new System.Windows.Forms.RadioButton();
            this.rScalex4 = new System.Windows.Forms.RadioButton();
            this.CSV_StartFrameReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoTimeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).BeginInit();
            this.SpeedGroup.SuspendLayout();
            this.CSVgroup.SuspendLayout();
            this.DrawScale.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MP4_Open
            // 
            this.MP4_Open.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MP4_Open.Location = new System.Drawing.Point(988, 12);
            this.MP4_Open.Name = "MP4_Open";
            this.MP4_Open.Size = new System.Drawing.Size(97, 48);
            this.MP4_Open.TabIndex = 1;
            this.MP4_Open.Text = "Open mp4";
            this.MP4_Open.UseVisualStyleBackColor = true;
            this.MP4_Open.Click += new System.EventHandler(this.MP4open_Click);
            // 
            // VideoTimeBar
            // 
            this.VideoTimeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VideoTimeBar.Location = new System.Drawing.Point(9, 436);
            this.VideoTimeBar.Margin = new System.Windows.Forms.Padding(0);
            this.VideoTimeBar.Maximum = 0;
            this.VideoTimeBar.Name = "VideoTimeBar";
            this.VideoTimeBar.Size = new System.Drawing.Size(680, 45);
            this.VideoTimeBar.TabIndex = 2;
            this.VideoTimeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VideoTimeBar.Scroll += new System.EventHandler(this.VideoTimeBar_Scroll);
            this.VideoTimeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScrollBar_Click);
            // 
            // ResText
            // 
            this.ResText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResText.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResText.Location = new System.Drawing.Point(703, 700);
            this.ResText.Name = "ResText";
            this.ResText.Size = new System.Drawing.Size(299, 52);
            this.ResText.TabIndex = 3;
            this.ResText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GraphBox
            // 
            this.GraphBox.Location = new System.Drawing.Point(12, 484);
            this.GraphBox.Name = "GraphBox";
            this.GraphBox.Size = new System.Drawing.Size(680, 148);
            this.GraphBox.TabIndex = 4;
            this.GraphBox.TabStop = false;
            // 
            // CSV_Open
            // 
            this.CSV_Open.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CSV_Open.Location = new System.Drawing.Point(988, 72);
            this.CSV_Open.Name = "CSV_Open";
            this.CSV_Open.Size = new System.Drawing.Size(97, 48);
            this.CSV_Open.TabIndex = 5;
            this.CSV_Open.Text = "Open csv";
            this.CSV_Open.UseVisualStyleBackColor = true;
            this.CSV_Open.Click += new System.EventHandler(this.CSV_Open_Click);
            // 
            // Play_Movie
            // 
            this.Play_Movie.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Play_Movie.Location = new System.Drawing.Point(860, 132);
            this.Play_Movie.Name = "Play_Movie";
            this.Play_Movie.Size = new System.Drawing.Size(103, 48);
            this.Play_Movie.TabIndex = 6;
            this.Play_Movie.Text = "Play Movie";
            this.Play_Movie.UseVisualStyleBackColor = true;
            this.Play_Movie.Click += new System.EventHandler(this.Play_Movie_Click);
            // 
            // OneBack
            // 
            this.OneBack.Location = new System.Drawing.Point(811, 132);
            this.OneBack.Name = "OneBack";
            this.OneBack.Size = new System.Drawing.Size(43, 48);
            this.OneBack.TabIndex = 7;
            this.OneBack.Text = "< 1";
            this.OneBack.UseVisualStyleBackColor = true;
            this.OneBack.Click += new System.EventHandler(this.OneBack_Click);
            // 
            // OneFwd
            // 
            this.OneFwd.Location = new System.Drawing.Point(969, 132);
            this.OneFwd.Name = "OneFwd";
            this.OneFwd.Size = new System.Drawing.Size(43, 48);
            this.OneFwd.TabIndex = 8;
            this.OneFwd.Text = "1 >";
            this.OneFwd.UseVisualStyleBackColor = true;
            this.OneFwd.Click += new System.EventHandler(this.OneFwd_Click);
            // 
            // ResText2
            // 
            this.ResText2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResText2.Location = new System.Drawing.Point(209, 217);
            this.ResText2.Name = "ResText2";
            this.ResText2.Size = new System.Drawing.Size(184, 46);
            this.ResText2.TabIndex = 9;
            this.ResText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TenBack
            // 
            this.TenBack.Location = new System.Drawing.Point(762, 132);
            this.TenBack.Name = "TenBack";
            this.TenBack.Size = new System.Drawing.Size(43, 48);
            this.TenBack.TabIndex = 10;
            this.TenBack.Text = "<< 10";
            this.TenBack.UseVisualStyleBackColor = true;
            this.TenBack.Click += new System.EventHandler(this.TenBack_Click);
            // 
            // TenFwd
            // 
            this.TenFwd.Location = new System.Drawing.Point(1018, 132);
            this.TenFwd.Name = "TenFwd";
            this.TenFwd.Size = new System.Drawing.Size(43, 48);
            this.TenFwd.TabIndex = 11;
            this.TenFwd.Text = "10 >>";
            this.TenFwd.UseVisualStyleBackColor = true;
            this.TenFwd.Click += new System.EventHandler(this.TenFwd_Click);
            // 
            // mp4_file
            // 
            this.mp4_file.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mp4_file.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mp4_file.Location = new System.Drawing.Point(712, 12);
            this.mp4_file.Name = "mp4_file";
            this.mp4_file.Size = new System.Drawing.Size(198, 48);
            this.mp4_file.TabIndex = 12;
            this.mp4_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // csv_file
            // 
            this.csv_file.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.csv_file.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.csv_file.Location = new System.Drawing.Point(712, 72);
            this.csv_file.Name = "csv_file";
            this.csv_file.Size = new System.Drawing.Size(198, 48);
            this.csv_file.TabIndex = 13;
            this.csv_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioSpeed1
            // 
            this.radioSpeed1.AutoSize = true;
            this.radioSpeed1.Location = new System.Drawing.Point(29, 19);
            this.radioSpeed1.Name = "radioSpeed1";
            this.radioSpeed1.Size = new System.Drawing.Size(55, 27);
            this.radioSpeed1.TabIndex = 14;
            this.radioSpeed1.TabStop = true;
            this.radioSpeed1.Text = "×１";
            this.radioSpeed1.UseVisualStyleBackColor = true;
            this.radioSpeed1.CheckedChanged += new System.EventHandler(this.radioSpeed1_CheckedChanged);
            // 
            // radioSpeed2
            // 
            this.radioSpeed2.AutoSize = true;
            this.radioSpeed2.Location = new System.Drawing.Point(29, 40);
            this.radioSpeed2.Name = "radioSpeed2";
            this.radioSpeed2.Size = new System.Drawing.Size(65, 27);
            this.radioSpeed2.TabIndex = 15;
            this.radioSpeed2.TabStop = true;
            this.radioSpeed2.Text = "×1/2";
            this.radioSpeed2.UseVisualStyleBackColor = true;
            this.radioSpeed2.CheckedChanged += new System.EventHandler(this.radioSpeed2_CheckedChanged);
            // 
            // radioSpeed3
            // 
            this.radioSpeed3.AutoSize = true;
            this.radioSpeed3.Location = new System.Drawing.Point(29, 62);
            this.radioSpeed3.Name = "radioSpeed3";
            this.radioSpeed3.Size = new System.Drawing.Size(65, 27);
            this.radioSpeed3.TabIndex = 16;
            this.radioSpeed3.TabStop = true;
            this.radioSpeed3.Text = "×1/4";
            this.radioSpeed3.UseVisualStyleBackColor = true;
            this.radioSpeed3.CheckedChanged += new System.EventHandler(this.radioSpeed3_CheckedChanged);
            // 
            // SpeedGroup
            // 
            this.SpeedGroup.Controls.Add(this.radioSpeed4);
            this.SpeedGroup.Controls.Add(this.radioSpeed1);
            this.SpeedGroup.Controls.Add(this.radioSpeed3);
            this.SpeedGroup.Controls.Add(this.radioSpeed2);
            this.SpeedGroup.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SpeedGroup.Location = new System.Drawing.Point(715, 186);
            this.SpeedGroup.Name = "SpeedGroup";
            this.SpeedGroup.Size = new System.Drawing.Size(115, 116);
            this.SpeedGroup.TabIndex = 17;
            this.SpeedGroup.TabStop = false;
            this.SpeedGroup.Text = "Play Speed";
            // 
            // radioSpeed4
            // 
            this.radioSpeed4.AutoSize = true;
            this.radioSpeed4.Location = new System.Drawing.Point(29, 83);
            this.radioSpeed4.Name = "radioSpeed4";
            this.radioSpeed4.Size = new System.Drawing.Size(65, 27);
            this.radioSpeed4.TabIndex = 17;
            this.radioSpeed4.TabStop = true;
            this.radioSpeed4.Text = "×1/8";
            this.radioSpeed4.UseVisualStyleBackColor = true;
            this.radioSpeed4.CheckedChanged += new System.EventHandler(this.radioSpeed4_CheckedChanged);
            // 
            // FiveFwdCSV
            // 
            this.FiveFwdCSV.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FiveFwdCSV.Location = new System.Drawing.Point(303, 26);
            this.FiveFwdCSV.Name = "FiveFwdCSV";
            this.FiveFwdCSV.Size = new System.Drawing.Size(84, 48);
            this.FiveFwdCSV.TabIndex = 21;
            this.FiveFwdCSV.Text = "表示時間>> に応じて";
            this.FiveFwdCSV.UseVisualStyleBackColor = true;
            this.FiveFwdCSV.Click += new System.EventHandler(this.FiveFwdCSV_Click);
            // 
            // FiveBackCSV
            // 
            this.FiveBackCSV.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FiveBackCSV.Location = new System.Drawing.Point(6, 26);
            this.FiveBackCSV.Name = "FiveBackCSV";
            this.FiveBackCSV.Size = new System.Drawing.Size(86, 48);
            this.FiveBackCSV.TabIndex = 20;
            this.FiveBackCSV.Text = "<< 表示時間に応じて";
            this.FiveBackCSV.UseVisualStyleBackColor = true;
            this.FiveBackCSV.Click += new System.EventHandler(this.FiveBackCSV_Click);
            // 
            // OneFwdCSV
            // 
            this.OneFwdCSV.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OneFwdCSV.Location = new System.Drawing.Point(230, 26);
            this.OneFwdCSV.Name = "OneFwdCSV";
            this.OneFwdCSV.Size = new System.Drawing.Size(67, 48);
            this.OneFwdCSV.TabIndex = 19;
            this.OneFwdCSV.Text = "1 コマ>";
            this.OneFwdCSV.UseVisualStyleBackColor = true;
            this.OneFwdCSV.Click += new System.EventHandler(this.OneFwdCSV_Click);
            // 
            // OneBackCSV
            // 
            this.OneBackCSV.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OneBackCSV.Location = new System.Drawing.Point(98, 26);
            this.OneBackCSV.Name = "OneBackCSV";
            this.OneBackCSV.Size = new System.Drawing.Size(63, 48);
            this.OneBackCSV.TabIndex = 18;
            this.OneBackCSV.Text = "< 1コマ";
            this.OneBackCSV.UseVisualStyleBackColor = true;
            this.OneBackCSV.Click += new System.EventHandler(this.OneBackCSV_Click);
            // 
            // CSVgroup
            // 
            this.CSVgroup.Controls.Add(this.CSV_StartFrameReset);
            this.CSVgroup.Controls.Add(this.DrawScale);
            this.CSVgroup.Controls.Add(this.label2);
            this.CSVgroup.Controls.Add(this.SecDet);
            this.CSVgroup.Controls.Add(this.StopCSV);
            this.CSVgroup.Controls.Add(this.RawHapLog);
            this.CSVgroup.Controls.Add(this.timeScaleStd);
            this.CSVgroup.Controls.Add(this.timeScaleLong);
            this.CSVgroup.Controls.Add(this.timeScaleShort);
            this.CSVgroup.Controls.Add(this.ResetCSV);
            this.CSVgroup.Controls.Add(this.FiveBackCSV);
            this.CSVgroup.Controls.Add(this.FiveFwdCSV);
            this.CSVgroup.Controls.Add(this.OneBackCSV);
            this.CSVgroup.Controls.Add(this.OneFwdCSV);
            this.CSVgroup.Controls.Add(this.ResText2);
            this.CSVgroup.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CSVgroup.Location = new System.Drawing.Point(717, 310);
            this.CSVgroup.Name = "CSVgroup";
            this.CSVgroup.Size = new System.Drawing.Size(407, 277);
            this.CSVgroup.TabIndex = 22;
            this.CSVgroup.TabStop = false;
            this.CSVgroup.Text = "csv file adjustment";
            // 
            // DrawScale
            // 
            this.DrawScale.Controls.Add(this.rScalex4);
            this.DrawScale.Controls.Add(this.rScalex2);
            this.DrawScale.Controls.Add(this.rScale1_8);
            this.DrawScale.Controls.Add(this.rScale1_4);
            this.DrawScale.Controls.Add(this.rScale1_2);
            this.DrawScale.Controls.Add(this.rScaleNormal);
            this.DrawScale.Location = new System.Drawing.Point(139, 80);
            this.DrawScale.Name = "DrawScale";
            this.DrawScale.Size = new System.Drawing.Size(156, 119);
            this.DrawScale.TabIndex = 34;
            this.DrawScale.TabStop = false;
            this.DrawScale.Text = "DrawScale";
            // 
            // rScale1_8
            // 
            this.rScale1_8.AutoSize = true;
            this.rScale1_8.Location = new System.Drawing.Point(84, 85);
            this.rScale1_8.Name = "rScale1_8";
            this.rScale1_8.Size = new System.Drawing.Size(62, 25);
            this.rScale1_8.TabIndex = 3;
            this.rScale1_8.TabStop = true;
            this.rScale1_8.Text = "x1/8";
            this.rScale1_8.UseVisualStyleBackColor = true;
            this.rScale1_8.CheckedChanged += new System.EventHandler(this.rScale1_8_CheckedChanged);
            // 
            // rScale1_4
            // 
            this.rScale1_4.AutoSize = true;
            this.rScale1_4.Location = new System.Drawing.Point(84, 54);
            this.rScale1_4.Name = "rScale1_4";
            this.rScale1_4.Size = new System.Drawing.Size(62, 25);
            this.rScale1_4.TabIndex = 2;
            this.rScale1_4.TabStop = true;
            this.rScale1_4.Text = "x1/4";
            this.rScale1_4.UseVisualStyleBackColor = true;
            this.rScale1_4.CheckedChanged += new System.EventHandler(this.rScale1_4_CheckedChanged);
            // 
            // rScale1_2
            // 
            this.rScale1_2.AutoSize = true;
            this.rScale1_2.Location = new System.Drawing.Point(84, 23);
            this.rScale1_2.Name = "rScale1_2";
            this.rScale1_2.Size = new System.Drawing.Size(62, 25);
            this.rScale1_2.TabIndex = 1;
            this.rScale1_2.TabStop = true;
            this.rScale1_2.Text = "x1/2";
            this.rScale1_2.UseVisualStyleBackColor = true;
            this.rScale1_2.CheckedChanged += new System.EventHandler(this.rScale1_2_CheckedChanged);
            // 
            // rScaleNormal
            // 
            this.rScaleNormal.AutoSize = true;
            this.rScaleNormal.Location = new System.Drawing.Point(9, 23);
            this.rScaleNormal.Name = "rScaleNormal";
            this.rScaleNormal.Size = new System.Drawing.Size(45, 25);
            this.rScaleNormal.TabIndex = 0;
            this.rScaleNormal.TabStop = true;
            this.rScaleNormal.Text = "x1";
            this.rScaleNormal.UseVisualStyleBackColor = true;
            this.rScaleNormal.CheckedChanged += new System.EventHandler(this.rScaleNormal_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "秒指定";
            // 
            // SecDet
            // 
            this.SecDet.Location = new System.Drawing.Point(61, 227);
            this.SecDet.Name = "SecDet";
            this.SecDet.Size = new System.Drawing.Size(100, 33);
            this.SecDet.TabIndex = 31;
            this.SecDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecDet_KeyDown);
            // 
            // StopCSV
            // 
            this.StopCSV.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StopCSV.Location = new System.Drawing.Point(303, 80);
            this.StopCSV.Name = "StopCSV";
            this.StopCSV.Size = new System.Drawing.Size(84, 48);
            this.StopCSV.TabIndex = 30;
            this.StopCSV.Text = " CSVのみ  停める";
            this.StopCSV.UseVisualStyleBackColor = true;
            this.StopCSV.Click += new System.EventHandler(this.StopCSV_Click);
            // 
            // RawHapLog
            // 
            this.RawHapLog.AutoSize = true;
            this.RawHapLog.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RawHapLog.Location = new System.Drawing.Point(13, 151);
            this.RawHapLog.Name = "RawHapLog";
            this.RawHapLog.Size = new System.Drawing.Size(120, 27);
            this.RawHapLog.TabIndex = 28;
            this.RawHapLog.Text = "Raw HapLog";
            this.RawHapLog.UseVisualStyleBackColor = true;
            // 
            // timeScaleStd
            // 
            this.timeScaleStd.AutoSize = true;
            this.timeScaleStd.Location = new System.Drawing.Point(13, 103);
            this.timeScaleStd.Name = "timeScaleStd";
            this.timeScaleStd.Size = new System.Drawing.Size(124, 25);
            this.timeScaleStd.TabIndex = 25;
            this.timeScaleStd.TabStop = true;
            this.timeScaleStd.Text = "表示時間標準";
            this.timeScaleStd.UseVisualStyleBackColor = true;
            this.timeScaleStd.CheckedChanged += new System.EventHandler(this.timeScaleStd_CheckedChanged);
            // 
            // timeScaleLong
            // 
            this.timeScaleLong.AutoSize = true;
            this.timeScaleLong.Location = new System.Drawing.Point(13, 126);
            this.timeScaleLong.Name = "timeScaleLong";
            this.timeScaleLong.Size = new System.Drawing.Size(124, 25);
            this.timeScaleLong.TabIndex = 24;
            this.timeScaleLong.TabStop = true;
            this.timeScaleLong.Text = "表示時間長い";
            this.timeScaleLong.UseVisualStyleBackColor = true;
            this.timeScaleLong.CheckedChanged += new System.EventHandler(this.timeScaleLong_CheckedChanged);
            // 
            // timeScaleShort
            // 
            this.timeScaleShort.AutoSize = true;
            this.timeScaleShort.Location = new System.Drawing.Point(13, 80);
            this.timeScaleShort.Name = "timeScaleShort";
            this.timeScaleShort.Size = new System.Drawing.Size(124, 25);
            this.timeScaleShort.TabIndex = 23;
            this.timeScaleShort.TabStop = true;
            this.timeScaleShort.Text = "表示時間短い";
            this.timeScaleShort.UseVisualStyleBackColor = true;
            this.timeScaleShort.CheckedChanged += new System.EventHandler(this.timeScaleShort_CheckedChanged);
            // 
            // ResetCSV
            // 
            this.ResetCSV.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResetCSV.Location = new System.Drawing.Point(165, 26);
            this.ResetCSV.Name = "ResetCSV";
            this.ResetCSV.Size = new System.Drawing.Size(61, 48);
            this.ResetCSV.TabIndex = 22;
            this.ResetCSV.Text = "Reset";
            this.ResetCSV.UseVisualStyleBackColor = true;
            this.ResetCSV.Click += new System.EventHandler(this.ResetCSV_Click);
            // 
            // SaveSeconds
            // 
            this.SaveSeconds.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveSeconds.Location = new System.Drawing.Point(703, 593);
            this.SaveSeconds.Name = "SaveSeconds";
            this.SaveSeconds.Size = new System.Drawing.Size(91, 30);
            this.SaveSeconds.TabIndex = 26;
            this.SaveSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DownSampling
            // 
            this.DownSampling.Enabled = false;
            this.DownSampling.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DownSampling.Location = new System.Drawing.Point(1018, 696);
            this.DownSampling.Name = "DownSampling";
            this.DownSampling.Size = new System.Drawing.Size(106, 53);
            this.DownSampling.TabIndex = 23;
            this.DownSampling.Text = "間引いて保存";
            this.DownSampling.UseVisualStyleBackColor = true;
            this.DownSampling.Click += new System.EventHandler(this.DownSampling_Click);
            // 
            // GoProCheck
            // 
            this.GoProCheck.AutoSize = true;
            this.GoProCheck.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GoProCheck.Location = new System.Drawing.Point(887, 186);
            this.GoProCheck.Name = "GoProCheck";
            this.GoProCheck.Size = new System.Drawing.Size(73, 27);
            this.GoProCheck.TabIndex = 24;
            this.GoProCheck.Text = "GoPro";
            this.GoProCheck.UseVisualStyleBackColor = true;
            this.GoProCheck.CheckedChanged += new System.EventHandler(this.GoProCheck_CheckedChanged);
            // 
            // CutSave
            // 
            this.CutSave.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CutSave.Location = new System.Drawing.Point(703, 633);
            this.CutSave.Name = "CutSave";
            this.CutSave.Size = new System.Drawing.Size(125, 53);
            this.CutSave.TabIndex = 25;
            this.CutSave.Text = " カーソル位置から 指定秒数保存";
            this.CutSave.UseVisualStyleBackColor = true;
            this.CutSave.Click += new System.EventHandler(this.CutSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(803, 600);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "秒";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMJPG);
            this.groupBox1.Controls.Add(this.radioH264);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(887, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 85);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Codec";
            // 
            // radioMJPG
            // 
            this.radioMJPG.AutoSize = true;
            this.radioMJPG.Location = new System.Drawing.Point(23, 29);
            this.radioMJPG.Name = "radioMJPG";
            this.radioMJPG.Size = new System.Drawing.Size(67, 27);
            this.radioMJPG.TabIndex = 14;
            this.radioMJPG.TabStop = true;
            this.radioMJPG.Text = "MJPG";
            this.radioMJPG.UseVisualStyleBackColor = true;
            this.radioMJPG.CheckedChanged += new System.EventHandler(this.radioMJPG_CheckedChanged);
            // 
            // radioH264
            // 
            this.radioH264.AutoSize = true;
            this.radioH264.Enabled = false;
            this.radioH264.Location = new System.Drawing.Point(23, 50);
            this.radioH264.Name = "radioH264";
            this.radioH264.Size = new System.Drawing.Size(71, 27);
            this.radioH264.TabIndex = 15;
            this.radioH264.TabStop = true;
            this.radioH264.Text = "H.264";
            this.radioH264.UseVisualStyleBackColor = true;
            this.radioH264.CheckedChanged += new System.EventHandler(this.radioH264_CheckedChanged);
            // 
            // FiftyBack
            // 
            this.FiftyBack.Location = new System.Drawing.Point(712, 132);
            this.FiftyBack.Name = "FiftyBack";
            this.FiftyBack.Size = new System.Drawing.Size(43, 48);
            this.FiftyBack.TabIndex = 28;
            this.FiftyBack.Text = "<< 50";
            this.FiftyBack.UseVisualStyleBackColor = true;
            this.FiftyBack.Click += new System.EventHandler(this.FiftyBack_Click);
            // 
            // FiftyFwd
            // 
            this.FiftyFwd.Location = new System.Drawing.Point(1067, 132);
            this.FiftyFwd.Name = "FiftyFwd";
            this.FiftyFwd.Size = new System.Drawing.Size(43, 48);
            this.FiftyFwd.TabIndex = 29;
            this.FiftyFwd.Text = "50 >>";
            this.FiftyFwd.UseVisualStyleBackColor = true;
            this.FiftyFwd.Click += new System.EventHandler(this.FiftyFwd_Click);
            // 
            // FilenameBox
            // 
            this.FilenameBox.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FilenameBox.Location = new System.Drawing.Point(861, 656);
            this.FilenameBox.Name = "FilenameBox";
            this.FilenameBox.Size = new System.Drawing.Size(116, 30);
            this.FilenameBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(983, 663);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = ".mp4/.csv";
            // 
            // rScalex2
            // 
            this.rScalex2.AutoSize = true;
            this.rScalex2.Location = new System.Drawing.Point(9, 54);
            this.rScalex2.Name = "rScalex2";
            this.rScalex2.Size = new System.Drawing.Size(45, 25);
            this.rScalex2.TabIndex = 4;
            this.rScalex2.TabStop = true;
            this.rScalex2.Text = "x2";
            this.rScalex2.UseVisualStyleBackColor = true;
            this.rScalex2.CheckedChanged += new System.EventHandler(this.rScalex2_CheckedChanged);
            // 
            // rScalex4
            // 
            this.rScalex4.AutoSize = true;
            this.rScalex4.Location = new System.Drawing.Point(9, 85);
            this.rScalex4.Name = "rScalex4";
            this.rScalex4.Size = new System.Drawing.Size(45, 25);
            this.rScalex4.TabIndex = 5;
            this.rScalex4.TabStop = true;
            this.rScalex4.Text = "x4";
            this.rScalex4.UseVisualStyleBackColor = true;
            this.rScalex4.CheckedChanged += new System.EventHandler(this.rScalex4_CheckedChanged);
            // 
            // CSV_StartFrameReset
            // 
            this.CSV_StartFrameReset.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CSV_StartFrameReset.Location = new System.Drawing.Point(301, 155);
            this.CSV_StartFrameReset.Name = "CSV_StartFrameReset";
            this.CSV_StartFrameReset.Size = new System.Drawing.Size(92, 48);
            this.CSV_StartFrameReset.TabIndex = 35;
            this.CSV_StartFrameReset.Text = " CSV開始時刻現フレームに";
            this.CSV_StartFrameReset.UseVisualStyleBackColor = true;
            this.CSV_StartFrameReset.Click += new System.EventHandler(this.CSV_StartFrameReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 761);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilenameBox);
            this.Controls.Add(this.FiftyFwd);
            this.Controls.Add(this.FiftyBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveSeconds);
            this.Controls.Add(this.CutSave);
            this.Controls.Add(this.GoProCheck);
            this.Controls.Add(this.DownSampling);
            this.Controls.Add(this.CSVgroup);
            this.Controls.Add(this.SpeedGroup);
            this.Controls.Add(this.csv_file);
            this.Controls.Add(this.mp4_file);
            this.Controls.Add(this.TenFwd);
            this.Controls.Add(this.ResText);
            this.Controls.Add(this.TenBack);
            this.Controls.Add(this.OneFwd);
            this.Controls.Add(this.OneBack);
            this.Controls.Add(this.Play_Movie);
            this.Controls.Add(this.CSV_Open);
            this.Controls.Add(this.GraphBox);
            this.Controls.Add(this.VideoTimeBar);
            this.Controls.Add(this.MP4_Open);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoTimeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).EndInit();
            this.SpeedGroup.ResumeLayout(false);
            this.SpeedGroup.PerformLayout();
            this.CSVgroup.ResumeLayout(false);
            this.CSVgroup.PerformLayout();
            this.DrawScale.ResumeLayout(false);
            this.DrawScale.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MP4_Open;
        private System.Windows.Forms.TrackBar VideoTimeBar;
        private System.Windows.Forms.Label ResText;
        private System.Windows.Forms.PictureBox GraphBox;
        private System.Windows.Forms.Button CSV_Open;
        private System.Windows.Forms.Button Play_Movie;
        private System.Windows.Forms.Button OneBack;
        private System.Windows.Forms.Button OneFwd;
        private System.Windows.Forms.Label ResText2;
        private System.Windows.Forms.Button TenBack;
        private System.Windows.Forms.Button TenFwd;
        private System.Windows.Forms.Label mp4_file;
        private System.Windows.Forms.Label csv_file;
        private System.Windows.Forms.RadioButton radioSpeed1;
        private System.Windows.Forms.RadioButton radioSpeed2;
        private System.Windows.Forms.RadioButton radioSpeed3;
        private System.Windows.Forms.GroupBox SpeedGroup;
        private System.Windows.Forms.RadioButton radioSpeed4;
        private System.Windows.Forms.Button FiveFwdCSV;
        private System.Windows.Forms.Button FiveBackCSV;
        private System.Windows.Forms.Button OneFwdCSV;
        private System.Windows.Forms.Button OneBackCSV;
        private System.Windows.Forms.GroupBox CSVgroup;
        private System.Windows.Forms.Button ResetCSV;
        private System.Windows.Forms.Button DownSampling;
        private System.Windows.Forms.CheckBox GoProCheck;
        private System.Windows.Forms.TextBox SaveSeconds;
        private System.Windows.Forms.Button CutSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMJPG;
        private System.Windows.Forms.RadioButton radioH264;
        private System.Windows.Forms.RadioButton timeScaleStd;
        private System.Windows.Forms.RadioButton timeScaleLong;
        private System.Windows.Forms.RadioButton timeScaleShort;
        private System.Windows.Forms.CheckBox RawHapLog;
        private System.Windows.Forms.Button StopCSV;
        private System.Windows.Forms.Button FiftyBack;
        private System.Windows.Forms.Button FiftyFwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecDet;
        private System.Windows.Forms.TextBox FilenameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox DrawScale;
        private System.Windows.Forms.RadioButton rScale1_8;
        private System.Windows.Forms.RadioButton rScale1_4;
        private System.Windows.Forms.RadioButton rScale1_2;
        private System.Windows.Forms.RadioButton rScaleNormal;
        private System.Windows.Forms.RadioButton rScalex4;
        private System.Windows.Forms.RadioButton rScalex2;
        private System.Windows.Forms.Button CSV_StartFrameReset;
    }
}

