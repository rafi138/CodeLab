namespace CodeLab
{
    partial class Form4
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
            this.csrpadvance_button = new System.Windows.Forms.Button();
            this.csrpintermediate_button = new System.Windows.Forms.Button();
            this.csrpbeginner_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.csrpback_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.csrplearnmore_button = new System.Windows.Forms.Button();
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
            this.head_menu.Size = new System.Drawing.Size(408, 24);
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
            // csrpadvance_button
            // 
            this.csrpadvance_button.AllowDrop = true;
            this.csrpadvance_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.csrpadvance_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.csrpadvance_button.FlatAppearance.BorderSize = 0;
            this.csrpadvance_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.csrpadvance_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csrpadvance_button.Location = new System.Drawing.Point(78, 228);
            this.csrpadvance_button.Name = "csrpadvance_button";
            this.csrpadvance_button.Size = new System.Drawing.Size(75, 23);
            this.csrpadvance_button.TabIndex = 20;
            this.csrpadvance_button.Text = "Advance";
            this.csrpadvance_button.UseVisualStyleBackColor = false;
            this.csrpadvance_button.Click += new System.EventHandler(this.csrpadvance_button_Click);
            // 
            // csrpintermediate_button
            // 
            this.csrpintermediate_button.AllowDrop = true;
            this.csrpintermediate_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.csrpintermediate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.csrpintermediate_button.FlatAppearance.BorderSize = 0;
            this.csrpintermediate_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.csrpintermediate_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csrpintermediate_button.Location = new System.Drawing.Point(78, 188);
            this.csrpintermediate_button.Name = "csrpintermediate_button";
            this.csrpintermediate_button.Size = new System.Drawing.Size(75, 23);
            this.csrpintermediate_button.TabIndex = 19;
            this.csrpintermediate_button.Text = "Intermediate";
            this.csrpintermediate_button.UseVisualStyleBackColor = false;
            this.csrpintermediate_button.Click += new System.EventHandler(this.csrpintermediate_button_Click);
            // 
            // csrpbeginner_button
            // 
            this.csrpbeginner_button.AllowDrop = true;
            this.csrpbeginner_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.csrpbeginner_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.csrpbeginner_button.FlatAppearance.BorderSize = 0;
            this.csrpbeginner_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.csrpbeginner_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csrpbeginner_button.Location = new System.Drawing.Point(78, 146);
            this.csrpbeginner_button.Name = "csrpbeginner_button";
            this.csrpbeginner_button.Size = new System.Drawing.Size(75, 23);
            this.csrpbeginner_button.TabIndex = 18;
            this.csrpbeginner_button.Text = "Beginner";
            this.csrpbeginner_button.UseVisualStyleBackColor = false;
            this.csrpbeginner_button.Click += new System.EventHandler(this.csrpbeginner_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(74, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select level";
            // 
            // csrpback_button
            // 
            this.csrpback_button.BackColor = System.Drawing.Color.Transparent;
            this.csrpback_button.FlatAppearance.BorderSize = 0;
            this.csrpback_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.csrpback_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.csrpback_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csrpback_button.Image = global::CodeLab.Properties.Resources.backiconbs;
            this.csrpback_button.Location = new System.Drawing.Point(0, 27);
            this.csrpback_button.Name = "csrpback_button";
            this.csrpback_button.Size = new System.Drawing.Size(42, 40);
            this.csrpback_button.TabIndex = 21;
            this.toolTip1.SetToolTip(this.csrpback_button, "Back");
            this.csrpback_button.UseVisualStyleBackColor = false;
            this.csrpback_button.Click += new System.EventHandler(this.csrpback_button_Click);
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
            this.home_button.TabIndex = 22;
            this.toolTip1.SetToolTip(this.home_button, "Home");
            this.home_button.UseVisualStyleBackColor = false;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // csrplearnmore_button
            // 
            this.csrplearnmore_button.BackColor = System.Drawing.Color.Transparent;
            this.csrplearnmore_button.FlatAppearance.BorderSize = 0;
            this.csrplearnmore_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.csrplearnmore_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.csrplearnmore_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csrplearnmore_button.Image = global::CodeLab.Properties.Resources.learnmoreicon;
            this.csrplearnmore_button.Location = new System.Drawing.Point(94, 27);
            this.csrplearnmore_button.Name = "csrplearnmore_button";
            this.csrplearnmore_button.Size = new System.Drawing.Size(40, 40);
            this.csrplearnmore_button.TabIndex = 23;
            this.toolTip1.SetToolTip(this.csrplearnmore_button, "Learn about C#");
            this.csrplearnmore_button.UseVisualStyleBackColor = false;
            this.csrplearnmore_button.Click += new System.EventHandler(this.csrplearnmore_button_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CodeLab.Properties.Resources.Csrpbackground;
            this.ClientSize = new System.Drawing.Size(408, 402);
            this.Controls.Add(this.csrplearnmore_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.csrpback_button);
            this.Controls.Add(this.csrpadvance_button);
            this.Controls.Add(this.csrpintermediate_button);
            this.Controls.Add(this.csrpbeginner_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.head_menu);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# (sharp)";
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
        private System.Windows.Forms.Button csrpadvance_button;
        private System.Windows.Forms.Button csrpintermediate_button;
        private System.Windows.Forms.Button csrpbeginner_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button csrpback_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button csrplearnmore_button;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}