namespace Log4Net
{
    partial class Form1
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 44);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Info logs";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.Location = new System.Drawing.Point(12, 71);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(75, 40);
            this.btnWarning.TabIndex = 0;
            this.btnWarning.Text = "Warning logs";
            this.btnWarning.UseVisualStyleBackColor = true;
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(12, 132);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(75, 40);
            this.btnError.TabIndex = 0;
            this.btnError.Text = "Error logs";
            this.btnError.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 341);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btnError;
    }
}

