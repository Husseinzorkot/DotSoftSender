using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
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


        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            applicationSettings.SetMessage(textBox1.Text);
            applicationSettings.SetPhoneNb(textBox2.Text);
            applicationSettings.SetUploading(txtFile.Text);
            MessageBox.Show("Saved");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() != DialogResult.OK)
                return;

            txtFile.Text = open.FileName;


        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //private void cmbType_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (_loading || cmbType.SelectedItem is not string newType)
        //        return;

        //    _messages[_currentType] = textBox1.Text;
        //    showType(newType);
        //}
    }
}
