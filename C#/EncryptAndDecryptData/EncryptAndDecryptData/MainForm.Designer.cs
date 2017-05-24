namespace EncryptAndDecryptData
{
    partial class MainForm
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
            this.gpbEncryptFile = new System.Windows.Forms.GroupBox();
            this.btnFileOutput = new System.Windows.Forms.Button();
            this.txtFileOutput = new System.Windows.Forms.TextBox();
            this.btnFileInput = new System.Windows.Forms.Button();
            this.txtFileInput = new System.Windows.Forms.TextBox();
            this.btnEncryptData = new System.Windows.Forms.Button();
            this.btnDecryptData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKeyValue = new System.Windows.Forms.TextBox();
            this.btnExportKey = new System.Windows.Forms.Button();
            this.btnImportKey = new System.Windows.Forms.Button();
            this.btnDefaultKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFolderOutput = new System.Windows.Forms.Button();
            this.txtFolderOutput = new System.Windows.Forms.TextBox();
            this.btnFolderInput = new System.Windows.Forms.Button();
            this.txtFolderInput = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbEncryptFile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbEncryptFile
            // 
            this.gpbEncryptFile.Controls.Add(this.btnFileOutput);
            this.gpbEncryptFile.Controls.Add(this.txtFileOutput);
            this.gpbEncryptFile.Controls.Add(this.btnFileInput);
            this.gpbEncryptFile.Controls.Add(this.txtFileInput);
            this.gpbEncryptFile.Location = new System.Drawing.Point(12, 12);
            this.gpbEncryptFile.Name = "gpbEncryptFile";
            this.gpbEncryptFile.Size = new System.Drawing.Size(485, 94);
            this.gpbEncryptFile.TabIndex = 0;
            this.gpbEncryptFile.TabStop = false;
            this.gpbEncryptFile.Text = "File";
            // 
            // btnFileOutput
            // 
            this.btnFileOutput.Location = new System.Drawing.Point(402, 56);
            this.btnFileOutput.Name = "btnFileOutput";
            this.btnFileOutput.Size = new System.Drawing.Size(75, 23);
            this.btnFileOutput.TabIndex = 1;
            this.btnFileOutput.Text = "Output...";
            this.btnFileOutput.UseVisualStyleBackColor = true;
            this.btnFileOutput.Click += new System.EventHandler(this.btnFileOutput_Click);
            // 
            // txtFileOutput
            // 
            this.txtFileOutput.Location = new System.Drawing.Point(6, 58);
            this.txtFileOutput.Name = "txtFileOutput";
            this.txtFileOutput.ReadOnly = true;
            this.txtFileOutput.Size = new System.Drawing.Size(390, 20);
            this.txtFileOutput.TabIndex = 0;
            // 
            // btnFileInput
            // 
            this.btnFileInput.Location = new System.Drawing.Point(402, 17);
            this.btnFileInput.Name = "btnFileInput";
            this.btnFileInput.Size = new System.Drawing.Size(75, 23);
            this.btnFileInput.TabIndex = 1;
            this.btnFileInput.Text = "Input...";
            this.btnFileInput.UseVisualStyleBackColor = true;
            this.btnFileInput.Click += new System.EventHandler(this.btnFileInput_Click);
            // 
            // txtFileInput
            // 
            this.txtFileInput.Location = new System.Drawing.Point(6, 19);
            this.txtFileInput.Name = "txtFileInput";
            this.txtFileInput.ReadOnly = true;
            this.txtFileInput.Size = new System.Drawing.Size(390, 20);
            this.txtFileInput.TabIndex = 0;
            // 
            // btnEncryptData
            // 
            this.btnEncryptData.Location = new System.Drawing.Point(420, 345);
            this.btnEncryptData.Name = "btnEncryptData";
            this.btnEncryptData.Size = new System.Drawing.Size(75, 34);
            this.btnEncryptData.TabIndex = 1;
            this.btnEncryptData.Text = "Encrypt";
            this.btnEncryptData.UseVisualStyleBackColor = true;
            this.btnEncryptData.Click += new System.EventHandler(this.btnEncryptData_Click);
            // 
            // btnDecryptData
            // 
            this.btnDecryptData.Location = new System.Drawing.Point(339, 345);
            this.btnDecryptData.Name = "btnDecryptData";
            this.btnDecryptData.Size = new System.Drawing.Size(75, 34);
            this.btnDecryptData.TabIndex = 1;
            this.btnDecryptData.Text = "Decrypt";
            this.btnDecryptData.UseVisualStyleBackColor = true;
            this.btnDecryptData.Click += new System.EventHandler(this.btnDecryptData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKeyValue);
            this.groupBox2.Controls.Add(this.btnExportKey);
            this.groupBox2.Controls.Add(this.btnImportKey);
            this.groupBox2.Controls.Add(this.btnDefaultKey);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // txtKeyValue
            // 
            this.txtKeyValue.Location = new System.Drawing.Point(6, 19);
            this.txtKeyValue.Multiline = true;
            this.txtKeyValue.Name = "txtKeyValue";
            this.txtKeyValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyValue.Size = new System.Drawing.Size(471, 58);
            this.txtKeyValue.TabIndex = 0;
            // 
            // btnExportKey
            // 
            this.btnExportKey.Location = new System.Drawing.Point(247, 83);
            this.btnExportKey.Name = "btnExportKey";
            this.btnExportKey.Size = new System.Drawing.Size(112, 34);
            this.btnExportKey.TabIndex = 1;
            this.btnExportKey.Text = "Export to file...";
            this.btnExportKey.UseVisualStyleBackColor = true;
            this.btnExportKey.Click += new System.EventHandler(this.btnExportKey_Click);
            // 
            // btnImportKey
            // 
            this.btnImportKey.Location = new System.Drawing.Point(365, 83);
            this.btnImportKey.Name = "btnImportKey";
            this.btnImportKey.Size = new System.Drawing.Size(112, 34);
            this.btnImportKey.TabIndex = 1;
            this.btnImportKey.Text = "Import from file...";
            this.btnImportKey.UseVisualStyleBackColor = true;
            this.btnImportKey.Click += new System.EventHandler(this.btnImportKey_Click);
            // 
            // btnDefaultKey
            // 
            this.btnDefaultKey.Location = new System.Drawing.Point(6, 83);
            this.btnDefaultKey.Name = "btnDefaultKey";
            this.btnDefaultKey.Size = new System.Drawing.Size(131, 34);
            this.btnDefaultKey.TabIndex = 1;
            this.btnDefaultKey.Text = "AFTECH Software";
            this.btnDefaultKey.UseVisualStyleBackColor = true;
            this.btnDefaultKey.Click += new System.EventHandler(this.btnDefaultKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFolderOutput);
            this.groupBox1.Controls.Add(this.txtFolderOutput);
            this.groupBox1.Controls.Add(this.btnFolderInput);
            this.groupBox1.Controls.Add(this.txtFolderInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder";
            // 
            // btnFolderOutput
            // 
            this.btnFolderOutput.Location = new System.Drawing.Point(402, 56);
            this.btnFolderOutput.Name = "btnFolderOutput";
            this.btnFolderOutput.Size = new System.Drawing.Size(75, 23);
            this.btnFolderOutput.TabIndex = 1;
            this.btnFolderOutput.Text = "Output...";
            this.btnFolderOutput.UseVisualStyleBackColor = true;
            this.btnFolderOutput.Click += new System.EventHandler(this.btnFolderOutput_Click);
            // 
            // txtFolderOutput
            // 
            this.txtFolderOutput.Location = new System.Drawing.Point(6, 58);
            this.txtFolderOutput.Name = "txtFolderOutput";
            this.txtFolderOutput.ReadOnly = true;
            this.txtFolderOutput.Size = new System.Drawing.Size(390, 20);
            this.txtFolderOutput.TabIndex = 0;
            // 
            // btnFolderInput
            // 
            this.btnFolderInput.Location = new System.Drawing.Point(402, 17);
            this.btnFolderInput.Name = "btnFolderInput";
            this.btnFolderInput.Size = new System.Drawing.Size(75, 23);
            this.btnFolderInput.TabIndex = 1;
            this.btnFolderInput.Text = "Input...";
            this.btnFolderInput.UseVisualStyleBackColor = true;
            this.btnFolderInput.Click += new System.EventHandler(this.btnFolderInput_Click);
            // 
            // txtFolderInput
            // 
            this.txtFolderInput.Location = new System.Drawing.Point(6, 19);
            this.txtFolderInput.Name = "txtFolderInput";
            this.txtFolderInput.ReadOnly = true;
            this.txtFolderInput.Size = new System.Drawing.Size(390, 20);
            this.txtFolderInput.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(507, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(39, 17);
            this.lbStatus.Text = "Ready";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 346);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDecryptData);
            this.Controls.Add(this.btnEncryptData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbEncryptFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt & Decrypt Data";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gpbEncryptFile.ResumeLayout(false);
            this.gpbEncryptFile.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEncryptFile;
        private System.Windows.Forms.Button btnEncryptData;
        private System.Windows.Forms.Button btnDecryptData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFileInput;
        private System.Windows.Forms.TextBox txtFileInput;
        private System.Windows.Forms.TextBox txtKeyValue;
        private System.Windows.Forms.Button btnFileOutput;
        private System.Windows.Forms.TextBox txtFileOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFolderOutput;
        private System.Windows.Forms.TextBox txtFolderOutput;
        private System.Windows.Forms.Button btnFolderInput;
        private System.Windows.Forms.TextBox txtFolderInput;
        private System.Windows.Forms.Button btnImportKey;
        private System.Windows.Forms.Button btnDefaultKey;
        private System.Windows.Forms.Button btnExportKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
    }
}

