namespace screenSaver
{
    public partial class MainForm : Form
    {
        private Core core{ get; set; }

        public MainForm()
        {
            InitializeComponent();
            core = new Core(25);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            core.OffsetSnowflake();
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            core.ShowSnoflakes(e);
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            timer.Stop();
            Close();
        }
    }
}
