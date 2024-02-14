using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            string api = "c6642999f55eede49c0b5135b1696572";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var ruzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var durum = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            label4.Text = sicaklik.ToString();
            label14.Text = sicaklik.ToString();
            label7.Text = ruzgar + "m/s";
            label9.Text = nem + " % ";
            label10.Text = durum;
            //durum= "bulutlu";

            if (durum == "açık")
            {
                pictureBox1.ImageLocation = @"C:\Users\HP\Desktop\güneş.webp";
            }
            if (durum == "bulutlu")
            {
                pictureBox1.ImageLocation = @"C:\Users\HP\Desktop\bulut.jpg";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
