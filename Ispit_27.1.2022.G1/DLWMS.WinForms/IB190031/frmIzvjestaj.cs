using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB190031
{
    public partial class frmIzvjestaj : Form
    {
        List<StudentiPredmeti> lista;
        public frmIzvjestaj(List<StudentiPredmeti> lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            var rds = new ReportDataSource();
            List<object> listaPolozeni = new List<object>();  
            int brojac = 1;
            foreach (var polozeni in lista)
            {
                listaPolozeni.Add(new
                {
                    Rb = brojac++,
                    Student = polozeni.Student.ToString(),
                    Predmet = polozeni.Predmet.ToString(),
                    DatumPolaganja = polozeni.DatumPolaganja,
                    Ocjena = polozeni.Ocjena,

                });
            }

            rpc.Add(new ReportParameter("ProsjekOcjena","Prosječna ocjena : "+ lista.Average(sp=>sp.Ocjena).ToString("0.00")));
            rds.Name = "dsPolozeni";
            rds.Value = listaPolozeni;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
