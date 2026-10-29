using DotSoftSender.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks.Dataflow;
namespace DotSoftSender
{
    public static class sender
    {
        public static void SendMsg(AppDbContext db)
        { 
            var messages = db.Tmessages.Where(e => !e.IsSent).ToList();

            foreach (var m in messages)
            {
                Thread.Sleep(5000);

                try
                {
                    var phone = getPhoneNb(m.To);

                    if (string.IsNullOrWhiteSpace(phone))
                        continue;

                    Exception sendError = null;


                    try
                    {
                        Thread.Sleep(4000);
                        //string whatsappLink = $"https://wa.me/{+96181955158}";
                        //string content = messageTemplate.Replace("{WhatsAppLink}", whatsappLink);
                        string message = applicationSettings.getMessage();
                        string mediaPath = applicationSettings.getUploading();
                        // A "." followed by a space (or at the end) starts a new line.
                        // Dots inside numbers or links (10.5, www.site.com) are kept.
                        var lines = Regex.Split(message, @"\.(?:\s+|$)")
                                           .Select(l => l.Trim())
                                           .Where(l => l.Length > 0);
                        message = string.Join("\n", lines);



                        bool hasMedia = !string.IsNullOrWhiteSpace(mediaPath) && File.Exists(mediaPath);

                        if (hasMedia)
                        {
                            string[] f = { mediaPath };

                            DataObject d = new DataObject(DataFormats.FileDrop, f);
                            Clipboard.SetDataObject(d, true);
                        }

                        WebBrowser web1 = new WebBrowser();
                     
                        //web1.Navigate("whatsapp://send?phone=" & phone & "&text" & message & "");
                        web1.Navigate($"whatsapp://send?phone={phone}&text={Uri.EscapeDataString(message)}");

                        Thread.Sleep(3000);
                        if (hasMedia)
                        {
                            SendKeys.Send("^v");
                            Thread.Sleep(4000);
                        }
                        SendKeys.Send("{ENTER}");                        
                                    }
                            catch (Exception ex)
                            {
                                sendError = ex;
                            }
                        
                    Thread.Sleep(4000);
                    

                    if (sendError != null)
                        throw new Exception(

                            $"Failed to send message to {phone}.",
                            sendError);

                    m.IsSent = true;
                    m.IsError = false;

                    db.SaveChanges();

                }
                catch (Exception ex)
                {

                    m.IsSent = false;
                    m.IsError = true;

                    db.SaveChanges();

                    throw new Exception(
                        $"Error processing message ID {m.IdDr}.", ex);
                }
            }
        }


        public static string getPhoneNb(string phoneNb) {
           
            
         string newPhoneNb  ;

            if (string.IsNullOrWhiteSpace(phoneNb))
                return "";
            phoneNb = phoneNb.Split(',','.','/') [0].Trim();
            

            


            newPhoneNb = phoneNb.Replace("/", "")
                                   .Replace(",", "")
                                   .Replace(".", "")
                                   .Replace("-", "");

            if (newPhoneNb.StartsWith("961"))
                newPhoneNb = newPhoneNb.Substring(3);

            if (newPhoneNb.StartsWith("07"))
                return "";

            if (newPhoneNb.StartsWith("05"))
                return "";

            if (newPhoneNb.StartsWith("01"))
                return "";

            if (newPhoneNb.StartsWith("0"))
                newPhoneNb = newPhoneNb.Substring(1);

            

            

                return newPhoneNb;
        }
    }
    }
