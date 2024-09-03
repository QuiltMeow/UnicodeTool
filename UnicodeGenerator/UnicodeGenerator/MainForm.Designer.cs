namespace UnicodeGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtResult = new TextBox();
            lvUnicodeBlock = new ListView();
            chBlockRange = new ColumnHeader();
            chBlockName = new ColumnHeader();
            labelLength = new Label();
            numLength = new NumericUpDown();
            btnCancelAll = new Button();
            btnGenerate = new Button();
            labelTitle = new Label();
            btnCheckAll = new Button();
            btnReverseCheck = new Button();
            labelResult = new Label();
            msToolBar = new MenuStrip();
            tsmiTool = new ToolStripMenuItem();
            tsmiUnicodeBlockViewer = new ToolStripMenuItem();
            tsmiZalgoTool = new ToolStripMenuItem();
            btnCopyResult = new Button();
            ((System.ComponentModel.ISupportInitialize)numLength).BeginInit();
            msToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.Window;
            txtResult.Location = new Point(500, 95);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(400, 250);
            txtResult.TabIndex = 7;
            // 
            // lvUnicodeBlock
            // 
            lvUnicodeBlock.CheckBoxes = true;
            lvUnicodeBlock.Columns.AddRange(new ColumnHeader[] { chBlockRange, chBlockName });
            lvUnicodeBlock.Location = new Point(15, 70);
            lvUnicodeBlock.Name = "lvUnicodeBlock";
            lvUnicodeBlock.Size = new Size(465, 275);
            lvUnicodeBlock.TabIndex = 2;
            lvUnicodeBlock.UseCompatibleStateImageBehavior = false;
            lvUnicodeBlock.View = View.Details;
            // 
            // chBlockRange
            // 
            chBlockRange.Text = "範圍";
            chBlockRange.Width = 160;
            // 
            // chBlockName
            // 
            chBlockName.Text = "名稱";
            chBlockName.Width = 280;
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(500, 359);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(31, 15);
            labelLength.TabIndex = 8;
            labelLength.Text = "長度";
            // 
            // numLength
            // 
            numLength.Location = new Point(540, 357);
            numLength.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLength.Name = "numLength";
            numLength.Size = new Size(120, 23);
            numLength.TabIndex = 9;
            numLength.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // btnCancelAll
            // 
            btnCancelAll.Location = new Point(210, 355);
            btnCancelAll.Name = "btnCancelAll";
            btnCancelAll.Size = new Size(75, 23);
            btnCancelAll.TabIndex = 4;
            btnCancelAll.Text = "全部取消";
            btnCancelAll.UseVisualStyleBackColor = true;
            btnCancelAll.Click += btnCancelAll_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(670, 355);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 10;
            btnGenerate.Text = "產生";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelTitle.Location = new Point(15, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(172, 20);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Unicode 文字產生工具";
            // 
            // btnCheckAll
            // 
            btnCheckAll.Location = new Point(15, 355);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(75, 23);
            btnCheckAll.TabIndex = 3;
            btnCheckAll.Text = "全部選取";
            btnCheckAll.UseVisualStyleBackColor = true;
            btnCheckAll.Click += btnCheckAll_Click;
            // 
            // btnReverseCheck
            // 
            btnReverseCheck.Location = new Point(405, 355);
            btnReverseCheck.Name = "btnReverseCheck";
            btnReverseCheck.Size = new Size(75, 23);
            btnReverseCheck.TabIndex = 5;
            btnReverseCheck.Text = "反向選取";
            btnReverseCheck.UseVisualStyleBackColor = true;
            btnReverseCheck.Click += btnReverseCheck_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(500, 70);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(43, 15);
            labelResult.TabIndex = 6;
            labelResult.Text = "結果：";
            // 
            // msToolBar
            // 
            msToolBar.Items.AddRange(new ToolStripItem[] { tsmiTool });
            msToolBar.Location = new Point(0, 0);
            msToolBar.Name = "msToolBar";
            msToolBar.Size = new Size(919, 24);
            msToolBar.TabIndex = 0;
            msToolBar.Text = "menuStrip1";
            // 
            // tsmiTool
            // 
            tsmiTool.DropDownItems.AddRange(new ToolStripItem[] { tsmiUnicodeBlockViewer, tsmiZalgoTool });
            tsmiTool.Name = "tsmiTool";
            tsmiTool.Size = new Size(43, 20);
            tsmiTool.Text = "工具";
            // 
            // tsmiUnicodeBlockViewer
            // 
            tsmiUnicodeBlockViewer.Name = "tsmiUnicodeBlockViewer";
            tsmiUnicodeBlockViewer.Size = new Size(146, 22);
            tsmiUnicodeBlockViewer.Text = "字碼檢視工具";
            tsmiUnicodeBlockViewer.Click += tsmiUnicodeBlockViewer_Click;
            // 
            // tsmiZalgoTool
            // 
            tsmiZalgoTool.Name = "tsmiZalgoTool";
            tsmiZalgoTool.Size = new Size(146, 22);
            tsmiZalgoTool.Text = "Zalgo 工具";
            tsmiZalgoTool.Click += tsmiZalgoTool_Click;
            // 
            // btnCopyResult
            // 
            btnCopyResult.Location = new Point(825, 355);
            btnCopyResult.Name = "btnCopyResult";
            btnCopyResult.Size = new Size(75, 23);
            btnCopyResult.TabIndex = 11;
            btnCopyResult.Text = "複製結果";
            btnCopyResult.UseVisualStyleBackColor = true;
            btnCopyResult.Click += btnCopyResult_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 396);
            Controls.Add(btnCopyResult);
            Controls.Add(labelResult);
            Controls.Add(btnReverseCheck);
            Controls.Add(btnCheckAll);
            Controls.Add(labelTitle);
            Controls.Add(btnGenerate);
            Controls.Add(btnCancelAll);
            Controls.Add(numLength);
            Controls.Add(labelLength);
            Controls.Add(lvUnicodeBlock);
            Controls.Add(txtResult);
            Controls.Add(msToolBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MainMenuStrip = msToolBar;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Unicode 文字產生工具";
            ((System.ComponentModel.ISupportInitialize)numLength).EndInit();
            msToolBar.ResumeLayout(false);
            msToolBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private ListView lvUnicodeBlock;
        private ColumnHeader chBlockRange;
        private ColumnHeader chBlockName;
        private Label labelLength;
        private NumericUpDown numLength;
        private Button btnCancelAll;
        private Button btnGenerate;
        private Label labelTitle;
        private Button btnCheckAll;
        private Button btnReverseCheck;
        private Label labelResult;
        private MenuStrip msToolBar;
        private ToolStripMenuItem tsmiTool;
        private ToolStripMenuItem tsmiUnicodeBlockViewer;
        private Button btnCopyResult;
        private ToolStripMenuItem tsmiZalgoTool;
    }
}
