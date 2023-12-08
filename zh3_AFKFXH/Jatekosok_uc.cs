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
    public partial class Jatekosok_uc : UserControl
    {
        Zh3Context context = new Zh3Context();
        public Jatekosok_uc()
        {
            InitializeComponent();

            Játékosok();
            JatekosokListBox.DisplayMember = "nev";
        }

        private void JatekosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Infok();
        }

        private void Infok()
        {
            //itt lehet saját class + pontért, de nem értem miért lenne értelme listboxban egy érték megjelenítésére egy(esetleg lehet a játékos kora)
            var jatekos = ((Jateko)JatekosokListBox.SelectedItem).JatekosId;
            var szül = (from x in context.Jatekos
                        where x.JatekosId == jatekos
                        select x.SzuletesiDatum).FirstOrDefault();
            var mez = (from x in context.Jatekos
                       where x.JatekosId == jatekos
                       select x.Mezszam).FirstOrDefault();
            var poszt = (from x in context.Jatekos
                         where x.JatekosId == jatekos
                         select x.Poszt).FirstOrDefault();

            születésidátumTextBox.Text = szül.ToString();
            mezTextBox.Text = mez.ToString();
            posztTextBox.Text = poszt.ToString();
        }

        private void JatekosokTextBox_TextChanged(object sender, EventArgs e)
        {
            Játékosok();
        }

        private void Játékosok()
        {
            var jatekosok = from x in context.Jatekos
                            where x.Nev.StartsWith(JatekosokTextBox.Text)
                            select x;

            JatekosokListBox.DataSource = jatekosok.ToList();
        }
    }
}
