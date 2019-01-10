namespace SentimentAnalysis
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InsiraTexto = new System.Windows.Forms.ToolTip(this.components);
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveXML = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabText = new System.Windows.Forms.TabPage();
            this.EmotionEngButton = new System.Windows.Forms.Button();
            this.Top_10_NoStopsButton = new System.Windows.Forms.Button();
            this.Top10_wordsButton = new System.Windows.Forms.Button();
            this.List_StopwordsButton = new System.Windows.Forms.Button();
            this.DataEmotions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Stopwords = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.top_10_Stem = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Stem_NoStops = new System.Windows.Forms.ListView();
            this.Top_10NoStops = new System.Windows.Forms.ListView();
            this.Top_10Words = new System.Windows.Forms.ListView();
            this.Trigrams = new System.Windows.Forms.ListView();
            this.Bigrams = new System.Windows.Forms.ListView();
            this.comboTop10 = new System.Windows.Forms.ComboBox();
            this.comboNoStops = new System.Windows.Forms.ComboBox();
            this.comboEmotion = new System.Windows.Forms.ComboBox();
            this.TabStats = new System.Windows.Forms.TabPage();
            this.Button_StrongCorr = new System.Windows.Forms.Button();
            this.Button_Stats = new System.Windows.Forms.Button();
            this.dataCorrelations = new System.Windows.Forms.DataGridView();
            this.data_All_Words = new System.Windows.Forms.DataGridView();
            this.comboStats = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.TabText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataEmotions)).BeginInit();
            this.TabStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCorrelations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_All_Words)).BeginInit();
            this.SuspendLayout();
            // 
            // InsiraTexto
            // 
            this.InsiraTexto.IsBalloon = true;
            this.InsiraTexto.Tag = "";
            this.InsiraTexto.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InsiraTexto.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.InputTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputTextBox.Location = new System.Drawing.Point(0, 0);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(831, 139);
            this.InputTextBox.TabIndex = 28;
            this.InputTextBox.Text = "";
            this.InsiraTexto.SetToolTip(this.InputTextBox, "Insira o Texto!");
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // SaveXML
            // 
            this.SaveXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveXML.Location = new System.Drawing.Point(671, 243);
            this.SaveXML.Name = "SaveXML";
            this.SaveXML.Size = new System.Drawing.Size(127, 31);
            this.SaveXML.TabIndex = 8;
            this.SaveXML.Text = "Save Data to XML";
            this.InsiraTexto.SetToolTip(this.SaveXML, "File saved in C:\\");
            this.SaveXML.UseVisualStyleBackColor = true;
            this.SaveXML.Click += new System.EventHandler(this.SaveXML_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabText);
            this.tabControl1.Controls.Add(this.TabStats);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 553);
            this.tabControl1.TabIndex = 31;
            // 
            // TabText
            // 
            this.TabText.BackColor = System.Drawing.Color.SteelBlue;
            this.TabText.Controls.Add(this.EmotionEngButton);
            this.TabText.Controls.Add(this.Top_10_NoStopsButton);
            this.TabText.Controls.Add(this.Top10_wordsButton);
            this.TabText.Controls.Add(this.List_StopwordsButton);
            this.TabText.Controls.Add(this.DataEmotions);
            this.TabText.Controls.Add(this.label2);
            this.TabText.Controls.Add(this.Stopwords);
            this.TabText.Controls.Add(this.label8);
            this.TabText.Controls.Add(this.top_10_Stem);
            this.TabText.Controls.Add(this.label7);
            this.TabText.Controls.Add(this.label6);
            this.TabText.Controls.Add(this.label5);
            this.TabText.Controls.Add(this.label4);
            this.TabText.Controls.Add(this.label3);
            this.TabText.Controls.Add(this.Stem_NoStops);
            this.TabText.Controls.Add(this.Top_10NoStops);
            this.TabText.Controls.Add(this.Top_10Words);
            this.TabText.Controls.Add(this.Trigrams);
            this.TabText.Controls.Add(this.Bigrams);
            this.TabText.Controls.Add(this.comboTop10);
            this.TabText.Controls.Add(this.comboNoStops);
            this.TabText.Controls.Add(this.comboEmotion);
            this.TabText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TabText.Location = new System.Drawing.Point(4, 25);
            this.TabText.Name = "TabText";
            this.TabText.Padding = new System.Windows.Forms.Padding(3);
            this.TabText.Size = new System.Drawing.Size(823, 524);
            this.TabText.TabIndex = 0;
            this.TabText.Text = "Text & Sentiment Analysis";
            // 
            // EmotionEngButton
            // 
            this.EmotionEngButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmotionEngButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmotionEngButton.Location = new System.Drawing.Point(693, 285);
            this.EmotionEngButton.Name = "EmotionEngButton";
            this.EmotionEngButton.Size = new System.Drawing.Size(102, 45);
            this.EmotionEngButton.TabIndex = 45;
            this.EmotionEngButton.Text = "Emotion Analysis";
            this.EmotionEngButton.UseVisualStyleBackColor = true;
            this.EmotionEngButton.Click += new System.EventHandler(this.EmotionEngButton_Click);
            // 
            // Top_10_NoStopsButton
            // 
            this.Top_10_NoStopsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Top_10_NoStopsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_10_NoStopsButton.Location = new System.Drawing.Point(693, 194);
            this.Top_10_NoStopsButton.Name = "Top_10_NoStopsButton";
            this.Top_10_NoStopsButton.Size = new System.Drawing.Size(102, 35);
            this.Top_10_NoStopsButton.TabIndex = 42;
            this.Top_10_NoStopsButton.Text = "NoStopwords";
            this.Top_10_NoStopsButton.UseVisualStyleBackColor = true;
            this.Top_10_NoStopsButton.Click += new System.EventHandler(this.Top_10_NoStopsButton_Click_1);
            // 
            // Top10_wordsButton
            // 
            this.Top10_wordsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Top10_wordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top10_wordsButton.Location = new System.Drawing.Point(693, 127);
            this.Top10_wordsButton.Name = "Top10_wordsButton";
            this.Top10_wordsButton.Size = new System.Drawing.Size(102, 35);
            this.Top10_wordsButton.TabIndex = 41;
            this.Top10_wordsButton.Text = "Top 10 words";
            this.Top10_wordsButton.UseVisualStyleBackColor = true;
            this.Top10_wordsButton.Click += new System.EventHandler(this.Top10_wordsButton_Click);
            // 
            // List_StopwordsButton
            // 
            this.List_StopwordsButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.List_StopwordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_StopwordsButton.Location = new System.Drawing.Point(696, 49);
            this.List_StopwordsButton.Name = "List_StopwordsButton";
            this.List_StopwordsButton.Size = new System.Drawing.Size(102, 41);
            this.List_StopwordsButton.TabIndex = 40;
            this.List_StopwordsButton.Text = "List Stopwords";
            this.List_StopwordsButton.UseVisualStyleBackColor = true;
            this.List_StopwordsButton.Click += new System.EventHandler(this.List_StopwordsButton_Click);
            // 
            // DataEmotions
            // 
            this.DataEmotions.AllowUserToAddRows = false;
            this.DataEmotions.AllowUserToDeleteRows = false;
            this.DataEmotions.AllowUserToResizeRows = false;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DataEmotions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle61;
            this.DataEmotions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataEmotions.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataEmotions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.DataEmotions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataEmotions.DefaultCellStyle = dataGridViewCellStyle63;
            this.DataEmotions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataEmotions.Location = new System.Drawing.Point(3, 429);
            this.DataEmotions.Name = "DataEmotions";
            this.DataEmotions.ReadOnly = true;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataEmotions.RowHeadersDefaultCellStyle = dataGridViewCellStyle64;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataEmotions.RowsDefaultCellStyle = dataGridViewCellStyle65;
            this.DataEmotions.Size = new System.Drawing.Size(817, 92);
            this.DataEmotions.TabIndex = 39;
            this.DataEmotions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataEmotions_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(62, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Bigrams";
            // 
            // Stopwords
            // 
            this.Stopwords.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Stopwords.BackColor = System.Drawing.Color.GhostWhite;
            this.Stopwords.CheckOnClick = true;
            this.Stopwords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopwords.FormattingEnabled = true;
            this.Stopwords.Location = new System.Drawing.Point(442, 25);
            this.Stopwords.MultiColumn = true;
            this.Stopwords.Name = "Stopwords";
            this.Stopwords.Size = new System.Drawing.Size(236, 169);
            this.Stopwords.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(522, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Stemmed_NoStopwords";
            // 
            // top_10_Stem
            // 
            this.top_10_Stem.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.top_10_Stem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.top_10_Stem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.top_10_Stem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_10_Stem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.top_10_Stem.GridLines = true;
            this.top_10_Stem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.top_10_Stem.Location = new System.Drawing.Point(172, 231);
            this.top_10_Stem.Name = "top_10_Stem";
            this.top_10_Stem.Size = new System.Drawing.Size(154, 171);
            this.top_10_Stem.TabIndex = 25;
            this.top_10_Stem.UseCompatibleStateImageBehavior = false;
            this.top_10_Stem.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(355, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Top 10_NoStopwords";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(196, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Top 10_Stemmed";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(32, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Top 10 Words";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(534, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Stopwords";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(291, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Trigrams";
            // 
            // Stem_NoStops
            // 
            this.Stem_NoStops.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Stem_NoStops.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Stem_NoStops.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Stem_NoStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stem_NoStops.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Stem_NoStops.GridLines = true;
            this.Stem_NoStops.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Stem_NoStops.Location = new System.Drawing.Point(525, 231);
            this.Stem_NoStops.Name = "Stem_NoStops";
            this.Stem_NoStops.Size = new System.Drawing.Size(153, 171);
            this.Stem_NoStops.TabIndex = 26;
            this.Stem_NoStops.UseCompatibleStateImageBehavior = false;
            this.Stem_NoStops.View = System.Windows.Forms.View.List;
            // 
            // Top_10NoStops
            // 
            this.Top_10NoStops.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Top_10NoStops.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Top_10NoStops.BackColor = System.Drawing.Color.GhostWhite;
            this.Top_10NoStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_10NoStops.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Top_10NoStops.GridLines = true;
            this.Top_10NoStops.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Top_10NoStops.Location = new System.Drawing.Point(349, 231);
            this.Top_10NoStops.Name = "Top_10NoStops";
            this.Top_10NoStops.Size = new System.Drawing.Size(155, 171);
            this.Top_10NoStops.TabIndex = 27;
            this.Top_10NoStops.UseCompatibleStateImageBehavior = false;
            this.Top_10NoStops.View = System.Windows.Forms.View.List;
            // 
            // Top_10Words
            // 
            this.Top_10Words.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Top_10Words.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Top_10Words.BackColor = System.Drawing.Color.GhostWhite;
            this.Top_10Words.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top_10Words.GridLines = true;
            this.Top_10Words.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Top_10Words.Location = new System.Drawing.Point(5, 231);
            this.Top_10Words.Name = "Top_10Words";
            this.Top_10Words.Size = new System.Drawing.Size(148, 171);
            this.Top_10Words.TabIndex = 28;
            this.Top_10Words.UseCompatibleStateImageBehavior = false;
            this.Top_10Words.View = System.Windows.Forms.View.List;
            // 
            // Trigrams
            // 
            this.Trigrams.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Trigrams.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Trigrams.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Trigrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trigrams.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Trigrams.GridLines = true;
            this.Trigrams.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Trigrams.Location = new System.Drawing.Point(199, 25);
            this.Trigrams.Name = "Trigrams";
            this.Trigrams.Size = new System.Drawing.Size(237, 165);
            this.Trigrams.TabIndex = 29;
            this.Trigrams.UseCompatibleStateImageBehavior = false;
            this.Trigrams.View = System.Windows.Forms.View.List;
            // 
            // Bigrams
            // 
            this.Bigrams.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Bigrams.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Bigrams.BackColor = System.Drawing.Color.GhostWhite;
            this.Bigrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bigrams.GridLines = true;
            this.Bigrams.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Bigrams.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.Bigrams.Location = new System.Drawing.Point(5, 25);
            this.Bigrams.Name = "Bigrams";
            this.Bigrams.Size = new System.Drawing.Size(188, 165);
            this.Bigrams.TabIndex = 30;
            this.Bigrams.UseCompatibleStateImageBehavior = false;
            this.Bigrams.View = System.Windows.Forms.View.List;
            // 
            // comboTop10
            // 
            this.comboTop10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboTop10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboTop10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTop10.FormattingEnabled = true;
            this.comboTop10.Items.AddRange(new object[] {
            "Stemmed Text_Eng",
            "Stemmed Text_Pt"});
            this.comboTop10.Location = new System.Drawing.Point(693, 137);
            this.comboTop10.Name = "comboTop10";
            this.comboTop10.Size = new System.Drawing.Size(119, 24);
            this.comboTop10.TabIndex = 50;
            this.comboTop10.TabStop = false;
            this.comboTop10.SelectedIndexChanged += new System.EventHandler(this.comboTop10_SelectedIndexChanged);
            // 
            // comboNoStops
            // 
            this.comboNoStops.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboNoStops.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboNoStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNoStops.FormattingEnabled = true;
            this.comboNoStops.Items.AddRange(new object[] {
            "Stemmed Text_Eng",
            "Stemmed Text_Pt"});
            this.comboNoStops.Location = new System.Drawing.Point(693, 204);
            this.comboNoStops.Name = "comboNoStops";
            this.comboNoStops.Size = new System.Drawing.Size(120, 24);
            this.comboNoStops.TabIndex = 51;
            this.comboNoStops.TabStop = false;
            this.comboNoStops.SelectedIndexChanged += new System.EventHandler(this.comboNoStops_SelectedIndexChanged);
            // 
            // comboEmotion
            // 
            this.comboEmotion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboEmotion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboEmotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmotion.FormattingEnabled = true;
            this.comboEmotion.Items.AddRange(new object[] {
            "Analysis_Pt"});
            this.comboEmotion.Location = new System.Drawing.Point(693, 305);
            this.comboEmotion.Name = "comboEmotion";
            this.comboEmotion.Size = new System.Drawing.Size(120, 24);
            this.comboEmotion.TabIndex = 52;
            this.comboEmotion.TabStop = false;
            this.comboEmotion.SelectedIndexChanged += new System.EventHandler(this.comboEmotion_SelectedIndexChanged);
            // 
            // TabStats
            // 
            this.TabStats.BackColor = System.Drawing.Color.Teal;
            this.TabStats.Controls.Add(this.SaveXML);
            this.TabStats.Controls.Add(this.Button_StrongCorr);
            this.TabStats.Controls.Add(this.Button_Stats);
            this.TabStats.Controls.Add(this.dataCorrelations);
            this.TabStats.Controls.Add(this.data_All_Words);
            this.TabStats.Controls.Add(this.comboStats);
            this.TabStats.Location = new System.Drawing.Point(4, 25);
            this.TabStats.Name = "TabStats";
            this.TabStats.Padding = new System.Windows.Forms.Padding(3);
            this.TabStats.Size = new System.Drawing.Size(823, 524);
            this.TabStats.TabIndex = 1;
            this.TabStats.Text = "Statistical Analysis";
            // 
            // Button_StrongCorr
            // 
            this.Button_StrongCorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StrongCorr.Location = new System.Drawing.Point(418, 243);
            this.Button_StrongCorr.Name = "Button_StrongCorr";
            this.Button_StrongCorr.Size = new System.Drawing.Size(161, 30);
            this.Button_StrongCorr.TabIndex = 7;
            this.Button_StrongCorr.Text = "Strongest Correlations";
            this.Button_StrongCorr.UseVisualStyleBackColor = true;
            this.Button_StrongCorr.Click += new System.EventHandler(this.Button_StrongCorr_Click);
            // 
            // Button_Stats
            // 
            this.Button_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Stats.Location = new System.Drawing.Point(218, 244);
            this.Button_Stats.Name = "Button_Stats";
            this.Button_Stats.Size = new System.Drawing.Size(112, 30);
            this.Button_Stats.TabIndex = 5;
            this.Button_Stats.Text = "List Statistics";
            this.Button_Stats.UseVisualStyleBackColor = true;
            this.Button_Stats.Click += new System.EventHandler(this.Button_Stats_Click);
            // 
            // dataCorrelations
            // 
            this.dataCorrelations.AllowUserToAddRows = false;
            this.dataCorrelations.AllowUserToDeleteRows = false;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle66.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataCorrelations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle66;
            this.dataCorrelations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCorrelations.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle67.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle67.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCorrelations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle67;
            this.dataCorrelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle68.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCorrelations.DefaultCellStyle = dataGridViewCellStyle68;
            this.dataCorrelations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataCorrelations.Location = new System.Drawing.Point(3, 279);
            this.dataCorrelations.Name = "dataCorrelations";
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle69.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle69.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle69.NullValue = "null";
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCorrelations.RowHeadersDefaultCellStyle = dataGridViewCellStyle69;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle70.NullValue = "null";
            this.dataCorrelations.RowsDefaultCellStyle = dataGridViewCellStyle70;
            this.dataCorrelations.Size = new System.Drawing.Size(817, 242);
            this.dataCorrelations.TabIndex = 2;
            this.dataCorrelations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCorrelations_CellContentClick);
            // 
            // data_All_Words
            // 
            this.data_All_Words.AllowUserToAddRows = false;
            this.data_All_Words.AllowUserToDeleteRows = false;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.data_All_Words.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle71;
            this.data_All_Words.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_All_Words.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle72.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_All_Words.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle72;
            this.data_All_Words.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle73.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_All_Words.DefaultCellStyle = dataGridViewCellStyle73;
            this.data_All_Words.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_All_Words.GridColor = System.Drawing.Color.DarkGray;
            this.data_All_Words.Location = new System.Drawing.Point(3, 3);
            this.data_All_Words.Name = "data_All_Words";
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle74.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle74.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle74.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_All_Words.RowHeadersDefaultCellStyle = dataGridViewCellStyle74;
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_All_Words.RowsDefaultCellStyle = dataGridViewCellStyle75;
            this.data_All_Words.Size = new System.Drawing.Size(817, 237);
            this.data_All_Words.TabIndex = 0;
            this.data_All_Words.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_All_Words_CellContentClick);
            // 
            // comboStats
            // 
            this.comboStats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStats.FormattingEnabled = true;
            this.comboStats.Items.AddRange(new object[] {
            "List Statistics_Pt"});
            this.comboStats.Location = new System.Drawing.Point(218, 248);
            this.comboStats.Name = "comboStats";
            this.comboStats.Size = new System.Drawing.Size(130, 24);
            this.comboStats.TabIndex = 51;
            this.comboStats.TabStop = false;
            this.comboStats.SelectedIndexChanged += new System.EventHandler(this.comboStats_SelectedIndexChanged);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(831, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.InputTextBox);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text and Sentiment Analysis";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabText.ResumeLayout(false);
            this.TabText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataEmotions)).EndInit();
            this.TabStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCorrelations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_All_Words)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip InsiraTexto;
        public System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabText;
        private System.Windows.Forms.ComboBox comboEmotion;
        private System.Windows.Forms.ComboBox comboNoStops;
        private System.Windows.Forms.ComboBox comboTop10;
        private System.Windows.Forms.Button EmotionEngButton;
        private System.Windows.Forms.Button Top_10_NoStopsButton;
        private System.Windows.Forms.Button Top10_wordsButton;
        private System.Windows.Forms.Button List_StopwordsButton;
        private System.Windows.Forms.DataGridView DataEmotions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Stopwords;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView top_10_Stem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView Stem_NoStops;
        private System.Windows.Forms.ListView Top_10NoStops;
        private System.Windows.Forms.ListView Top_10Words;
        private System.Windows.Forms.ListView Trigrams;
        private System.Windows.Forms.ListView Bigrams;
        private System.Windows.Forms.TabPage TabStats;
        private System.Windows.Forms.Button Button_StrongCorr;
        private System.Windows.Forms.Button Button_Stats;
        private System.Windows.Forms.DataGridView dataCorrelations;
        private System.Windows.Forms.DataGridView data_All_Words;
        private System.Windows.Forms.Button SaveXML;
        private System.Windows.Forms.ComboBox comboStats;
    }
}