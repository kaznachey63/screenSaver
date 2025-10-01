namespace screenSaver
{
    public partial class MainForm : Form
    {
        private Core? core{ get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            core = new Core(25);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            core?.offsetSnowflake();
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            core?.showSnoflakes(e);
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer.Stop();
            Close();
        }
    }
}
