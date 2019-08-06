namespace CodeLab
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbeginner_button = new System.Windows.Forms.Button();
            this.cintermediate_button = new System.Windows.Forms.Button();
            this.cadvance_button = new System.Windows.Forms.Button();
            this.cback_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.clearnmore_button = new System.Windows.Forms.Button();
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
            this.head_menu.Size = new System.Drawing.Size(520, 24);
            this.head_menu.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(70, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select level";
            // 
            // cbeginner_button
            // 
            this.cbeginner_button.AllowDrop = true;
            this.cbeginner_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cbeginner_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbeginner_button.FlatAppearance.BorderSize = 0;
            this.cbeginner_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cbeginner_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbeginner_button.Location = new System.Drawing.Point(74, 158);
            this.cbeginner_button.Name = "cbeginner_button";
            this.cbeginner_button.Size = new System.Drawing.Size(75, 23);
            this.cbeginner_button.TabIndex = 7;
            this.cbeginner_button.Text = "Beginner";
            this.cbeginner_button.UseVisualStyleBackColor = false;
            this.cbeginner_button.Click += new System.EventHandler(this.cbeginner_button_Click);
            // 
            // cintermediate_button
            // 
            this.cintermediate_button.AllowDrop = true;
            this.cintermediate_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cintermediate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cintermediate_button.FlatAppearance.BorderSize = 0;
            this.cintermediate_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cintermediate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cintermediate_button.Location = new System.Drawing.Point(74, 200);
            this.cintermediate_button.Name = "cintermediate_button";
            this.cintermediate_button.Size = new System.Drawing.Size(75, 23);
            this.cintermediate_button.TabIndex = 11;
            this.cintermediate_button.Text = "Intermediate";
            this.cintermediate_button.UseVisualStyleBackColor = false;
            this.cintermediate_button.Click += new System.EventHandler(this.cintermediate_button_Click);
            // 
            // cadvance_button
            // 
            this.cadvance_button.AllowDrop = true;
            this.cadvance_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cadvance_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadvance_button.FlatAppearance.BorderSize = 0;
            this.cadvance_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cadvance_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cadvance_button.Location = new System.Drawing.Point(74, 240);
            this.cadvance_button.Name = "cadvance_button";
            this.cadvance_button.Size = new System.Drawing.Size(75, 23);
            this.cadvance_button.TabIndex = 12;
            this.cadvance_button.Text = "Advance";
            this.cadvance_button.UseVisualStyleBackColor = false;
            this.cadvance_button.Click += new System.EventHandler(this.cadvance_button_Click);
            // 
            // cback_button
            // 
            this.cback_button.BackColor = System.Drawing.Color.Transparent;
            this.cback_button.FlatAppearance.BorderSize = 0;
            this.cback_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.cback_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cback_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cback_button.Image = global::CodeLab.Properties.Resources.backiconbs;
            this.cback_button.Location = new System.Drawing.Point(0, 27);
            this.cback_button.Name = "cback_button";
            this.cback_button.Size = new System.Drawing.Size(42, 40);
            this.cback_button.TabIndex = 18;
            this.toolTip1.SetToolTip(this.cback_button, "Back");
            this.cback_button.UseVisualStyleBackColor = false;
            this.cback_button.Click += new System.EventHandler(this.cback_button_Click);
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
            this.home_button.TabIndex = 19;
            this.toolTip1.SetToolTip(this.home_button, "Home");
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // clearnmore_button
            // 
            this.clearnmore_button.BackColor = System.Drawing.Color.Transparent;
            this.clearnmore_button.FlatAppearance.BorderSize = 0;
            this.clearnmore_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.clearnmore_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.clearnmore_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearnmore_button.Image = global::CodeLab.Properties.Resources.learnmoreicon;
            this.clearnmore_button.Location = new System.Drawing.Point(94, 27);
            this.clearnmore_button.Name = "clearnmore_button";
            this.clearnmore_button.Size = new System.Drawing.Size(40, 40);
            this.clearnmore_button.TabIndex = 20;
            this.toolTip1.SetToolTip(this.clearnmore_button, "Learn about C");
            this.clearnmore_button.UseVisualStyleBackColor = false;
            this.clearnmore_button.Click += new System.EventHandler(this.clearnmore_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeLab.Properties.Resources.Cbackground;
            this.ClientSize = new System.Drawing.Size(520, 416);
            this.Controls.Add(this.clearnmore_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.cback_button);
            this.Controls.Add(this.cadvance_button);
            this.Controls.Add(this.cintermediate_button);
            this.Controls.Add(this.cbeginner_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.head_menu);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.head_menu.ResumeLayout(false);
            this.head_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip head_menu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cbeginner_button;
        private System.Windows.Forms.Button cintermediate_button;
        private System.Windows.Forms.Button cadvance_button;
        private System.Windows.Forms.Button cback_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button clearnmore_button;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}