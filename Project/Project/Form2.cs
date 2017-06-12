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
    public partial class formVerify : Form
    {
        public formVerify()
        {
            InitializeComponent();
            ComboBox();
        }

        private void ButtonOpenSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Otwórz plik źródłowy",
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

        private void ButtonOpenHash_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Otwórz plik skrótu",
                Filter = "Pliki tekstowe |*.txt",
                InitialDirectory = @"C:\"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbHash.Text = "";
                try
                {
                    tbHash.Text = File.ReadAllText(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: Nie można odczytać pliku z dysku. Treść błędu: " + ex.Message, "BŁĄD!", MessageBoxButtons.OK);
                }
            }
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        { 
            string hashFunction = cbHash.Text;
            if (tbSource.Text != "")
            {
                if (tbHash.Text != "")
                {
                    switch (hashFunction)
                    {
                        case "MD5":
                            if (VerifyingMD5Hash(tbSource.Text, tbHash.Text))
                            {
                                MessageBox.Show("Wszystko OK!", "ZGODNE!", MessageBoxButtons.OK);
                            }
                            else MessageBox.Show("Niepoprawny skrót!", "BŁĄD!", MessageBoxButtons.OK);
                            break;
                        case "RIPEMD160":
                            if (VerifyingRIPEMD160Hash(tbSource.Text, tbHash.Text))
                            {
                                MessageBox.Show("Wszystko OK!", "ZGODNE!", MessageBoxButtons.OK);
                            }
                            else MessageBox.Show("Niepoprawny skrót!", "BŁĄD!", MessageBoxButtons.OK);
                            break;
                        case "SHA1":
                            if (VerifyingSHA1Hash(tbSource.Text, tbHash.Text))
                            {
                                MessageBox.Show("Wszystko OK!", "ZGODNE!", MessageBoxButtons.OK);
                            }
                            else MessageBox.Show("Niepoprawny skrót!", "BŁĄD!", MessageBoxButtons.OK);
                            break;
                        case "SHA256":
                            if (VerifyingSHA256Hash(tbSource.Text, tbHash.Text))
                            {
                                MessageBox.Show("Wszystko OK!", "ZGODNE!", MessageBoxButtons.OK);
                            }
                            else MessageBox.Show("Niepoprawny skrót!", "BŁĄD!", MessageBoxButtons.OK);
                            break;
                        case "SHA384":
                            if (VerifyingSHA384Hash(tbSource.Text, tbHash.Text))
                            {
                                MessageBox.Show("Wszystko OK!", "ZGODNE!", MessageBoxButtons.OK);
                            }
                            else MessageBox.Show("Niepoprawny skrót!", "BŁĄD!", MessageBoxButtons.OK);
                            break;
                        case "SHA512":
                            if (VerifyingSHA512Hash(tbSource.Text, tbHash.Text))
                            {
                                MessageBox.Show("Wszystko OK!", "ZGODNE!", MessageBoxButtons.OK);
                            }
                            else MessageBox.Show("Niepoprawny skrót!", "BŁĄD!", MessageBoxButtons.OK);
                            break;
                    }
                }
                else MessageBox.Show("Najpierw otwórz plik skrótu!", "BŁĄD!", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Najpierw otwórz plik źródłowy!", "BŁĄD!", MessageBoxButtons.OK);
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

        private void tworzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEncrypt form = new formEncrypt();
            form.Show();
            form.Location = this.Location;
            this.Hide();
        }

        private void formVerify_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
