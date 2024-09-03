namespace UnicodeGenerator
{
    partial class UnicodeBlockViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnicodeBlockViewerForm));
            labelSearch = new Label();
            rbSearch = new RadioButton();
            txtSearch = new TextBox();
            btnSearch = new Button();
            rbBlockView = new RadioButton();
            cbUnicodeBlock = new ComboBox();
            lvResult = new ListView();
            lvDetail = new ListView();
            chItem = new ColumnHeader();
            chData = new ColumnHeader();
            chkRemoveCharacterWithoutDisplayWidth = new CheckBox();
            labelResult = new Label();
            labelDetail = new Label();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(25, 45);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(55, 15);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "輸入文字";
            // 
            // rbSearch
            // 
            rbSearch.AutoSize = true;
            rbSearch.Checked = true;
            rbSearch.Location = new Point(15, 15);
            rbSearch.Name = "rbSearch";
            rbSearch.Size = new Size(73, 19);
            rbSearch.TabIndex = 0;
            rbSearch.TabStop = true;
            rbSearch.Text = "搜尋字碼";
            rbSearch.UseVisualStyleBackColor = true;
            rbSearch.CheckedChanged += rbSearch_CheckedChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(86, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(342, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "查詢";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // rbBlockView
            // 
            rbBlockView.AutoSize = true;
            rbBlockView.Location = new Point(15, 110);
            rbBlockView.Name = "rbBlockView";
            rbBlockView.Size = new Size(73, 19);
            rbBlockView.TabIndex = 5;
            rbBlockView.TabStop = true;
            rbBlockView.Text = "區塊檢視";
            rbBlockView.UseVisualStyleBackColor = true;
            rbBlockView.CheckedChanged += rbBlockView_CheckedChanged;
            // 
            // cbUnicodeBlock
            // 
            cbUnicodeBlock.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnicodeBlock.Enabled = false;
            cbUnicodeBlock.FormattingEnabled = true;
            cbUnicodeBlock.Location = new Point(25, 140);
            cbUnicodeBlock.Name = "cbUnicodeBlock";
            cbUnicodeBlock.Size = new Size(720, 23);
            cbUnicodeBlock.TabIndex = 6;
            cbUnicodeBlock.SelectedIndexChanged += cbUnicodeBlock_SelectedIndexChanged;
            // 
            // lvResult
            // 
            lvResult.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lvResult.Location = new Point(25, 220);
            lvResult.MultiSelect = false;
            lvResult.Name = "lvResult";
            lvResult.Size = new Size(400, 280);
            lvResult.TabIndex = 8;
            lvResult.UseCompatibleStateImageBehavior = false;
            lvResult.SelectedIndexChanged += lvResult_SelectedIndexChanged;
            lvResult.MouseDoubleClick += lvResult_MouseDoubleClick;
            // 
            // lvDetail
            // 
            lvDetail.Columns.AddRange(new ColumnHeader[] { chItem, chData });
            lvDetail.Location = new Point(445, 220);
            lvDetail.Name = "lvDetail";
            lvDetail.Size = new Size(300, 280);
            lvDetail.TabIndex = 10;
            lvDetail.UseCompatibleStateImageBehavior = false;
            lvDetail.View = View.Details;
            // 
            // chItem
            // 
            chItem.Text = "項目";
            chItem.Width = 160;
            // 
            // chData
            // 
            chData.Text = "資料";
            chData.Width = 120;
            // 
            // chkRemoveCharacterWithoutDisplayWidth
            // 
            chkRemoveCharacterWithoutDisplayWidth.AutoSize = true;
            chkRemoveCharacterWithoutDisplayWidth.Location = new Point(25, 75);
            chkRemoveCharacterWithoutDisplayWidth.Name = "chkRemoveCharacterWithoutDisplayWidth";
            chkRemoveCharacterWithoutDisplayWidth.Size = new Size(254, 19);
            chkRemoveCharacterWithoutDisplayWidth.TabIndex = 4;
            chkRemoveCharacterWithoutDisplayWidth.Text = "移除零寬連字、不連字符號（例如：ZWJ）";
            chkRemoveCharacterWithoutDisplayWidth.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(15, 195);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(55, 15);
            labelResult.TabIndex = 7;
            labelResult.Text = "查詢結果";
            // 
            // labelDetail
            // 
            labelDetail.AutoSize = true;
            labelDetail.Location = new Point(435, 195);
            labelDetail.Name = "labelDetail";
            labelDetail.Size = new Size(55, 15);
            labelDetail.TabIndex = 9;
            labelDetail.Text = "詳細資料";
            // 
            // UnicodeBlockViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 516);
            Controls.Add(labelDetail);
            Controls.Add(labelResult);
            Controls.Add(chkRemoveCharacterWithoutDisplayWidth);
            Controls.Add(lvDetail);
            Controls.Add(lvResult);
            Controls.Add(cbUnicodeBlock);
            Controls.Add(rbBlockView);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(rbSearch);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "UnicodeBlockViewerForm";
            Text = "Unicode 區段檢視器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private RadioButton rbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private RadioButton rbBlockView;
        private ComboBox cbUnicodeBlock;
        private ListView lvResult;
        private ListView lvDetail;
        private ColumnHeader chItem;
        private ColumnHeader chData;
        private CheckBox chkRemoveCharacterWithoutDisplayWidth;
        private Label labelResult;
        private Label labelDetail;
    }
}