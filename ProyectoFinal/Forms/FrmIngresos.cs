using ProyectoFinal.UsersC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Forms
{
    public partial class FrmIngresos : Form
    {
        int month, year;
        public FrmIngresos()
        {
            InitializeComponent();
        }

        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            DisplaysDays();
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMotnh.Text = monthname + " " + year;
            lblMotnh.Text = monthname;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();


            month++;

            if (month > 12)
            {
                year++;
                month = 1;
            }

            DateTime now = DateTime.Now;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMotnh.Text = monthname + " " + year;
            //Lets get the first day of the month 

            DateTime startMonth = new DateTime(year, month, 1);

            // Get the count of days of the months

            int day = DateTime.DaysInMonth(year, month);

            // Convert the startofmonth 

            int dayofTheweek = int.Parse(startMonth.DayOfWeek.ToString("d"));

            // Firts lets creat a blank usercontrol 

            for (int i = 0; i < dayofTheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            //now lets create usercontrol of day

            for (int i = 1; i < day; i++)
            {
                UserControlDays userControl = new UserControlDays();

                userControl.days(i);

                daycontainer.Controls.Add(userControl);
            }
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();


            month--;
            if (month < 1)
            {
                year--;
                month = 12;
            }
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMotnh.Text = monthname + " " + year;

            DateTime now = DateTime.Now;

            //Lets get the first day of the month 

            DateTime startMonth = new DateTime(year, month, 1);

            // Get the count of days of the months

            int day = DateTime.DaysInMonth(year, month);

            // Convert the startofmonth 

            int dayofTheweek = int.Parse(startMonth.DayOfWeek.ToString("d"));

            // Firts lets creat a blank usercontrol 

            for (int i = 0; i < dayofTheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            //now lets create usercontrol of day

            for (int i = 1; i < day; i++)
            {
                UserControlDays userControl = new UserControlDays();

                userControl.days(i);

                daycontainer.Controls.Add(userControl);
            }
        }

        private void DisplaysDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;
            //Lets get the first day of the month 

            //String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            //lblMotnh.Text = monthname + " " + year;

            DateTime startMonth = new DateTime(year, month, 1);

            // Get the count of days of the months

            int day = DateTime.DaysInMonth(year, month);

            // Convert the startofmonth 

            int dayofTheweek = int.Parse(startMonth.DayOfWeek.ToString("d"));

            // Firts lets creat a blank usercontrol 

            for (int i = 0; i < dayofTheweek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
            }

            //now lets create usercontrol of day

            for (int i = 1; i < day; i++)
            {
                UserControlDays userControl = new UserControlDays();

                userControl.days(i);

                daycontainer.Controls.Add(userControl);
            }
        }
    }
}
