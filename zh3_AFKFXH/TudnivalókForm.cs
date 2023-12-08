using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh3_AFKFXH
{
    public partial class TudnivalókForm : Form
    {
        public TudnivalókForm()
        {
            InitializeComponent();

            MirőlTextBox.Text ="Kitalált csapatok, kitalált időpontokban, kitalált játékosokkal meccseket játszottak és ezen meccseket mutatja be az adatbázis.";
            TörténeteTextBox.Text = "Előző félévben adatbáziok tantárgy keretében beadandó feladat volt egy SQL adatbázis létrehozása és azon különböző feladatok végrehajtása. Gondoltam pont megfelelő alkalom lenne újra előszedni ezt az adatbázist és hasznossá tenni.";
        }
    }
}
