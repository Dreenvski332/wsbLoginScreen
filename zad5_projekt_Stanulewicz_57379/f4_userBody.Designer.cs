namespace zad5_projekt_Stanulewicz_57379
{
    partial class f4_userBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f4_userBody));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.placeholderButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.placeholderGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerGroup = new System.Windows.Forms.GroupBox();
            this.closeTimerGroupButton = new System.Windows.Forms.Button();
            this.startTextbox = new System.Windows.Forms.TextBox();
            this.endTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.placeholderGroup.SuspendLayout();
            this.timerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.placeholderButton);
            this.panel1.Controls.Add(this.booksButton);
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 99);
            this.panel1.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(1170, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(82, 37);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Location = new System.Drawing.Point(1170, 50);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(82, 37);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // placeholderButton
            // 
            this.placeholderButton.BackColor = System.Drawing.SystemColors.Control;
            this.placeholderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("placeholderButton.BackgroundImage")));
            this.placeholderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.placeholderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.placeholderButton.Location = new System.Drawing.Point(93, 12);
            this.placeholderButton.Name = "placeholderButton";
            this.placeholderButton.Size = new System.Drawing.Size(75, 75);
            this.placeholderButton.TabIndex = 2;
            this.placeholderButton.UseVisualStyleBackColor = false;
            this.placeholderButton.Click += new System.EventHandler(this.placeholderButton_Click);
            // 
            // booksButton
            // 
            this.booksButton.BackColor = System.Drawing.SystemColors.Control;
            this.booksButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("booksButton.BackgroundImage")));
            this.booksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.booksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.booksButton.Location = new System.Drawing.Point(12, 12);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(75, 75);
            this.booksButton.TabIndex = 1;
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // placeholderGroup
            // 
            this.placeholderGroup.Controls.Add(this.label1);
            this.placeholderGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.placeholderGroup.Location = new System.Drawing.Point(37, 105);
            this.placeholderGroup.Name = "placeholderGroup";
            this.placeholderGroup.Size = new System.Drawing.Size(1181, 545);
            this.placeholderGroup.TabIndex = 6;
            this.placeholderGroup.TabStop = false;
            this.placeholderGroup.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placeholder";
            // 
            // timerGroup
            // 
            this.timerGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timerGroup.BackgroundImage")));
            this.timerGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.timerGroup.Controls.Add(this.label4);
            this.timerGroup.Controls.Add(this.saveButton);
            this.timerGroup.Controls.Add(this.label3);
            this.timerGroup.Controls.Add(this.label2);
            this.timerGroup.Controls.Add(this.endTextbox);
            this.timerGroup.Controls.Add(this.startTextbox);
            this.timerGroup.Controls.Add(this.closeTimerGroupButton);
            this.timerGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timerGroup.Location = new System.Drawing.Point(0, 105);
            this.timerGroup.Name = "timerGroup";
            this.timerGroup.Size = new System.Drawing.Size(1264, 579);
            this.timerGroup.TabIndex = 7;
            this.timerGroup.TabStop = false;
            this.timerGroup.Visible = false;
            // 
            // closeTimerGroupButton
            // 
            this.closeTimerGroupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeTimerGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeTimerGroupButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeTimerGroupButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.closeTimerGroupButton.Location = new System.Drawing.Point(1221, 13);
            this.closeTimerGroupButton.Name = "closeTimerGroupButton";
            this.closeTimerGroupButton.Size = new System.Drawing.Size(25, 25);
            this.closeTimerGroupButton.TabIndex = 7;
            this.closeTimerGroupButton.Text = "X";
            this.closeTimerGroupButton.UseVisualStyleBackColor = true;
            this.closeTimerGroupButton.Click += new System.EventHandler(this.closeTimerGroupButton_Click_1);
            // 
            // startTextbox
            // 
            this.startTextbox.Location = new System.Drawing.Point(37, 66);
            this.startTextbox.Name = "startTextbox";
            this.startTextbox.Size = new System.Drawing.Size(140, 23);
            this.startTextbox.TabIndex = 8;
            // 
            // endTextbox
            // 
            this.endTextbox.Location = new System.Drawing.Point(37, 143);
            this.endTextbox.Name = "endTextbox";
            this.endTextbox.Size = new System.Drawing.Size(140, 23);
            this.endTextbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Godzina rozpoczęcia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Godzina zakończenia";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(43, 186);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 31);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Godziny należy podawać w formacie HH:MM:SS, na przykał \"08:00:12\"";
            // 
            // f4_userBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.timerGroup);
            this.Controls.Add(this.placeholderGroup);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f4_userBody";
            this.Text = "Panel Użytkownika";
            this.panel1.ResumeLayout(false);
            this.placeholderGroup.ResumeLayout(false);
            this.placeholderGroup.PerformLayout();
            this.timerGroup.ResumeLayout(false);
            this.timerGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button placeholderButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.GroupBox placeholderGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox timerGroup;
        private System.Windows.Forms.Button closeTimerGroupButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox endTextbox;
        private System.Windows.Forms.TextBox startTextbox;
        private System.Windows.Forms.Label label4;
    }
}