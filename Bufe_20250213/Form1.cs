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
    }
}
