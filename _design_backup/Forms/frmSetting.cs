using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DotSoftSender.Forms
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void loadSettings()
        {
            textBox1.Text = applicationSettings.getMessage();
            txtFile.Text = applicationSettings.getUploading();
            textBox2.Text = applicationSettings.getPhoneNumber();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            applicationSettings.SetMessage(textBox1.Text);
            applicationSettings.SetPhoneNb(textBox2.Text);
            MessageBox.Show("Saved");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            applicationSettings.SetUploading(open.FileName);
            MessageBox.Show("Uploaded");


        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
