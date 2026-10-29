
using DotSoftSender.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Windows.Forms.VisualStyles;

namespace DotSoftSender.Forms
{
    public partial class frmSender : Form
    {
        private readonly AppDbContext _db;
        private List<CleanDatum> doctors = new List<CleanDatum>();

        public frmSender(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
        }
        private void tblSender_Paint(object sender, PaintEventArgs e)
        {

        }
        private async Task getDoctors()
        {
            var mainData = await _db.CleanData.ToListAsync();


            cleanDatumBindingSource.DataSource = mainData;
        }

        private async void frmSender_Load(object sender, EventArgs e)
        {

            await getDoctors();
            await getData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex <= 0)
            {

            }
            else
            {

                if (e.ColumnIndex == colSelect.Index)
                {
                    CleanDatum current = new CleanDatum();

                    current = (CleanDatum)cleanDatumBindingSource.Current;


                    if (this.doctors.Contains(current))
                    {
                        doctors.Remove(current);
                        dataGridView1.Rows[e.RowIndex].Cells[colSelect.Index].Style.BackColor = Color.White;
                    }
                    else
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[colSelect.Index].Style.BackColor = Color.Orange;

                        doctors.Add(current);
                    }

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object s_ender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSend_Click(object s_ender, EventArgs e)
        {

            List<Tmessage> m = new List<Tmessage>();

            try
            {
                foreach (CleanDatum data in doctors)
                {


                    m.Add(new Tmessage
                    {
                        DrName = data.DrNameEn,
                        IsError = false,
                        IsSent = false,
                        Status = "",
                        To = data.MobileNumbers,
                        From = applicationSettings.addPhoneNumber,
                        ErrorMsg = "",
                        MsgTypeId = 1,
                        FilePath = applicationSettings.uploadContent,
                        RequestNb = "",



                    });


                    //var newMess = new Tmessage();
                    //newMess.DrName = data.DrNameEn;

                    //messages.Add(newMess);

                }
            }
            catch (Exception)
            {

                throw;
            }

            _db.AddRange(m);
            _db.SaveChanges();

            await getData();
            Thread.Sleep(5000);
            sender.SendMsg(_db);

        }

        private async Task getData()
        {
            var LData = await _db.Tmessages.ToListAsync();


            tmessageBindingSource.DataSource = LData;
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tmessage selected = new Tmessage();


        }

        private void  btntest_Click(object se_nder, EventArgs e)
        {
            getDoctors();
            getData();
        }
    }
    
}
