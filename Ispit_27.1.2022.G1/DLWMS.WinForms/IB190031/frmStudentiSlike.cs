using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
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
    public partial class frmStudentiSlike : Form
    {
        Student student;
        KonekcijaNaBazu baza = DLWMSdb.Baza;
        List<StudentiSlike> Slike = new List<StudentiSlike>();
        int brojac = 0;
        public frmStudentiSlike(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmStudentiSlike_Load(object sender, EventArgs e)
        {
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            Slike = student.SlikeStudenta.ToList();
            if(Slike.Count()>0)
            UcitajSliku();
           
        }

        private void UcitajSliku()
        {
            pbSlikaPregled.Image = ImageHelper.FromByteToImage(Slike[brojac].Slika);
            txtOpisPregled.Text = Slike[brojac].Opis;
            lblDatumSlikePregled.Text = Slike[brojac].DatumDodavanja;
            lblBrojSlike.Text = "Slika "+(brojac+1).ToString() + "/" + Slike.Count().ToString();
            
        }

        private void btnDesno_Click(object sender, EventArgs e)
        {
            if (brojac + 1 < Slike.Count())
            {
                brojac++;
                UcitajSliku();
            }
            else
            {
                MessageBox.Show("Ovo je posljednja slika");
            }
        }

        private void btnLijevo_Click(object sender, EventArgs e)
        {
            if (brojac - 1 >= 0)
            {
                brojac--;
                UcitajSliku();
            }
            else
            {
                MessageBox.Show("Ovo je prva slika");
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos())
            {
                StudentiSlike novaSlika = new StudentiSlike
                {
                    Student=student,
                    DatumDodavanja=DateTime.Now.ToString("dd.MM.yyyy"),
                    Slika=ImageHelper.FromImageToByte(pbSlikaDodaj.Image),
                    Opis=txtOpisDodaj.Text
                };
                student.SlikeStudenta.Add(novaSlika);
                baza.SaveChanges();
                MessageBox.Show("Slika uspješno dodana");
                ObrisiFormu();
                UcitajSlike();
            }
        }

        private void ObrisiFormu()
        {
            pbSlikaDodaj.Image = null;
            txtOpisDodaj.Text = "";
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(pbSlikaDodaj, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtOpisDodaj, err, Poruke.ObaveznaVrijednost);
        }

        private void pbSlikaDodaj_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                pbSlikaDodaj.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
