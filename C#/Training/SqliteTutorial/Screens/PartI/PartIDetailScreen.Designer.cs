namespace SqliteTutorial.Screens.PartI
{
    partial class PartIDetailScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartIDetailScreen));
            this.PartIMainMainPanel = new System.Windows.Forms.Panel();
            this.detail_view = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pages = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PartIMainMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_view)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PartIMainMainPanel
            // 
            this.PartIMainMainPanel.Controls.Add(this.detail_view);
            this.PartIMainMainPanel.Controls.Add(this.panel2);
            this.PartIMainMainPanel.Location = new System.Drawing.Point(15, 59);
            this.PartIMainMainPanel.Name = "PartIMainMainPanel";
            this.PartIMainMainPanel.Size = new System.Drawing.Size(495, 370);
            this.PartIMainMainPanel.TabIndex = 6;
            // 
            // detail_view
            // 
            this.detail_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detail_view.Image = ((System.Drawing.Image)(resources.GetObject("detail_view.Image")));
            this.detail_view.Location = new System.Drawing.Point(3, 3);
            this.detail_view.Name = "detail_view";
            this.detail_view.Size = new System.Drawing.Size(489, 309);
            this.detail_view.TabIndex = 1;
            this.detail_view.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pages);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 49);
            this.panel2.TabIndex = 0;
            // 
            // pages
            // 
            this.pages.AutoSize = true;
            this.pages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pages.Location = new System.Drawing.Point(230, 15);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(29, 19);
            this.pages.TabIndex = 1;
            this.pages.Text = "0/0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::SqliteTutorial.Properties.Resources.view_back;
            this.pictureBox3.Location = new System.Drawing.Point(193, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SqliteTutorial.Properties.Resources.view_next;
            this.pictureBox2.Location = new System.Drawing.Point(264, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Content";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(57, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 33);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SqliteTutorial.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PartIDetailScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PartIMainMainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PartIDetailScreen";
            this.Size = new System.Drawing.Size(524, 444);
            this.Load += new System.EventHandler(this.PartIDetailScreen_Load);
            this.PartIMainMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detail_view)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PartIMainMainPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox detail_view;
        private System.Windows.Forms.Label pages;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}
