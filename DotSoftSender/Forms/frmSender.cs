using DotSoftSender.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Security.Cryptography;
using System.Windows.Forms.VisualStyles;

namespace DotSoftSender.Forms
{
    public partial class frmSender : Form
    {

        private readonly AppDbContext _db;
        private List<CleanDatum> doctors = new List<CleanDatum>();
        private List<Tmessage> messages = new List<Tmessage>();
        public frmSender(AppDbContext db)
        {
            InitializeComponent();
            _db = db;
            
            UI.Theme.StyleGrid(dataGridView1);
            UI.Theme.StyleGrid(dataGridView2);
            dataGridView1.DataBindingComplete += (s, e) => loadSending();
        }

        private void tblSender_Paint(object sender, PaintEventArgs e)
        {

        }
        private async Task getDoctors()
        {
            var mainData = await _db.CleanData.ToListAsync();


            cleanDatumBindingSource.DataSource = mainData;
        }

        private async Task getFromCleanData()
        {
            var tester = await _db.Tmessages.ToListAsync();
            tmessageBindingSource.DataSource = tester;
        }



        private async void frmSender_Load(object sender, EventArgs e)
        {

            await getDoctors();
            await getData();
            loadSending();
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
                        setRowSelected(dataGridView1.Rows[e.RowIndex], false);
                    }
                    else
                    {
                        doctors.Add(current);
                        setRowSelected(dataGridView1.Rows[e.RowIndex], true);
                    }

                }


            }

        }

        private void setRowSelected(DataGridViewRow row, bool selected)
        {
            var rowStyle = row.DefaultCellStyle;
            rowStyle.BackColor = selected ? UI.Theme.PrimarySoft : Color.Empty;
            rowStyle.SelectionBackColor = selected ? UI.Theme.PrimarySoft : Color.Empty;

            var selectStyle = row.Cells[colSelect.Index].Style;
            selectStyle.BackColor = selected ? UI.Theme.Primary : Color.Empty;
            selectStyle.SelectionBackColor = selected ? UI.Theme.Primary : Color.Empty;
            selectStyle.ForeColor = selected ? Color.White : Color.Empty;
            selectStyle.SelectionForeColor = selected ? Color.White : Color.Empty;

            lblSelected.Text = doctors.Count == 1 ? "1 recipient selected" : $"{doctors.Count:N0} recipients selected";


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
                        FilePath = applicationSettings.getUploading(),
                        RequestNb = "",
                        DoctorId = data.IdDoctor,



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
            loadSending();
        }

        private async Task getNotSent()
        {
            List<Tmessage> notSent = await _db.Tmessages.Where(e => !e.IsSent || e.IsError).ToListAsync();
            tmessageBindingSource.DataSource = notSent;
            
            
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Tmessage selected = new Tmessage();


        }

        private async void btntest_Click(object se_nder, EventArgs e)
        {
            await getDoctors();
            await getData();
            await getFromCleanData();
            //await getNotSent();
            loadSending();
            

        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.AliceBlue;
                await getNotSent();
            }
            else
            {
                checkBox1.BackColor= Color.White;
                getData();
            }
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private async void modernButton1_Click(object s_ender, EventArgs e)
        {
            List<Tmessage> notSent = await _db.Tmessages.Where(e => e.IsError).ToListAsync();

            foreach (Tmessage tmessage in notSent)
            {
                tmessage.IsError = false;
                sender.SendMsg(_db);
            }
        }

        List<int> ids;
        List<CleanDatum> dataSend;
        private async void loadSending()
        {
            ids = (from Tmessage aj in tmessageBindingSource where aj.DoctorId != null select aj.DoctorId.Value).ToList();
             dataSend = (from CleanDatum aj in cleanDatumBindingSource where ids.Contains(aj.IdDoctor.Value) select aj).ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex <= 0) { return; }
            if (cleanDatumBindingSource.Count <= 0) { return ; }


            CleanDatum current = (CleanDatum)cleanDatumBindingSource[e.RowIndex];

            if (this.dataSend.Contains(current))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            


        }
    }

}
