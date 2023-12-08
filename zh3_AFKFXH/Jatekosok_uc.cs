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
