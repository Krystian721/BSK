namespace Project
{
    partial class formEncrypt
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSource = new System.Windows.Forms.TextBox();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.bOpen = new System.Windows.Forms.Button();
            this.bHash = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.lSource = new System.Windows.Forms.Label();
            this.lChoose = new System.Windows.Forms.Label();
            this.cbHash = new System.Windows.Forms.ComboBox();
            this.lHash = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weryfikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(12, 100);
            this.tbSource.Multiline = true;
            this.tbSource.Name = "tbSource";
            this.tbSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSource.Size = new System.Drawing.Size(420, 161);
            this.tbSource.TabIndex = 0;
            // 
            // tbHash
            // 
            this.tbHash.Enabled = false;
            this.tbHash.Location = new System.Drawing.Point(15, 331);
            this.tbHash.Multiline = true;
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(420, 84);
            this.tbHash.TabIndex = 1;
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(12, 36);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(188, 41);
            this.bOpen.TabIndex = 2;
            this.bOpen.Text = "Otwórz plik";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bHash
            // 
            this.bHash.Location = new System.Drawing.Point(244, 267);
            this.bHash.Name = "bHash";
            this.bHash.Size = new System.Drawing.Size(188, 41);
            this.bHash.TabIndex = 3;
            this.bHash.Text = "Generuj skrót";
            this.bHash.UseVisualStyleBackColor = true;
            this.bHash.Click += new System.EventHandler(this.bHash_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(244, 36);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(188, 41);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Zapisz skrót do pliku";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lSource
            // 
            this.lSource.AutoSize = true;
            this.lSource.Location = new System.Drawing.Point(12, 80);
            this.lSource.Name = "lSource";
            this.lSource.Size = new System.Drawing.Size(106, 17);
            this.lSource.TabIndex = 5;
            this.lSource.Text = "Tekst źródłowy:";
            // 
            // lChoose
            // 
            this.lChoose.AutoSize = true;
            this.lChoose.Location = new System.Drawing.Point(12, 264);
            this.lChoose.Name = "lChoose";
            this.lChoose.Size = new System.Drawing.Size(104, 17);
            this.lChoose.TabIndex = 6;
            this.lChoose.Text = "Funkcja skrótu:";
            // 
            // cbHash
            // 
            this.cbHash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHash.FormattingEnabled = true;
            this.cbHash.Location = new System.Drawing.Point(15, 284);
            this.cbHash.Name = "cbHash";
            this.cbHash.Size = new System.Drawing.Size(188, 24);
            this.cbHash.TabIndex = 7;
            // 
            // lHash
            // 
            this.lHash.AutoSize = true;
            this.lHash.Location = new System.Drawing.Point(12, 311);
            this.lHash.Name = "lHash";
            this.lHash.Size = new System.Drawing.Size(45, 17);
            this.lHash.TabIndex = 8;
            this.lHash.Text = "Skrót:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weryfikacjaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 24);
            this.toolStripMenuItem1.Text = "Funkcja skrótu";
            // 
            // weryfikacjaToolStripMenuItem
            // 
            this.weryfikacjaToolStripMenuItem.Name = "weryfikacjaToolStripMenuItem";
            this.weryfikacjaToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.weryfikacjaToolStripMenuItem.Text = "Weryfikacja";
            this.weryfikacjaToolStripMenuItem.Click += new System.EventHandler(this.weryfikacjaToolStripMenuItem_Click);
            // 
            // formEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 427);
            this.Controls.Add(this.lHash);
            this.Controls.Add(this.cbHash);
            this.Controls.Add(this.lChoose);
            this.Controls.Add(this.lSource);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bHash);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "formEncrypt";
            this.Text = "Utworzenie skrótu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formEncrypt_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bHash;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lSource;
        private System.Windows.Forms.Label lChoose;
        private System.Windows.Forms.ComboBox cbHash;
        private System.Windows.Forms.Label lHash;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem weryfikacjaToolStripMenuItem;
    }
}

