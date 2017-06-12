namespace Project
{
    partial class formVerify
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
            this.ButtonOpenSource = new System.Windows.Forms.Button();
            this.lSource = new System.Windows.Forms.Label();
            this.ButtonOpenHash = new System.Windows.Forms.Button();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.lChoose = new System.Windows.Forms.Label();
            this.cbHash = new System.Windows.Forms.ComboBox();
            this.ButtonVerify = new System.Windows.Forms.Button();
            this.lHash = new System.Windows.Forms.Label();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tworzenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOpenSource
            // 
            this.ButtonOpenSource.Location = new System.Drawing.Point(12, 31);
            this.ButtonOpenSource.Name = "ButtonOpenSource";
            this.ButtonOpenSource.Size = new System.Drawing.Size(188, 41);
            this.ButtonOpenSource.TabIndex = 3;
            this.ButtonOpenSource.Text = "Otwórz plik źródłowy";
            this.ButtonOpenSource.UseVisualStyleBackColor = true;
            this.ButtonOpenSource.Click += new System.EventHandler(this.ButtonOpenSource_Click);
            // 
            // lSource
            // 
            this.lSource.AutoSize = true;
            this.lSource.Location = new System.Drawing.Point(12, 77);
            this.lSource.Name = "lSource";
            this.lSource.Size = new System.Drawing.Size(106, 17);
            this.lSource.TabIndex = 6;
            this.lSource.Text = "Tekst źródłowy:";
            // 
            // ButtonOpenHash
            // 
            this.ButtonOpenHash.Location = new System.Drawing.Point(244, 31);
            this.ButtonOpenHash.Name = "ButtonOpenHash";
            this.ButtonOpenHash.Size = new System.Drawing.Size(188, 41);
            this.ButtonOpenHash.TabIndex = 7;
            this.ButtonOpenHash.Text = "Otwórz plik skrótu";
            this.ButtonOpenHash.UseVisualStyleBackColor = true;
            this.ButtonOpenHash.Click += new System.EventHandler(this.ButtonOpenHash_Click);
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(12, 97);
            this.tbSource.Multiline = true;
            this.tbSource.Name = "tbSource";
            this.tbSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSource.Size = new System.Drawing.Size(420, 161);
            this.tbSource.TabIndex = 8;
            // 
            // lChoose
            // 
            this.lChoose.AutoSize = true;
            this.lChoose.Location = new System.Drawing.Point(12, 368);
            this.lChoose.Name = "lChoose";
            this.lChoose.Size = new System.Drawing.Size(104, 17);
            this.lChoose.TabIndex = 9;
            this.lChoose.Text = "Funkcja skrótu:";
            // 
            // cbHash
            // 
            this.cbHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHash.FormattingEnabled = true;
            this.cbHash.Location = new System.Drawing.Point(12, 388);
            this.cbHash.Name = "cbHash";
            this.cbHash.Size = new System.Drawing.Size(188, 24);
            this.cbHash.TabIndex = 10;
            // 
            // ButtonVerify
            // 
            this.ButtonVerify.Location = new System.Drawing.Point(244, 371);
            this.ButtonVerify.Name = "ButtonVerify";
            this.ButtonVerify.Size = new System.Drawing.Size(188, 41);
            this.ButtonVerify.TabIndex = 11;
            this.ButtonVerify.Text = "Zweryfikuj";
            this.ButtonVerify.UseVisualStyleBackColor = true;
            this.ButtonVerify.Click += new System.EventHandler(this.ButtonVerify_Click);
            // 
            // lHash
            // 
            this.lHash.AutoSize = true;
            this.lHash.Location = new System.Drawing.Point(12, 261);
            this.lHash.Name = "lHash";
            this.lHash.Size = new System.Drawing.Size(45, 17);
            this.lHash.TabIndex = 12;
            this.lHash.Text = "Skrót:";
            // 
            // tbHash
            // 
            this.tbHash.Enabled = false;
            this.tbHash.Location = new System.Drawing.Point(15, 281);
            this.tbHash.Multiline = true;
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(420, 84);
            this.tbHash.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tworzenieToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItem1.Text = "Funkcja skrótu";
            // 
            // tworzenieToolStripMenuItem
            // 
            this.tworzenieToolStripMenuItem.Name = "tworzenieToolStripMenuItem";
            this.tworzenieToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.tworzenieToolStripMenuItem.Text = "Tworzenie";
            this.tworzenieToolStripMenuItem.Click += new System.EventHandler(this.tworzenieToolStripMenuItem_Click);
            // 
            // formVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 424);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.lHash);
            this.Controls.Add(this.ButtonVerify);
            this.Controls.Add(this.cbHash);
            this.Controls.Add(this.lChoose);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.ButtonOpenHash);
            this.Controls.Add(this.lSource);
            this.Controls.Add(this.ButtonOpenSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formVerify";
            this.Text = "Weryfikacja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formVerify_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOpenSource;
        private System.Windows.Forms.Label lSource;
        private System.Windows.Forms.Button ButtonOpenHash;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label lChoose;
        private System.Windows.Forms.ComboBox cbHash;
        private System.Windows.Forms.Button ButtonVerify;
        private System.Windows.Forms.Label lHash;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tworzenieToolStripMenuItem;
    }
}