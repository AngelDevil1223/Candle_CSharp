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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

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
            label105.Text = datee.ToString("d", cultureJewish);
            //label105.text = datee.ToString();
            // write as current culture date

            string json = new StreamReader(JsonFilePath).ReadToEnd();

            json = json.Replace("\"privet name\"", "\"privetname\"");
            json = json.Replace("\"family name\"", "\"familyname\"");
            json = json.Replace("\"jewish date\"", "\"jewishdate\"");
            json = json.Replace("\"Column1\"", "\"id\"");
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Person> persons = serializer.Deserialize<List<Person>>(json).OrderBy(c => c.id).ToList();
            DateTime now = DateTime.Now;
          //  string dateee = now.GetDateTimeFormats('d')[0];

            //string today = DateTime.Now.ToString("d.M.", cultureJewish);
            string today = DateTime.Now.ToString("M d", cultureJewish);
           // string today2 = DateTime.Now.ToString("M", cultureJewish);
          //  today = today + today2;

           // List<Person> filtered_persons = persons.Where(x => x.date.StartsWith(today)).ToList();
            List<Person> filtered_persons = persons.Where(x => x.jewishdate.StartsWith(today)).ToList();
            if (filtered_persons.Count > 0)
            {
                String pvtname = filtered_persons[0].privetname.ToString();
                String fmname = filtered_persons[0].familyname.ToString();
                //  label104.Text = filtered_persons[0].privetname.ToString();
                label104.Text = pvtname + " " + fmname;
            }
            else
            {
                label104.Text = "";
            }



            int a = filtered_persons.Count;
            a += 1;
            a += 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label164_Click(object sender, EventArgs e)
        {

        }
    }
}
