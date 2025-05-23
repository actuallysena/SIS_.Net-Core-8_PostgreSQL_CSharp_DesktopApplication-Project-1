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
    public partial class NotGirmeUserControl : UserControl
    {
        public NotGirmeUserControl()
        {
            InitializeComponent();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
                // Veriyi kaydetme işlemini burada yapın (örneğin veritabanına kaydetme)

                // Veri kaydedildikten sonra, textbox ve combobox içeriğini temizle
                ogrenciNoTextBox.Clear();  // Öğrenci ID'si TextBox'ı
                comboBox1.SelectedIndex = -1;  // Ders adı ComboBox'ı
                notTextBox.Clear();  // Not TextBox'ı
        }
    }
}
