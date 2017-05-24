namespace i_tools
{
    partial class HomeScreen
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
            this.btnFavorite = new System.Windows.Forms.PictureBox();
            this.btnSecurity = new System.Windows.Forms.PictureBox();
            this.btnInternet = new System.Windows.Forms.PictureBox();
            this.btnFilenFolder = new System.Windows.Forms.PictureBox();
            this.btnITool = new System.Windows.Forms.PictureBox();
            this.btnWorkFJN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInternet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilenFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnITool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWorkFJN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFavorite
            // 
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.Image = global::i_tools.Properties.Resources.main_form_menu_item_favorite;
            this.btnFavorite.Location = new System.Drawing.Point(434, 334);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(210, 61);
            this.btnFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnFavorite.TabIndex = 11;
            this.btnFavorite.TabStop = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnSecurity
            // 
            this.btnSecurity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecurity.Image = global::i_tools.Properties.Resources.main_form_menu_item_security;
            this.btnSecurity.Location = new System.Drawing.Point(160, 334);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(210, 61);
            this.btnSecurity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSecurity.TabIndex = 12;
            this.btnSecurity.TabStop = false;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInternet.Image = global::i_tools.Properties.Resources.main_form_menu_item_internet;
            this.btnInternet.Location = new System.Drawing.Point(434, 203);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(210, 61);
            this.btnInternet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnInternet.TabIndex = 13;
            this.btnInternet.TabStop = false;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnFilenFolder
            // 
            this.btnFilenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilenFolder.Image = global::i_tools.Properties.Resources.main_form_menu_item_filefolder;
            this.btnFilenFolder.Location = new System.Drawing.Point(160, 203);
            this.btnFilenFolder.Name = "btnFilenFolder";
            this.btnFilenFolder.Size = new System.Drawing.Size(210, 61);
            this.btnFilenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnFilenFolder.TabIndex = 8;
            this.btnFilenFolder.TabStop = false;
            this.btnFilenFolder.Click += new System.EventHandler(this.btnFilenFolder_Click);
            // 
            // btnITool
            // 
            this.btnITool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnITool.Image = global::i_tools.Properties.Resources.main_form_menu_item_itool;
            this.btnITool.Location = new System.Drawing.Point(434, 72);
            this.btnITool.Name = "btnITool";
            this.btnITool.Size = new System.Drawing.Size(210, 61);
            this.btnITool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnITool.TabIndex = 9;
            this.btnITool.TabStop = false;
            this.btnITool.Click += new System.EventHandler(this.btnITool_Click);
            // 
            // btnWorkFJN
            // 
            this.btnWorkFJN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkFJN.Image = global::i_tools.Properties.Resources.main_form_menu_item_work;
            this.btnWorkFJN.Location = new System.Drawing.Point(160, 72);
            this.btnWorkFJN.Name = "btnWorkFJN";
            this.btnWorkFJN.Size = new System.Drawing.Size(210, 61);
            this.btnWorkFJN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnWorkFJN.TabIndex = 10;
            this.btnWorkFJN.TabStop = false;
            this.btnWorkFJN.Click += new System.EventHandler(this.btnWorkFJN_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BackgroundImage = global::i_tools.Properties.Resources.sub_content_home;
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.btnInternet);
            this.Controls.Add(this.btnFilenFolder);
            this.Controls.Add(this.btnITool);
            this.Controls.Add(this.btnWorkFJN);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(804, 450);
            this.Load += new System.EventHandler(this.HomePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInternet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilenFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnITool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWorkFJN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnFavorite;
        private System.Windows.Forms.PictureBox btnSecurity;
        private System.Windows.Forms.PictureBox btnInternet;
        private System.Windows.Forms.PictureBox btnFilenFolder;
        private System.Windows.Forms.PictureBox btnITool;
        private System.Windows.Forms.PictureBox btnWorkFJN;

    }
}
