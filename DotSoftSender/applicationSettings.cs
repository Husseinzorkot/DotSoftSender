using DotSoftSender.Properties;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Text;

namespace DotSoftSender
{
   public static class applicationSettings
    {
        public static string msgContent { get; set; } = Properties.Settings.Default.msg;
       
       public static string getMessage()
        { 
            return msgContent;
        }

        public static void SetMessage(string msg)
        {
            msgContent = msg;
            Properties.Settings.Default.msg = msgContent;
            Settings.Default.Save();
        }

        public static string uploadContent { get; set; } = Properties.Settings.Default.uploading;

        public static string getUploading()
        {
            
            return uploadContent;
        }

        public static void SetUploading(string uploading)
        {
            uploadContent = uploading;
            Properties.Settings.Default.uploading = uploadContent;
            Settings.Default.Save();

        }

        public static string addPhoneNumber { get; set; } = Properties.Settings.Default.addNb;

        public static string getPhoneNumber()
        {
            return addPhoneNumber;
        }

        public static void SetPhoneNb(string addNb)
        {
            addPhoneNumber = addNb;
            Properties.Settings.Default.addNb = addPhoneNumber;
            Settings.Default.Save();

        }

    }
}
