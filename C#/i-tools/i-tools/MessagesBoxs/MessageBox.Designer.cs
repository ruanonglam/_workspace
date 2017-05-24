namespace i_tools
{
    partial class MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBox));
            this.MessageBoxForm = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Label();
            this.MessageBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageBoxForm
            // 
            this.MessageBoxForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.MessageBoxForm.BackgroundImage = global::i_tools.Properties.Resources.error_messagebox;
            this.MessageBoxForm.Controls.Add(this.btnOK);
            this.MessageBoxForm.Location = new System.Drawing.Point(0, 0);
            this.MessageBoxForm.Name = "MessageBoxForm";
            this.MessageBoxForm.Size = new System.Drawing.Size(416, 175);
            this.MessageBoxForm.TabIndex = 0;
            this.MessageBoxForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MessageBoxForm_MouseMove);
            this.MessageBoxForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MessageBoxForm_MouseDown);
            this.MessageBoxForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MessageBoxForm_MouseUp);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btnOK.Location = new System.Drawing.Point(323, 133);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnOK.Size = new System.Drawing.Size(77, 22);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Uhm";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 175);
            this.Controls.Add(this.MessageBoxForm);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.MessageBox_Load);
            this.MessageBoxForm.ResumeLayout(false);
            this.MessageBoxForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MessageBoxForm;
        private System.Windows.Forms.Label btnOK;
    }
}