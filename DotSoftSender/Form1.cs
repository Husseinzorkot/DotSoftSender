using DotSoftSender.Data;
using DotSoftSender.Forms;
using Microsoft.EntityFrameworkCore;

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
        private async Task getDoctorsCount()
        {
            var count = await _db.CleanData.CountAsync();
            label5.Text = count.ToString();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            await loadStats();
            
        }

        private async Task loadStats()
        {
            try
            {
                label5.Text = (await _db.CleanData.CountAsync()).ToString("N0");
                label6.Text = (await _db.Tmessages.CountAsync(m => m.IsSent)).ToString("N0");
                label7.Text = (await _db.Tmessages.CountAsync(m => !m.IsSent && !m.IsError)).ToString("N0");
            }
            catch (Exception)
            {
                label5.Text = label6.Text = label7.Text = "—";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            frmSender s_ender = new frmSender(_db);
            s_ender.ShowDialog();
            s_ender.Dispose();
            await loadStats();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
            setting.Dispose();
        }

        private void totalReciptients_Paint(object s_ender, PaintEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
