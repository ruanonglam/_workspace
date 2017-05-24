namespace i_tools
{
    partial class SecutrityScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SecurityPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SecurityPanel
            // 
            this.SecurityPanel.Location = new System.Drawing.Point(258, 45);
            this.SecurityPanel.Name = "SecurityPanel";
            this.SecurityPanel.Size = new System.Drawing.Size(525, 390);
            this.SecurityPanel.TabIndex = 1;
            // 
            // SecutrityScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BackgroundImage = global::i_tools.Properties.Resources.sub_content_security;
            this.Controls.Add(this.SecurityPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SecutrityScreen";
            this.Size = new System.Drawing.Size(804, 450);
            this.Load += new System.EventHandler(this.SecutrityScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SecurityPanel;
    }
}
