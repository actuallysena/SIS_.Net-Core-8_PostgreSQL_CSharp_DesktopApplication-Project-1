namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Sabit boyut ve boyutlandýrmayý engelleme
            this.Size = new System.Drawing.Size(1000, 500);
            //this.MinimizeBox = false;
            //this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
    }

}
