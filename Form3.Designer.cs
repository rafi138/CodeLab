namespace CodeLab
{
    partial class Form3
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
            this.cppadvance_button = new System.Windows.Forms.Button();
            this.cppintermediate_button = new System.Windows.Forms.Button();
            this.cppbeginner_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cppback_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.cpplearnmore_button = new System.Windows.Forms.Button();
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
            this.head_menu.Size = new System.Drawing.Size(443, 24);
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
            // cppadvance_button
            // 
            this.cppadvance_button.AllowDrop = true;
            this.cppadvance_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cppadvance_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cppadvance_button.FlatAppearance.BorderSize = 0;
            this.cppadvance_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cppadvance_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cppadvance_button.Location = new System.Drawing.Point(78, 247);
            this.cppadvance_button.Name = "cppadvance_button";
            this.cppadvance_button.Size = new System.Drawing.Size(75, 23);
            this.cppadvance_button.TabIndex = 16;
            this.cppadvance_button.Text = "Advance";
            this.cppadvance_button.UseVisualStyleBackColor = false;
            this.cppadvance_button.Click += new System.EventHandler(this.cppadvance_button_Click);
            // 
            // cppintermediate_button
            // 
            this.cppintermediate_button.AllowDrop = true;
            this.cppintermediate_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cppintermediate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cppintermediate_button.FlatAppearance.BorderSize = 0;
            this.cppintermediate_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cppintermediate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cppintermediate_button.Location = new System.Drawing.Point(78, 207);
            this.cppintermediate_button.Name = "cppintermediate_button";
            this.cppintermediate_button.Size = new System.Drawing.Size(75, 23);
            this.cppintermediate_button.TabIndex = 15;
            this.cppintermediate_button.Text = "Intermediate";
            this.cppintermediate_button.UseVisualStyleBackColor = false;
            this.cppintermediate_button.Click += new System.EventHandler(this.cppintermediate_button_Click);
            // 
            // cppbeginner_button
            // 
            this.cppbeginner_button.AllowDrop = true;
            this.cppbeginner_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.cppbeginner_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cppbeginner_button.FlatAppearance.BorderSize = 0;
            this.cppbeginner_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.cppbeginner_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cppbeginner_button.Location = new System.Drawing.Point(78, 165);
            this.cppbeginner_button.Name = "cppbeginner_button";
            this.cppbeginner_button.Size = new System.Drawing.Size(75, 23);
            this.cppbeginner_button.TabIndex = 14;
            this.cppbeginner_button.Text = "Beginner";
            this.cppbeginner_button.UseVisualStyleBackColor = false;
            this.cppbeginner_button.Click += new System.EventHandler(this.cppbeginner_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(74, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select level";
            // 
            // cppback_button
            // 
            this.cppback_button.BackColor = System.Drawing.Color.Transparent;
            this.cppback_button.FlatAppearance.BorderSize = 0;
            this.cppback_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.cppback_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cppback_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cppback_button.Image = global::CodeLab.Properties.Resources.backiconbs;
            this.cppback_button.Location = new System.Drawing.Point(0, 27);
            this.cppback_button.Name = "cppback_button";
            this.cppback_button.Size = new System.Drawing.Size(42, 40);
            this.cppback_button.TabIndex = 17;
            this.toolTip1.SetToolTip(this.cppback_button, "Back");
            this.cppback_button.UseVisualStyleBackColor = false;
            this.cppback_button.Click += new System.EventHandler(this.cppback_button_Click);
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
            this.home_button.TabIndex = 18;
            this.toolTip1.SetToolTip(this.home_button, "Home");
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // cpplearnmore_button
            // 
            this.cpplearnmore_button.BackColor = System.Drawing.Color.Transparent;
            this.cpplearnmore_button.FlatAppearance.BorderSize = 0;
            this.cpplearnmore_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.cpplearnmore_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.cpplearnmore_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cpplearnmore_button.Image = global::CodeLab.Properties.Resources.learnmoreicon;
            this.cpplearnmore_button.Location = new System.Drawing.Point(94, 27);
            this.cpplearnmore_button.Name = "cpplearnmore_button";
            this.cpplearnmore_button.Size = new System.Drawing.Size(40, 40);
            this.cpplearnmore_button.TabIndex = 24;
            this.toolTip1.SetToolTip(this.cpplearnmore_button, "Learn about C++");
            this.cpplearnmore_button.UseVisualStyleBackColor = false;
            this.cpplearnmore_button.Click += new System.EventHandler(this.cpplearnmore_button_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeLab.Properties.Resources.Cppbackground;
            this.ClientSize = new System.Drawing.Size(443, 402);
            this.Controls.Add(this.cpplearnmore_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.cppback_button);
            this.Controls.Add(this.cppadvance_button);
            this.Controls.Add(this.cppintermediate_button);
            this.Controls.Add(this.cppbeginner_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.head_menu);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C++";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.Button cppadvance_button;
        private System.Windows.Forms.Button cppintermediate_button;
        private System.Windows.Forms.Button cppbeginner_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cppback_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button cpplearnmore_button;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}