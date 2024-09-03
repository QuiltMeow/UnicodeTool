namespace UnicodeGenerator
{
    partial class ZalgoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZalgoForm));
            labelInput = new Label();
            txtInput = new TextBox();
            labelZalgoUp = new Label();
            numZalgoUp = new NumericUpDown();
            labelZalgoMedium = new Label();
            numZalgoMedium = new NumericUpDown();
            labelZalgoDown = new Label();
            numZalgoDown = new NumericUpDown();
            btnGenerate = new Button();
            labelResult = new Label();
            txtResult = new TextBox();
            btnCopyResult = new Button();
            ((System.ComponentModel.ISupportInitialize)numZalgoUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZalgoMedium).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZalgoDown).BeginInit();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(15, 15);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(55, 15);
            labelInput.TabIndex = 0;
            labelInput.Text = "輸入文字";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(25, 40);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(745, 125);
            txtInput.TabIndex = 1;
            // 
            // labelZalgoUp
            // 
            labelZalgoUp.AutoSize = true;
            labelZalgoUp.Location = new Point(15, 185);
            labelZalgoUp.Name = "labelZalgoUp";
            labelZalgoUp.Size = new Size(103, 15);
            labelZalgoUp.TabIndex = 2;
            labelZalgoUp.Text = "上方最大文字數量";
            // 
            // numZalgoUp
            // 
            numZalgoUp.Location = new Point(124, 183);
            numZalgoUp.Name = "numZalgoUp";
            numZalgoUp.Size = new Size(120, 23);
            numZalgoUp.TabIndex = 3;
            numZalgoUp.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelZalgoMedium
            // 
            labelZalgoMedium.AutoSize = true;
            labelZalgoMedium.Location = new Point(280, 185);
            labelZalgoMedium.Name = "labelZalgoMedium";
            labelZalgoMedium.Size = new Size(103, 15);
            labelZalgoMedium.TabIndex = 4;
            labelZalgoMedium.Text = "中間最大文字數量";
            // 
            // numZalgoMedium
            // 
            numZalgoMedium.Location = new Point(389, 183);
            numZalgoMedium.Name = "numZalgoMedium";
            numZalgoMedium.Size = new Size(120, 23);
            numZalgoMedium.TabIndex = 5;
            numZalgoMedium.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelZalgoDown
            // 
            labelZalgoDown.AutoSize = true;
            labelZalgoDown.Location = new Point(541, 185);
            labelZalgoDown.Name = "labelZalgoDown";
            labelZalgoDown.Size = new Size(103, 15);
            labelZalgoDown.TabIndex = 6;
            labelZalgoDown.Text = "下方最大文字數量";
            // 
            // numZalgoDown
            // 
            numZalgoDown.Location = new Point(650, 183);
            numZalgoDown.Name = "numZalgoDown";
            numZalgoDown.Size = new Size(120, 23);
            numZalgoDown.TabIndex = 7;
            numZalgoDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(15, 220);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(755, 23);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "產生 Zalgo 文字";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(15, 265);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(55, 15);
            labelResult.TabIndex = 9;
            labelResult.Text = "輸出結果";
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.Window;
            txtResult.Location = new Point(25, 295);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(745, 125);
            txtResult.TabIndex = 11;
            // 
            // btnCopyResult
            // 
            btnCopyResult.Location = new Point(695, 261);
            btnCopyResult.Name = "btnCopyResult";
            btnCopyResult.Size = new Size(75, 23);
            btnCopyResult.TabIndex = 10;
            btnCopyResult.Text = "複製結果";
            btnCopyResult.UseVisualStyleBackColor = true;
            btnCopyResult.Click += btnCopyResult_Click;
            // 
            // ZalgoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 441);
            Controls.Add(btnCopyResult);
            Controls.Add(txtResult);
            Controls.Add(labelResult);
            Controls.Add(btnGenerate);
            Controls.Add(numZalgoDown);
            Controls.Add(labelZalgoDown);
            Controls.Add(numZalgoMedium);
            Controls.Add(labelZalgoMedium);
            Controls.Add(numZalgoUp);
            Controls.Add(labelZalgoUp);
            Controls.Add(txtInput);
            Controls.Add(labelInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "ZalgoForm";
            Text = "Zalgo 工具";
            ((System.ComponentModel.ISupportInitialize)numZalgoUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZalgoMedium).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZalgoDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInput;
        private TextBox txtInput;
        private Label labelZalgoUp;
        private NumericUpDown numZalgoUp;
        private Label labelZalgoMedium;
        private NumericUpDown numZalgoMedium;
        private Label labelZalgoDown;
        private NumericUpDown numZalgoDown;
        private Button btnGenerate;
        private Label labelResult;
        private TextBox txtResult;
        private Button btnCopyResult;
    }
}