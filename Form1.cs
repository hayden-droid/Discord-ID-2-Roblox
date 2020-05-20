using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;

namespace DiscordID2Roblox
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        string get(string uri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            } catch(Exception ex)
            {
                return "An unexpected error has occured: " +ex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string url = @"https://verify.eryn.io/api/user/" + Input.Text;
            dynamic data = JsonConvert.DeserializeObject(get(url));
            userId.Text = data.robloxId;
            userName.Text = data.robloxUsername;
            userPicture.Load("https://www.roblox.com/outfit-thumbnail/image?userOutfitId=" + data.robloxId + "&width=420&height=420&format=png");
        }
    }
}
