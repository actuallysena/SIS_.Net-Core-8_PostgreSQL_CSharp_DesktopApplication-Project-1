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
    public partial class YonetimForm : Form
    {
        public YonetimForm()
        {
            InitializeComponent();
        }

        private void YonetimForm_Load(object sender, EventArgs e)
        {
            // Sabit boyut ve boyutlandırmayı engelleme
            this.Size = new System.Drawing.Size(1000, 650);
            //this.MinimizeBox = false;
            //this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
    }
}
