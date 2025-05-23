using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace PresentationLayer
{
    partial class AkademisyenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AkademisyenForm));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            asd = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            GenelMenu = new ToolStripMenuItem();
            DersMenu = new ToolStripMenuItem();
            BasvuruMenu = new ToolStripMenuItem();
            KullaniciMenu = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            dersIslemleri = new ToolStripMenuItem();
            dersEkleToolStripMenuItem = new ToolStripMenuItem();
            dersSilGüncelleToolStripMenuItem = new ToolStripMenuItem();
            dersListesiniGörToolStripMenuItem = new ToolStripMenuItem();
            ogrenciIslemleri = new ToolStripMenuItem();
            derseÖğrenciAtamaToolStripMenuItem = new ToolStripMenuItem();
            öğrencininAldığıDerslerToolStripMenuItem = new ToolStripMenuItem();
            notIslemleri = new ToolStripMenuItem();
            notGirmeToolStripMenuItem = new ToolStripMenuItem();
            notGüncellemeToolStripMenuItem = new ToolStripMenuItem();
            notListesiniGörToolStripMenuItem = new ToolStripMenuItem();
            raporlar = new ToolStripMenuItem();
            dersinÖğrenciListesToolStripMenuItem = new ToolStripMenuItem();
            başarısızÖğrencilerToolStripMenuItem = new ToolStripMenuItem();
            öğrenciListesiToolStripMenuItem = new ToolStripMenuItem();
            diger = new ToolStripMenuItem();
            şifreDeğiştirToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)asd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 28);
            label1.Name = "label1";
            label1.Size = new Size(506, 34);
            label1.TabIndex = 1;
            label1.Text = "AKADEMİSYEN BİLGİ SİSTEMİ ";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(816, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // asd
            // 
            asd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            asd.Image = (Image)resources.GetObject("asd.Image");
            asd.Location = new Point(898, 4);
            asd.Name = "asd";
            asd.Size = new Size(70, 66);
            asd.SizeMode = PictureBoxSizeMode.Zoom;
            asd.TabIndex = 3;
            asd.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(133, 20);
            label2.Name = "label2";
            label2.Size = new Size(125, 50);
            label2.TabIndex = 8;
            label2.Text = " KARTOPU \r\nÜNİVERSİTESİ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // GenelMenu
            // 
            GenelMenu.Name = "GenelMenu";
            GenelMenu.Size = new Size(32, 19);
            // 
            // DersMenu
            // 
            DersMenu.Name = "DersMenu";
            DersMenu.Size = new Size(32, 19);
            // 
            // BasvuruMenu
            // 
            BasvuruMenu.Name = "BasvuruMenu";
            BasvuruMenu.Size = new Size(32, 19);
            // 
            // KullaniciMenu
            // 
            KullaniciMenu.Name = "KullaniciMenu";
            KullaniciMenu.Size = new Size(32, 19);
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dersIslemleri, ogrenciIslemleri, notIslemleri, raporlar, diger });
            menuStrip1.Location = new Point(194, 107);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(504, 28);
            menuStrip1.TabIndex = 0;
            // 
            // dersIslemleri
            // 
            dersIslemleri.CheckOnClick = true;
            dersIslemleri.DropDownItems.AddRange(new ToolStripItem[] { dersEkleToolStripMenuItem, dersSilGüncelleToolStripMenuItem, dersListesiniGörToolStripMenuItem });
            dersIslemleri.Name = "dersIslemleri";
            dersIslemleri.Size = new Size(113, 24);
            dersIslemleri.Text = "Ders İşlemleri";
            // 
            // dersEkleToolStripMenuItem
            // 
            dersEkleToolStripMenuItem.Name = "dersEkleToolStripMenuItem";
            dersEkleToolStripMenuItem.Size = new Size(224, 26);
            dersEkleToolStripMenuItem.Text = "Ders Ekle";
            dersEkleToolStripMenuItem.Click += dersEkleToolStripMenuItem_Click;
            // 
            // dersSilGüncelleToolStripMenuItem
            // 
            dersSilGüncelleToolStripMenuItem.Name = "dersSilGüncelleToolStripMenuItem";
            dersSilGüncelleToolStripMenuItem.Size = new Size(224, 26);
            dersSilGüncelleToolStripMenuItem.Text = "Ders Sil/ Güncelle";
            // 
            // dersListesiniGörToolStripMenuItem
            // 
            dersListesiniGörToolStripMenuItem.Name = "dersListesiniGörToolStripMenuItem";
            dersListesiniGörToolStripMenuItem.Size = new Size(224, 26);
            dersListesiniGörToolStripMenuItem.Text = "Ders Listesini Gör";
            // 
            // ogrenciIslemleri
            // 
            ogrenciIslemleri.DropDownItems.AddRange(new ToolStripItem[] { derseÖğrenciAtamaToolStripMenuItem, öğrencininAldığıDerslerToolStripMenuItem });
            ogrenciIslemleri.Name = "ogrenciIslemleri";
            ogrenciIslemleri.Size = new Size(135, 24);
            ogrenciIslemleri.Text = "Öğrenci İşlemleri";
            // 
            // derseÖğrenciAtamaToolStripMenuItem
            // 
            derseÖğrenciAtamaToolStripMenuItem.Name = "derseÖğrenciAtamaToolStripMenuItem";
            derseÖğrenciAtamaToolStripMenuItem.Size = new Size(259, 26);
            derseÖğrenciAtamaToolStripMenuItem.Text = "Derse Öğrenci Atama ";
            // 
            // öğrencininAldığıDerslerToolStripMenuItem
            // 
            öğrencininAldığıDerslerToolStripMenuItem.Name = "öğrencininAldığıDerslerToolStripMenuItem";
            öğrencininAldığıDerslerToolStripMenuItem.Size = new Size(259, 26);
            öğrencininAldığıDerslerToolStripMenuItem.Text = "Öğrencinin Aldığı Dersler";
            // 
            // notIslemleri
            // 
            notIslemleri.DropDownItems.AddRange(new ToolStripItem[] { notGirmeToolStripMenuItem, notGüncellemeToolStripMenuItem, notListesiniGörToolStripMenuItem });
            notIslemleri.Name = "notIslemleri";
            notIslemleri.Size = new Size(108, 24);
            notIslemleri.Text = "Not İşlemleri";
            // 
            // notGirmeToolStripMenuItem
            // 
            notGirmeToolStripMenuItem.Name = "notGirmeToolStripMenuItem";
            notGirmeToolStripMenuItem.Size = new Size(224, 26);
            notGirmeToolStripMenuItem.Text = "Not Girme";
            notGirmeToolStripMenuItem.Click += notGirmeToolStripMenuItem_Click;
            // 
            // notGüncellemeToolStripMenuItem
            // 
            notGüncellemeToolStripMenuItem.Name = "notGüncellemeToolStripMenuItem";
            notGüncellemeToolStripMenuItem.Size = new Size(224, 26);
            notGüncellemeToolStripMenuItem.Text = "Not Güncelleme";
            // 
            // notListesiniGörToolStripMenuItem
            // 
            notListesiniGörToolStripMenuItem.Name = "notListesiniGörToolStripMenuItem";
            notListesiniGörToolStripMenuItem.Size = new Size(224, 26);
            notListesiniGörToolStripMenuItem.Text = "Not Listesini Gör";
            // 
            // raporlar
            // 
            raporlar.DropDownItems.AddRange(new ToolStripItem[] { dersinÖğrenciListesToolStripMenuItem, başarısızÖğrencilerToolStripMenuItem, öğrenciListesiToolStripMenuItem });
            raporlar.Name = "raporlar";
            raporlar.Size = new Size(80, 24);
            raporlar.Text = "Raporlar";
            // 
            // dersinÖğrenciListesToolStripMenuItem
            // 
            dersinÖğrenciListesToolStripMenuItem.Name = "dersinÖğrenciListesToolStripMenuItem";
            dersinÖğrenciListesToolStripMenuItem.Size = new Size(234, 26);
            dersinÖğrenciListesToolStripMenuItem.Text = "Dersin Öğrenci Listesi";
            // 
            // başarısızÖğrencilerToolStripMenuItem
            // 
            başarısızÖğrencilerToolStripMenuItem.Name = "başarısızÖğrencilerToolStripMenuItem";
            başarısızÖğrencilerToolStripMenuItem.Size = new Size(234, 26);
            başarısızÖğrencilerToolStripMenuItem.Text = "Başarısız Öğrenciler";
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            öğrenciListesiToolStripMenuItem.Size = new Size(234, 26);
            öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            öğrenciListesiToolStripMenuItem.Click += öğrenciListesiToolStripMenuItem_Click;
            // 
            // diger
            // 
            diger.DropDownItems.AddRange(new ToolStripItem[] { şifreDeğiştirToolStripMenuItem });
            diger.Name = "diger";
            diger.Size = new Size(60, 24);
            diger.Text = "Diğer";
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            şifreDeğiştirToolStripMenuItem.Size = new Size(224, 26);
            şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.Location = new Point(147, 154);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(675, 396);
            panelMain.TabIndex = 11;
            // 
            // AkademisyenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 603);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(asd);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Name = "AkademisyenForm";
            Text = "Danışman Ekranı";
            Load += AkademisyenForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)asd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox asd;
        private Label label2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem GenelMenu;
        private ToolStripMenuItem DersMenu;
        private ToolStripMenuItem BasvuruMenu;
        private ToolStripMenuItem KullaniciMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dersIslemleri;
        private ToolStripMenuItem ogrenciIslemleri;
        private ToolStripMenuItem notIslemleri;
        private ToolStripMenuItem raporlar;
        private ToolStripMenuItem diger;
        private Panel panelMain;
        private ToolStripMenuItem dersEkleToolStripMenuItem;
        private ToolStripMenuItem dersSilGüncelleToolStripMenuItem;
        private ToolStripMenuItem dersListesiniGörToolStripMenuItem;
        private ToolStripMenuItem derseÖğrenciAtamaToolStripMenuItem;
        private ToolStripMenuItem öğrencininAldığıDerslerToolStripMenuItem;
        private ToolStripMenuItem notGirmeToolStripMenuItem;
        private ToolStripMenuItem notGüncellemeToolStripMenuItem;
        private ToolStripMenuItem notListesiniGörToolStripMenuItem;
        private ToolStripMenuItem dersinÖğrenciListesToolStripMenuItem;
        private ToolStripMenuItem başarısızÖğrencilerToolStripMenuItem;
        private ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private ToolStripMenuItem öğrenciListesiToolStripMenuItem;
    }
}