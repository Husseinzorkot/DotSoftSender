using DotSoftSender.Data;
using DotSoftSender.Forms;

namespace DotSoftSender
{
    public partial class Form1 : Form
    {

        private readonly AppDbContext _db;
        public Form1(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CompanyName_Click(object sender, EventArgs e)
        {

        }

        private void AppSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSender s_ender = new frmSender(_db);
            s_ender.ShowDialog();
            s_ender.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
            setting.Dispose();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
