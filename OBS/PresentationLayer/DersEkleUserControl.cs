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
    public partial class DersEkleUserControl : UserControl
    {
        public DersEkleUserControl()
        {
            InitializeComponent();
        }

        private void kaydetbutton_Click(object sender, EventArgs e)
        { 
            // Veriyi kaydetme işlemini burada yapın (örneğin veritabanına kaydetme)

            // Veri kaydedildikten sonra, textbox ve combobox içeriğini temizle
            dersKoduTextBox.Clear();
            dersAdıtextBox.Clear(); 
            derslikTextBox.Clear();
            kontenjanTextBox.Clear();
            ogretimElemaniTextBox.Clear();            
        }
    }
}
