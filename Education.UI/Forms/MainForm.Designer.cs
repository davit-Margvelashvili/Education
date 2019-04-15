namespace Education.UI.Forms
{
    partial class MainForm
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
            this.menupanel = new System.Windows.Forms.Panel();
            this.mendeleevlabel = new System.Windows.Forms.Label();
            this.quizbutton = new System.Windows.Forms.Button();
            this.elementsbutton = new System.Windows.Forms.Button();
            this.tableInfoButton = new System.Windows.Forms.Button();
            this.taskbarpanel = new System.Windows.Forms.Panel();
            this.namelabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.mendeleevpictureBox = new System.Windows.Forms.PictureBox();
            this.hamburgerbutton = new System.Windows.Forms.PictureBox();
            this.menupanel.SuspendLayout();
            this.taskbarpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mendeleevpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.BackColor = System.Drawing.Color.SteelBlue;
            this.menupanel.Controls.Add(this.mendeleevlabel);
            this.menupanel.Controls.Add(this.mendeleevpictureBox);
            this.menupanel.Controls.Add(this.hamburgerbutton);
            this.menupanel.Controls.Add(this.quizbutton);
            this.menupanel.Controls.Add(this.elementsbutton);
            this.menupanel.Controls.Add(this.tableInfoButton);
            this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menupanel.Location = new System.Drawing.Point(0, 0);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(235, 621);
            this.menupanel.TabIndex = 0;
            // 
            // mendeleevlabel
            // 
            this.mendeleevlabel.AutoSize = true;
            this.mendeleevlabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mendeleevlabel.Location = new System.Drawing.Point(18, 223);
            this.mendeleevlabel.Name = "mendeleevlabel";
            this.mendeleevlabel.Size = new System.Drawing.Size(198, 22);
            this.mendeleevlabel.TabIndex = 4;
            this.mendeleevlabel.Text = "დიმიტრი მენდელეევი";
            // 
            // quizbutton
            // 
            this.quizbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quizbutton.BackColor = System.Drawing.SystemColors.Info;
            this.quizbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quizbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.quizbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.quizbutton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.quizbutton.Location = new System.Drawing.Point(0, 429);
            this.quizbutton.Name = "quizbutton";
            this.quizbutton.Size = new System.Drawing.Size(235, 58);
            this.quizbutton.TabIndex = 0;
            this.quizbutton.Text = "Quiz";
            this.quizbutton.UseVisualStyleBackColor = false;
            this.quizbutton.Click += new System.EventHandler(this.quizbutton_Click);
            // 
            // elementsbutton
            // 
            this.elementsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elementsbutton.BackColor = System.Drawing.SystemColors.Info;
            this.elementsbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.elementsbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.elementsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.elementsbutton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementsbutton.ForeColor = System.Drawing.Color.Firebrick;
            this.elementsbutton.Location = new System.Drawing.Point(0, 367);
            this.elementsbutton.Name = "elementsbutton";
            this.elementsbutton.Size = new System.Drawing.Size(235, 58);
            this.elementsbutton.TabIndex = 0;
            this.elementsbutton.Text = "Elements";
            this.elementsbutton.UseVisualStyleBackColor = false;
            // 
            // tableInfoButton
            // 
            this.tableInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableInfoButton.BackColor = System.Drawing.SystemColors.Info;
            this.tableInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tableInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tableInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableInfoButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableInfoButton.ForeColor = System.Drawing.Color.Firebrick;
            this.tableInfoButton.Location = new System.Drawing.Point(0, 306);
            this.tableInfoButton.Name = "tableInfoButton";
            this.tableInfoButton.Size = new System.Drawing.Size(235, 58);
            this.tableInfoButton.TabIndex = 0;
            this.tableInfoButton.Text = "The Periodic Table";
            this.tableInfoButton.UseVisualStyleBackColor = false;
            // 
            // taskbarpanel
            // 
            this.taskbarpanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.taskbarpanel.Controls.Add(this.namelabel);
            this.taskbarpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskbarpanel.ForeColor = System.Drawing.Color.Thistle;
            this.taskbarpanel.Location = new System.Drawing.Point(235, 0);
            this.taskbarpanel.Name = "taskbarpanel";
            this.taskbarpanel.Size = new System.Drawing.Size(840, 44);
            this.taskbarpanel.TabIndex = 1;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Sylfaen", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.namelabel.Location = new System.Drawing.Point(19, 10);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(182, 27);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Mendeleev Table";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(235, 44);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(840, 577);
            this.contentpanel.TabIndex = 3;
            // 
            // mendeleevpictureBox
            // 
            this.mendeleevpictureBox.Image = global::Education.UI.Properties.Resources.mendeleevpic;
            this.mendeleevpictureBox.Location = new System.Drawing.Point(65, 66);
            this.mendeleevpictureBox.Name = "mendeleevpictureBox";
            this.mendeleevpictureBox.Size = new System.Drawing.Size(98, 147);
            this.mendeleevpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mendeleevpictureBox.TabIndex = 2;
            this.mendeleevpictureBox.TabStop = false;
            // 
            // hamburgerbutton
            // 
            this.hamburgerbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hamburgerbutton.Image = global::Education.UI.Properties.Resources.icons8_menu_1001;
            this.hamburgerbutton.Location = new System.Drawing.Point(182, 8);
            this.hamburgerbutton.Name = "hamburgerbutton";
            this.hamburgerbutton.Size = new System.Drawing.Size(45, 36);
            this.hamburgerbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamburgerbutton.TabIndex = 1;
            this.hamburgerbutton.TabStop = false;
            this.hamburgerbutton.Click += new System.EventHandler(this.hamburgerbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 621);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.taskbarpanel);
            this.Controls.Add(this.menupanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menupanel.ResumeLayout(false);
            this.menupanel.PerformLayout();
            this.taskbarpanel.ResumeLayout(false);
            this.taskbarpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mendeleevpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.PictureBox hamburgerbutton;
        private System.Windows.Forms.Button tableInfoButton;
        private System.Windows.Forms.Panel taskbarpanel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.PictureBox mendeleevpictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button quizbutton;
        private System.Windows.Forms.Button elementsbutton;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Label mendeleevlabel;
    }
}