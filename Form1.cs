using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace CandelWork
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();

            //string JsonFilePath = @"רשימת חללים ותאריך נפילה עברי.json";
            string JsonFilePath = @"abc.json";

            CultureInfo cultureJewish = CultureInfo.CreateSpecificCulture("he-IL");

            cultureJewish.DateTimeFormat.Calendar = new HebrewCalendar();

            DateTime Today = DateTime.Today;

            Calendar HebCal = new HebrewCalendar();
             
            int curYear = HebCal.GetYear(Today);    //current numeric hebrew year
            int curMonth = HebCal.GetMonth(Today);  //current numeric hebrew month
            int curDay = HebCal.GetDayOfMonth(Today);

            // create a hebrew date
            DateTime dtAnyDateHebrew = new DateTime(curYear, curMonth, curDay, new System.Globalization.HebrewCalendar());
            // write as hebrew date
            var datee = dtAnyDateHebrew;
            label105.Text = datee.ToString("d.M.yyyy", cultureJewish);
            //label105.text = datee.ToString();
            // write as current culture date

            string json = new StreamReader(JsonFilePath).ReadToEnd();

            json = json.Replace("\"privet name\"", "\"privetname\"");
            json = json.Replace("\"family name\"", "\"familyname\"");
            json = json.Replace("\"Column1\"", "\"id\"");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Person> persons = serializer.Deserialize<List<Person>>(json).OrderBy(x => x.id).ToList();
            DateTime now = DateTime.Now;
            string dateee = now.GetDateTimeFormats('d')[0];
          
            string today = DateTime.Now.ToString("d.M.");

            List<Person> filtered_persons = persons.Where(x => x.date.StartsWith(today)).ToList();

            if (filtered_persons.Count > 0)
            {
                String pvtname = filtered_persons[0].privetname.ToString();
                String fmname = filtered_persons[0].familyname.ToString();
              //  label104.Text = filtered_persons[0].privetname.ToString();
                label104.Text = pvtname + " " + fmname;
            }
            else {
                label104.Text = "";              
            }

     

            int a = filtered_persons.Count;
            a += 1;
            a += 2;
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void getCurrentName() 
        { 
        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bounds= Screen.FromControl(this).Bounds;
            Width = bounds.Width;
            Height = bounds.Height;
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void label128_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label126_Click(object sender, EventArgs e)
        {

        }

        private void label133_Click(object sender, EventArgs e)
        {

        }

        private void label155_Click(object sender, EventArgs e)
        {

        }

        private void label150_Click(object sender, EventArgs e)
        {

        }

        private void label154_Click(object sender, EventArgs e)
        {

        }

        private void label153_Click(object sender, EventArgs e)
        {

        }

        private void label152_Click(object sender, EventArgs e)
        {

        }

        private void label151_Click(object sender, EventArgs e)
        {

        }

        private void label149_Click(object sender, EventArgs e)
        {

        }

        private void label148_Click(object sender, EventArgs e)
        {

        }

        private void label147_Click(object sender, EventArgs e)
        {

        }

        private void label146_Click(object sender, EventArgs e)
        {

        }

        private void label145_Click(object sender, EventArgs e)
        {

        }

        private void label144_Click(object sender, EventArgs e)
        {

        }

        private void label143_Click(object sender, EventArgs e)
        {

        }

        private void label142_Click(object sender, EventArgs e)
        {

        }

        private void label140_Click(object sender, EventArgs e)
        {

        }

        private void label159_Click(object sender, EventArgs e)
        {

        }

        private void label175_Click(object sender, EventArgs e)
        {

        }

        private void label174_Click(object sender, EventArgs e)
        {

        }

        private void label173_Click(object sender, EventArgs e)
        {

        }

        private void label172_Click(object sender, EventArgs e)
        {

        }

        private void label176_Click(object sender, EventArgs e)
        {

        }

        private void label197_Click(object sender, EventArgs e)
        {

        }

        private void label196_Click(object sender, EventArgs e)
        {

        }

        private void label205_Click(object sender, EventArgs e)
        {

        }

        private void label203_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox169_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox191_Click(object sender, EventArgs e)
        {

        }


        }
   
    
}

       
    
