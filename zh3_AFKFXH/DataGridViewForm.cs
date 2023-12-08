using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_AFKFXH.Models;

namespace zh3_AFKFXH
{
    public partial class DataGridViewForm : Form
    {
        Zh3Context context = new Zh3Context();
        public DataGridViewForm()
        {
            InitializeComponent();

            Csapat1();
            Csapat2();

            listBox1.DisplayMember = "Nev";
            listBox2.DisplayMember = "Nev";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Csapat1();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Csapat2();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Meccs();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Meccs();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Meccs();
        }

        private void Meccs()
        {
            var csapat1 = listBox1.SelectedIndex + 1;
            var csapat2 = listBox2.SelectedIndex + 1;
            var meccs = from x in context.Meccs
                        where x.Csapat1Navigation.CsapatId == csapat1 & x.Csapat2Navigation.CsapatId == csapat2
                        select new Mérkőzés
                        {
                            Csapat1 = x.Csapat1Navigation.Nev,
                            Csapat2 = x.Csapat2Navigation.Nev,
                            Nezoszam = x.Nezoszam,
                            Bevétel = x.Nezoszam * x.Nap.Jegyar,
                            Eredmeny = x.Eredmeny,
                            Nap = x.NapId
                        };

            mérkőzésBindingSource.DataSource = meccs.ToList();
        }

        private void Csapat1()
        {
            var csapat1 = from x in context.Csapats
                          where x.Nev.StartsWith(textBox1.Text)
                          select x;

            listBox1.DataSource = csapat1.ToList();
        }

        private void Csapat2()
        {
            var csapat2 = from x in context.Csapats
                          where x.Nev.StartsWith(textBox2.Text)
                          select x;

            listBox2.DataSource = csapat2.ToList();
        }

        private void FelvételButton_Click(object sender, EventArgs e)
        {
            //0-tól kezdi az indexet így ütközik már korábbival :((((
            Mecc új = new Mecc();
            új.Csapat1 = ((Csapat)listBox1.SelectedItem).CsapatId;
            új.Csapat2 = ((Csapat)listBox2.SelectedItem).CsapatId;
            új.Nezoszam = Int32.Parse(nézőTextBox.Text);
            új.Eredmeny = eredményTextBox.Text;

            új.Nap = null;
            új.Stadion = null;


            context.Meccs.Add(új);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
            Meccs();
        }

        private bool CheckEredmény(string e)
        {
            Regex r = new Regex("^[0-9]-[0-9]$");
            return r.IsMatch(e);
        }

        private void eredményTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEredmény(eredményTextBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(eredményTextBox, "Az eredmény (szám)-(szám) formátumban kell legyen");
            }
        }

        private void eredményTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(eredményTextBox, "");
        }

        private void TörlésButton_Click(object sender, EventArgs e)
        {
            var ID = ((Mecc)mérkőzésBindingSource.Current).MeccsId;

            var törlendő = (from x in context.Meccs
                            where x.MeccsId == ID
                            select x).FirstOrDefault();

            context.Meccs.Remove(törlendő);
            try
            {

                //context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }
            Meccs();
        }
    }
}
