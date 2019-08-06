namespace CodeLab
{
    partial class homeForm
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
            this.home_c_click = new System.Windows.Forms.Button();
            this.home_cpp_click = new System.Windows.Forms.Button();
            this.home_csrp = new System.Windows.Forms.Button();
            this.head_menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homepictureBox = new System.Windows.Forms.PictureBox();
            this.head_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // home_c_click
            // 
            this.home_c_click.BackColor = System.Drawing.Color.Transparent;
            this.home_c_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_c_click.FlatAppearance.BorderSize = 0;
            this.home_c_click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_c_click.ForeColor = System.Drawing.Color.Transparent;
            this.home_c_click.Image = global::CodeLab.Properties.Resources.c;
            this.home_c_click.Location = new System.Drawing.Point(50, 181);
            this.home_c_click.Name = "home_c_click";
            this.home_c_click.Size = new System.Drawing.Size(108, 108);
            this.home_c_click.TabIndex = 0;
            this.home_c_click.UseVisualStyleBackColor = false;
            this.home_c_click.Click += new System.EventHandler(this.home_c_click_Click);
            // 
            // home_cpp_click
            // 
            this.home_cpp_click.BackColor = System.Drawing.Color.Transparent;
            this.home_cpp_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_cpp_click.FlatAppearance.BorderSize = 0;
            this.home_cpp_click.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_cpp_click.Image = global::CodeLab.Properties.Resources.cpp;
            this.home_cpp_click.Location = new System.Drawing.Point(193, 181);
            this.home_cpp_click.Name = "home_cpp_click";
            this.home_cpp_click.Size = new System.Drawing.Size(108, 108);
            this.home_cpp_click.TabIndex = 1;
            this.home_cpp_click.UseVisualStyleBackColor = false;
            this.home_cpp_click.Click += new System.EventHandler(this.home_cpp_click_Click);
            // 
            // home_csrp
            // 
            this.home_csrp.BackColor = System.Drawing.Color.Transparent;
            this.home_csrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_csrp.FlatAppearance.BorderSize = 0;
            this.home_csrp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_csrp.Image = global::CodeLab.Properties.Resources.csharp;
            this.home_csrp.Location = new System.Drawing.Point(336, 181);
            this.home_csrp.Name = "home_csrp";
            this.home_csrp.Size = new System.Drawing.Size(108, 108);
            this.home_csrp.TabIndex = 2;
            this.home_csrp.UseVisualStyleBackColor = false;
            this.home_csrp.Click += new System.EventHandler(this.home_csrp_click);
            // 
            // head_menu
            // 
            this.head_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.head_menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.head_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.head_menu.Location = new System.Drawing.Point(0, 0);
            this.head_menu.Name = "head_menu";
            this.head_menu.Size = new System.Drawing.Size(490, 24);
            this.head_menu.TabIndex = 3;
            this.head_menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // homepictureBox
            // 
            this.homepictureBox.BackColor = System.Drawing.Color.Transparent;
            this.homepictureBox.Image = global::CodeLab.Properties.Resources.selectLanguage2;
            this.homepictureBox.Location = new System.Drawing.Point(130, 84);
            this.homepictureBox.Name = "homepictureBox";
            this.homepictureBox.Size = new System.Drawing.Size(233, 46);
            this.homepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.homepictureBox.TabIndex = 4;
            this.homepictureBox.TabStop = false;
            this.homepictureBox.WaitOnLoad = true;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CodeLab.Properties.Resources.backgrnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 406);
            this.Controls.Add(this.head_menu);
            this.Controls.Add(this.homepictureBox);
            this.Controls.Add(this.home_csrp);
            this.Controls.Add(this.home_cpp_click);
            this.Controls.Add(this.home_c_click);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HelpButton = true;
            this.MainMenuStrip = this.head_menu;
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.head_menu.ResumeLayout(false);
            this.head_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_c_click;
        private System.Windows.Forms.Button home_cpp_click;
        private System.Windows.Forms.Button home_csrp;
        private System.Windows.Forms.MenuStrip head_menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox homepictureBox;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

