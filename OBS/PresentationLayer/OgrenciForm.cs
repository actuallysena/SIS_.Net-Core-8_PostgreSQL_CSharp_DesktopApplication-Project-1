namespace PresentationLayer
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }
        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            // Sabit boyut ve boyutlandýrmayý engelleme
            this.Size = new System.Drawing.Size(1000, 500);
            //this.MinimizeBox = false;
            //this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
    }

}
