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
    public partial class Csapatok_uc : UserControl
    {
        Zh3Context context = new Zh3Context();
        public Csapatok_uc()
        {
            InitializeComponent();
        }
    }
}
