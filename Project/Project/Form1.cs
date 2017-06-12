using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HashFunctions;



namespace Project
{
    public partial class formEncrypt : Form
    {
        public formEncrypt()
        {
            InitializeComponent();
            ComboBox();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Otwórz plik tekstowy",
                Filter = "Pliki tekstowe |*.txt",
                InitialDirectory = @"C:\"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbSource.Text = "";
                try
                {                 
                    tbSource.Text = File.ReadAllText(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: Nie można odczytać pliku z dysku. Treść błędu: " + ex.Message, "BŁĄD!", MessageBoxButtons.OK);
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tbHash.Text != "")
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Zapisz plik tekstowy",
                    Filter = "Pliki tekstowe |*.txt",
                    InitialDirectory = @"C:\"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, tbHash.Text);
                    MessageBox.Show("Plik został zapisany!", "Zapisano!", MessageBoxButtons.OK);
                }
            }
            else MessageBox.Show("Najpierw wygeneruj skrót!", "BŁĄD!", MessageBoxButtons.OK);
        }

        private void bHash_Click(object sender, EventArgs e)
        {
            string hashFunction = cbHash.Text;
            if (tbSource.Text != "")
            {
                switch (hashFunction)
                {
                    case "MD5":
                        tbHash.Text = CalculateMD5Hash(tbSource.Text);
                        break;
                    case "RIPEMD160":
                        tbHash.Text = CalculateRIPEMD160Hash(tbSource.Text);
                        break;
                    case "SHA1":
                        tbHash.Text = CalculateSHA1Hash(tbSource.Text);
                        break;
                    case "SHA256":
                        tbHash.Text = CalculateSHA256Hash(tbSource.Text);
                        break;
                    case "SHA384":
                        tbHash.Text = CalculateSHA384Hash(tbSource.Text);
                        break;
                    case "SHA512":
                        tbHash.Text = CalculateSHA512Hash(tbSource.Text);
                        break;
                }
            }
            else MessageBox.Show("Najpierw otwórz plik tekstowy!", "BŁĄD!", MessageBoxButtons.OK);
        }

        private void ComboBox()
        {
            cbHash.Items.Add("MD5");
            cbHash.Items.Add("RIPEMD160");
            cbHash.Items.Add("SHA1");
            cbHash.Items.Add("SHA256");
            cbHash.Items.Add("SHA384");
            cbHash.Items.Add("SHA512");
            cbHash.SelectedIndex = 0;
        }

        private void weryfikacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVerify form = new formVerify();
            form.Show();
            form.Location = this.Location;
            this.Hide();
        }

        private void formEncrypt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
