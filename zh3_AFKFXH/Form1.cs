using zh3_AFKFXH.Models;

namespace zh3_AFKFXH
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kilépés megerõsítése
            DialogResult result = MessageBox.Show("Biztosan kilép?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Kilépés
                e.Cancel = true;
            }
        }
        //Panelek (UserControllok)
        private void JátékosokButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Jatekosok_uc jatekosok_uc = new Jatekosok_uc();
            panel1.Controls.Add(jatekosok_uc);
            jatekosok_uc.Dock = DockStyle.Fill;
        }

        private void StadionokButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Stadionok_uc stadionok_uc = new Stadionok_uc();
            panel1.Controls.Add(stadionok_uc);
            stadionok_uc.Dock = DockStyle.Fill;
        }

        private void CsapatokButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Excel_uc csapatok_uc = new Excel_uc();
            panel1.Controls.Add(csapatok_uc);
            csapatok_uc.Dock = DockStyle.Fill;
        }

        //Formok
        private void TudnivalókButton_Click(object sender, EventArgs e)
        {
            TudnivalókForm tudnivalók_Form = new TudnivalókForm();
            tudnivalók_Form.ShowDialog();
        }

        private void DataGridViewButton_Click(object sender, EventArgs e)
        {
            DataGridViewForm dataGridViewForm = new DataGridViewForm();
            dataGridViewForm.ShowDialog();
        }
    }
}