using FinalProjectBaraclan.Models;
using FinalProjectBaraclan.Ucrls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FinalProjectBaraclan.MainMenuViews
{
    public partial class dbCalendar : Form
    {
        int month, year;
        UserAccount account;

        public dbCalendar(UserAccount user)
        {
            InitializeComponent();

            displayDays();
        }




        public void displayDays()
        {
            DateTime today = DateTime.Now;
            month = today.Month;
            year = today.Year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            lblMonthYear.Text = monthName+" "+ year;
            DateTime startOfTheMonth = new DateTime(today.Year, today.Month, 1);
            int days = DateTime.DaysInMonth(today.Year, today.Month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                ucrlDayOff blank = new ucrlDayOff();
                flpCalendar.Controls.Add(blank);
            }

            for (int i = 1; i <= days; i++)
            {
                ucrlDay day = new ucrlDay(account);
                day.days(i);
                flpCalendar.Controls.Add(day);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            flpCalendar.Controls.Clear();

            month++;
            if (month > 12)
            {
                year++;
            }
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            lblMonthYear.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                ucrlDayOff blank = new ucrlDayOff();
                flpCalendar.Controls.Add(blank);
            }

            for (int i = 1; i <= days; i++)
            {
                ucrlDay day = new ucrlDay(account);
                day.days(i);
                day.reserved += ReserveDay;
                day.cancelled += CancelDay;
                flpCalendar.Controls.Add(day);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            flpCalendar.Controls.Clear();

            month--;
            if (month <1) { year--; }
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            lblMonthYear.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                ucrlDayOff blank = new ucrlDayOff();
                flpCalendar.Controls.Add(blank);
            }

            for (int i = 1; i <= days; i++)
            {
                ucrlDay day = new ucrlDay(account);
                day.days(i);
                flpCalendar.Controls.Add(day);
            }
        }


        public void ReserveDay(object sender, EventArgs e)
        {

        }

        public void CancelDay(object sender, EventArgs e)
        {

        }



    }
}
