using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_AFKFXH.Models;
//Hozzáadni usingokat
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace zh3_AFKFXH
{
    public partial class Excel_uc : UserControl
    {
        Zh3Context context = new Zh3Context();
        Excel.Application xlApp; // Az Excel alkalmazás
        Excel.Workbook xlWB;     // A munkafüzet
        Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül
        public Excel_uc()
        {
            InitializeComponent();
            richTextBox1.Text = "Itt készíthetsz excel táblázatot az adatokból, valamint diagramot a szemléletesség kedvéért!";
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                TáblaKészítés();

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
        private void TáblaKészítés()
        {
            string[] fejlécek = new string[]
            {
                "JátékosId",
                "Név",
                "SzületésiDátum",
                "Poszt",
                "Mezszám",
                "CsapatId",
            };
            for (int i = 0; i < fejlécek.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = fejlécek[i];
            }

            var adatok = context.Jatekos.ToList();

            object[,] adatTömb = new object[adatok.Count(), fejlécek.Count()];
            for (int i = 0; i < adatok.Count(); i++)
            {
                adatTömb[i, 0] = adatok[i].JatekosId;
                adatTömb[i, 1] = adatok[i].Nev;
                adatTömb[i, 2] = adatok[i].SzuletesiDatum;
                adatTömb[i, 3] = adatok[i].Poszt;
                adatTömb[i, 4] = adatok[i].Mezszam;
                adatTömb[i, 5] = adatok[i].CsapatId;

            }
            int sorokSzáma = adatTömb.GetLength(0);
            int oszlopokSzáma = adatTömb.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
            adatRange.Value2 = adatTömb;
            adatRange.Columns.AutoFit();

            Excel.Range fejlécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 6);
            fejlécRange.Font.Bold = true;
            //fejlécRange.Columns.AutoFit();

        }

        private void diagramButton_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();
            excelApp.Visible = true;

            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

        
            var csapatok = from x in context.Csapats
                           select x.Nev;

            var alapítások = from x in context.Csapats
                           select x.AlakulasiEv;

            worksheet.Cells[1, "A"] = "Csapat neve";
            worksheet.Cells[1, "B"] = "Alapulás éve";
            for (int i = 0; i <  csapatok.ToList().Count; i++)
            {
                worksheet.Cells[i + 2, "A"] = csapatok.ToList()[i];
                worksheet.Cells[i + 2, "B"] = alapítások.ToList()[i];
            }

            //Adatok kijelölése
            Excel.Range chartRange = worksheet.get_Range("A1", "B9");


            Excel.ChartObjects xlCharts = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = xlCharts.Add(10, 150, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            //Forrás megadása
            chartPage.SetSourceData(chartRange);

            // Diagram beállítások
            chartPage.ChartType = Excel.XlChartType.xlLine;
            chartPage.ChartWizard(Source: chartRange,
                Title: "Csapatok alapításai",
                CategoryTitle: "Csapatok",
                ValueTitle: "Évek");

            // Mentés és kilépés
            //workbook.SaveAs(@"C:\YourPath\ExcelChartExample.xlsx");
            //excelApp.Quit();
        }
    }
}
