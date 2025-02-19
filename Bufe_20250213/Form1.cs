using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bufe_20250213
{
    public partial class FoForm : Form
    {
        string regisroszam;
        public void betoltes()
        {
            dgadatok.Rows.Clear();
            string kereses = "";
            if (txsearch.TextLength > 0)
            {
                kereses = " where vevo like '" + txsearch.Text + "'%";
            }
            string lekerdezes = "select * from forgalom";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                DateTime datum = Convert.ToDateTime(ab.Dr["datum"]);
                dgadatok.Rows.Add(ab.Dr["sorszam"], ab.Dr["vevo"], datum.Date.ToString("yyyy-MM-dd"), ab.Dr["termek"], ab.Dr["menny"], ab.Dr["brutto"], ab.Dr["fizetendo"]);
            }
        }
        void fuzenetendoszamolas()
        {
            if(txbrutto.Text.Length>0 && txmenny.Text.Length > 0)
            {
                int fizetendo = Convert.ToInt32(txbrutto.Text) * Convert.ToInt32(txmenny.Text);
                lbfizetendo.Text = "Fizetendő összeg: "+fizetendo.ToString()+" Ft";
            }
        }
        void torles()
        {
            txsorszam.Clear();
            txtermek.Clear();
            txvevo.Clear();
            txmenny.Clear();
            txbrutto.Clear();
            lbfizetendo.Text = "";
            MessageBox.Show("Sikeres művelet", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public FoForm()
        {
            InitializeComponent();
        }

        private void FoForm_Load(object sender, EventArgs e)
        {
            betoltes();
            rbnew.Checked = true;
        }

        private void txsearch_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void txsorszam_TextChanged(object sender, EventArgs e)
        {
            if (txsorszam.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txsorszam.Text);
                }
                catch
                {
                    txsorszam.Clear();
                    MessageBox.Show("Csak számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txsorszam.Focus();
                }
            }
        }

        private void txmenny_TextChanged(object sender, EventArgs e)
        {
            if (txmenny.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txmenny.Text);
                }
                catch
                {
                    txmenny.Clear();
                    MessageBox.Show("Csak számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txmenny.Focus();
                }
            }
            fuzenetendoszamolas();
        }

        private void txbrutto_TextChanged(object sender, EventArgs e)
        {
            if (txbrutto.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txbrutto.Text);
                }
                catch
                {
                    txbrutto.Clear();
                    MessageBox.Show("Csak számot adjon meg!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbrutto.Focus();
                }
            }
            fuzenetendoszamolas();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult uzenet = MessageBox.Show("Biztosan elszeretné vetni?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(uzenet == DialogResult.Yes)
            {
                Close();
            }
        }

        private void rbnew_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnew.Checked)
            {
                padatok.Visible = true;
                dgadatok.Enabled = true;
                txsorszam.Focus();
            }
        }

        private void rbedit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbedit.Checked)
            {
                padatok.Visible = false;
                dgadatok.Enabled = true;

            }
        }

        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            txsorszam.Text = sor.Cells["sorszam"].Value.ToString();
            regisroszam = sor.Cells["sorszam"].Value.ToString();
            txvevo.Text = sor.Cells["vevo"].Value.ToString();
            txtermek.Text = sor.Cells["termek"].Value.ToString();
            txmenny.Text = sor.Cells["menny"].Value.ToString();
            txbrutto.Text = sor.Cells["brutto"].Value.ToString();
            dtdatum.Value = Convert.ToDateTime(sor.Cells["datum"].Value);
            padatok.Visible=true;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if(txsorszam.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a sorszámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txsorszam.Focus();
            }
            else if (txvevo.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a vevő nevét!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txvevo.Focus();
            }
            else if (txtermek.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a terméket!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtermek.Focus();
            }
            else if (txbrutto.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a bruttó egységárat!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbrutto.Focus();
            }
            else if (txmenny.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a mennyiséget!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txmenny.Focus();
            }
            else if(rbnew.Checked)
            {
                string lekerdezes = "select count(sorszam) as db from forgalom where sorszam='"+txsorszam.Text+"'";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                int sorszamokdb = Convert.ToInt32(ab.Dr["db"]);
                ab.lezaras();
                if(sorszamokdb > 0)
                {
                    MessageBox.Show("Ilyen sorszámú tétel már szerepel!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txsorszam.Clear();
                    txsorszam.Focus();
                }
                else
                {
                    lekerdezes = "insert into forgalom(sorszam, vevo, termek, mennyiseg, brutto, datum) values ('" + txsorszam.Text + "','" + txvevo.Text + "','" + txtermek.Text + "','" + txmenny.Text + "','" + txbrutto.Text + "','" + dtdatum.Text + "')";
                    ab = new Adatbazis (lekerdezes);
                    ab.Dr.Read();
                    torles();

                }
            }
            else
            {
                string ujsorszam = txsorszam.Text;
                string lekerdezes;
                if (regisroszam == ujsorszam)
                {
                    lekerdezes = "update forgalom set vevo='" + txvevo.Text + "',termek='" + txtermek.Text + "',menny='" + txmenny.Text + "',brutto='" + txbrutto.Text + "',datum='" + dtdatum.Text + "' where sorszam ='" + regisroszam + "'";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read(); torles();
                }
                else
                {
                    lekerdezes = "select count(sorszam) as db from forgalom where sorszam='" + ujsorszam + "'";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    int sorszamdb = Convert.ToInt32(ab.Dr["db"]);
                    ab.lezaras();
                    if (sorszamdb > 0)
                    {
                        MessageBox.Show("Ilyen sorszámú tétel már szerepel!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txsorszam.Clear();
                        txsorszam.Focus();
                    }
                    else
                    {
                        lekerdezes = "update forgalom set sorszam='" + ujsorszam + "', vevo='" + txvevo.Text + "',termek='" + txtermek.Text + "',menny='" + txmenny.Text + "',brutto='" + txbrutto.Text + "',datum='" + dtdatum.Text + "' where sorszam ='" + regisroszam + "'";
                        ab = new Adatbazis(lekerdezes);
                        ab.Dr.Read(); torles();
                    }
                }
            }

        }
    }
}
