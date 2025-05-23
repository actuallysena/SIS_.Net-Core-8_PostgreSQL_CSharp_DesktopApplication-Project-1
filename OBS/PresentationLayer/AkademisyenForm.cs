using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AkademisyenForm : Form
    {
        public AkademisyenForm()
        {
            InitializeComponent();
        }
        private void AkademisyenForm_Load(object sender, EventArgs e)
        {
            // Sabit boyut ve boyutlandırmayı engelleme
            this.Size = new System.Drawing.Size(1000, 650);
            //this.MinimizeBox = false;
            //this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // Önce paneli temizle
            DersEkleUserControl dersControl = new DersEkleUserControl();
            dersControl.Dock = DockStyle.Fill; // Paneli tam kaplasın
            panelMain.Controls.Add(dersControl); // Panele ekle
        }

        private void notGirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // Önce paneli temizle
            NotGirmeUserControl notControl = new NotGirmeUserControl();
            notControl.Dock = DockStyle.Fill; // Paneli tam kaplasın
            panelMain.Controls.Add(notControl); // Panele ekle
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear(); // Önce paneli temizle
            OgrenciListeleUserControl ogrenciListele = new OgrenciListeleUserControl();
            ogrenciListele.Dock = DockStyle.Fill; // Paneli tam kaplasın
            panelMain.Controls.Add(ogrenciListele); // Panele ekle
        }
    }
}
