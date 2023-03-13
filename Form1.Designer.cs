namespace Password_Generator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numGenerate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hasSymbols = new System.Windows.Forms.CheckBox();
            this.hasNums = new System.Windows.Forms.CheckBox();
            this.isUppercase = new System.Windows.Forms.CheckBox();
            this.psLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numGenerate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hasSymbols);
            this.groupBox1.Controls.Add(this.hasNums);
            this.groupBox1.Controls.Add(this.isUppercase);
            this.groupBox1.Controls.Add(this.psLength);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(29, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Requirements";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numGenerate
            // 
            this.numGenerate.Location = new System.Drawing.Point(14, 143);
            this.numGenerate.Name = "numGenerate";
            this.numGenerate.Size = new System.Drawing.Size(172, 31);
            this.numGenerate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount to Generate:";
            // 
            // hasSymbols
            // 
            this.hasSymbols.AutoSize = true;
            this.hasSymbols.Location = new System.Drawing.Point(13, 261);
            this.hasSymbols.Name = "hasSymbols";
            this.hasSymbols.Size = new System.Drawing.Size(106, 29);
            this.hasSymbols.TabIndex = 5;
            this.hasSymbols.Text = "Symbols";
            this.hasSymbols.UseVisualStyleBackColor = true;
            this.hasSymbols.CheckedChanged += new System.EventHandler(this.hasSymbols_CheckedChanged);
            // 
            // hasNums
            // 
            this.hasNums.AutoSize = true;
            this.hasNums.Location = new System.Drawing.Point(13, 232);
            this.hasNums.Name = "hasNums";
            this.hasNums.Size = new System.Drawing.Size(111, 29);
            this.hasNums.TabIndex = 4;
            this.hasNums.Text = "Numbers";
            this.hasNums.UseVisualStyleBackColor = true;
            this.hasNums.CheckedChanged += new System.EventHandler(this.hasNums_CheckedChanged);
            // 
            // isUppercase
            // 
            this.isUppercase.AutoSize = true;
            this.isUppercase.Location = new System.Drawing.Point(13, 203);
            this.isUppercase.Name = "isUppercase";
            this.isUppercase.Size = new System.Drawing.Size(178, 29);
            this.isUppercase.TabIndex = 3;
            this.isUppercase.Text = "Uppercase Letters";
            this.isUppercase.UseVisualStyleBackColor = true;
            this.isUppercase.CheckedChanged += new System.EventHandler(this.isUppercase_CheckedChanged);
            // 
            // psLength
            // 
            this.psLength.Location = new System.Drawing.Point(14, 67);
            this.psLength.Name = "psLength";
            this.psLength.Size = new System.Drawing.Size(172, 31);
            this.psLength.TabIndex = 2;
            this.psLength.TextChanged += new System.EventHandler(this.psLength_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length of Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Location = new System.Drawing.Point(327, 44);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(370, 226);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(327, 280);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(159, 56);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExport.Location = new System.Drawing.Point(518, 280);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(159, 56);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox isUppercase;
        private TextBox psLength;
        private TextBox numGenerate;
        private Label label2;
        private CheckBox hasSymbols;
        private CheckBox hasNums;
        private RichTextBox outputBox;
        private Label label3;
        private Button btnGenerate;
        private Button btnExport;
    }
}