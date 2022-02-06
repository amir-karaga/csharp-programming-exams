using DLWMS.WinForms.DB;
using DLWMS.WinForms.P5;
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
    public partial class frmStudentiPredmetiIB190031 : Form
    {
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        public frmStudentiPredmetiIB190031()
        {
            InitializeComponent();
            dgvStudentiPredmeti.AutoGenerateColumns = false;
        }

        private void frmStudentiPredmetiIB190031_Load(object sender, EventArgs e)
        {
            UcitajPolozene();
        }

        private void UcitajPolozene(List<StudentiPredmeti> lista=null)
        {
            dgvStudentiPredmeti.DataSource = null;
            if (lista != null)
                dgvStudentiPredmeti.DataSource = lista;
            else
            dgvStudentiPredmeti.DataSource = baza.StudentiPredmeti.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filtriranje();
        }

        private void Filtriranje()
        {
            var listaStudentiPredmeti = baza.StudentiPredmeti.ToList().Where(s =>
              s.Predmet.Naziv.ToLower().Contains(txtPretraga.Text.ToLower())).ToList();
            UcitajPolozene(listaStudentiPredmeti);
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (ValidirajUnos())
                {
                    long brojOd = 0, brojDo = 0, suma = 0;

                    if (long.TryParse(txtOd.Text, out brojOd) && long.TryParse(txtDo.Text, out brojDo))
                    {
                        for (long i = brojOd; i <= brojDo; i++)
                        {
                            suma += i;
                        }
                        txtSuma.Text = suma.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vrijendosti unosa moraju biti brojevi");
                       
                    }
                    txtDo.Text = "";
                    txtOd.Text = "";
                }
            });
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtOd, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtDo, err, Poruke.ObaveznaVrijednost);
        }

        private void dgvStudentiPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var zapis = dgvStudentiPredmeti.SelectedRows[0].DataBoundItem as StudentiPredmeti;
            if(e.ColumnIndex==4)
            {
                if (MessageBox.Show("Da li želite obrisati zapis",Poruke.Pitanje,
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                {
                    baza.StudentiPredmeti.Remove(zapis);
                    baza.SaveChanges();
                    MessageBox.Show("Uspješno obrisan zapis");
                    UcitajPolozene();
                }   
            }
            else if(e.ColumnIndex==5)
            {
                frmStudentiSlike studentiSlike = new frmStudentiSlike(zapis.Student);
                studentiSlike.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var lista = dgvStudentiPredmeti.DataSource as List<StudentiPredmeti>;

            frmIzvjestaj frmIzvjestaj = new frmIzvjestaj(lista);
            frmIzvjestaj.ShowDialog();
        }
    }
}
