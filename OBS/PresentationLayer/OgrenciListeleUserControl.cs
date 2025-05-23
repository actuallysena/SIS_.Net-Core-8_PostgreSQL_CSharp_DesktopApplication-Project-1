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
    public partial class OgrenciListeleUserControl : UserControl
    {
        public OgrenciListeleUserControl()
        {
            InitializeComponent();
        }

        private void sorgulaButton_Click(object sender, EventArgs e)
        {
            //sorgulama işlemi için 

            sınıfComboBox.SelectedIndex = -1;
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();

        }
    }
}
