namespace CodeLab
{
    partial class Form13
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
            this.components = new System.ComponentModel.Container();
            this.head_menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.home_button = new System.Windows.Forms.Button();
            this.csrpbegback_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.head_menu.SuspendLayout();
            this.SuspendLayout();
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
            this.head_menu.Size = new System.Drawing.Size(284, 24);
            this.head_menu.TabIndex = 30;
            this.head_menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
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
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.FlatAppearance.BorderSize = 0;
            this.home_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.home_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.home_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.home_button.Image = global::CodeLab.Properties.Resources.homeicon;
            this.home_button.Location = new System.Drawing.Point(48, 27);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(40, 40);
            this.home_button.TabIndex = 32;
            this.toolTip1.SetToolTip(this.home_button, "Home");
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // csrpbegback_button
            // 
            this.csrpbegback_button.BackColor = System.Drawing.Color.Transparent;
            this.csrpbegback_button.FlatAppearance.BorderSize = 0;
            this.csrpbegback_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.csrpbegback_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.csrpbegback_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csrpbegback_button.Image = global::CodeLab.Properties.Resources.backiconbs;
            this.csrpbegback_button.Location = new System.Drawing.Point(0, 27);
            this.csrpbegback_button.Name = "csrpbegback_button";
            this.csrpbegback_button.Size = new System.Drawing.Size(42, 40);
            this.csrpbegback_button.TabIndex = 31;
            this.toolTip1.SetToolTip(this.csrpbegback_button, "Back");
            this.csrpbegback_button.UseVisualStyleBackColor = false;
            this.csrpbegback_button.Click += new System.EventHandler(this.csrpbegback_button_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeLab.Properties.Resources.Csrpbackground;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.csrpbegback_button);
            this.Controls.Add(this.head_menu);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# (sharp) Beginner level";
            this.head_menu.ResumeLayout(false);
            this.head_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button csrpbegback_button;
        private System.Windows.Forms.MenuStrip head_menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}