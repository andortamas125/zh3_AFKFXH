using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_AFKFXH.Models;

namespace zh3_AFKFXH
{
    public partial class Csapat_uc : UserControl
    {
        Zh3Context context = new Zh3Context();
        public Csapat_uc()
        {
            InitializeComponent();

            CsapatListBox.DisplayMember = "Nev";
            Stadionok();

        }

        //Szűrés
        private void StadionokTextBox_TextChanged(object sender, EventArgs e)
        {
            Stadionok();
        }

        private void Stadionok()
        {
            var stadionok = from x in context.Csapats
                            where x.Nev.Contains(CsapatTextBox.Text)
                            select x;

            CsapatListBox.DataSource = stadionok.ToList();
        }

        //Kiválasztott stadionról infok
        private void StadionokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stadinfo();
        }

        private void Stadinfo()
        {
            var valasztott = ((Csapat)CsapatListBox.SelectedItem).CsapatId;
            var csapat = (from x in context.Csapats
                          where x.CsapatId == valasztott
                          select x).FirstOrDefault();
            edzőTextBox.Text = csapat.EdzoNev;
            alakulásTextBox.Text = csapat.AlakulasiEv.ToString();
        }
    }
}
