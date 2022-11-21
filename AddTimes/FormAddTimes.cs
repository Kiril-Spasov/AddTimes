using System;
using System.IO;
using System.Windows.Forms;

namespace AddTimes
{
    public partial class FormAddTimes : Form
    {
        public FormAddTimes()
        {
            InitializeComponent();
        }

        private void BtnAddTimes_Click(object sender, EventArgs e)
        {
            int day1 = 0, day2 = 0;
            int hours1 = 0, hours2 = 0;
            int mins1 = 0, mins2 = 0;

            int minsToDisplay = 0;
            int hoursToDisplay = 0;

            int totalDays = 0, totalHours = 0, totalMins = 0;


            string path = Application.StartupPath + @"\times.txt";
            StreamReader streamReader = new StreamReader(path);

            int pairsCount = Convert.ToInt32(streamReader.ReadLine());

            for (int i = 1; i <= pairsCount; i++)
            {
                day1 = Convert.ToInt32(streamReader.ReadLine());
                hours1 = Convert.ToInt32(streamReader.ReadLine());
                mins1 = Convert.ToInt32(streamReader.ReadLine());

                day2 = Convert.ToInt32(streamReader.ReadLine());
                hours2 = Convert.ToInt32(streamReader.ReadLine());
                mins2 = Convert.ToInt32(streamReader.ReadLine());


                totalMins = ConvertDaysToMins(day1 + day2) + ConvertHoursToMins(hours1 + hours2) + mins1 + mins2;

                //There are 1440 mins in 1 day.
                totalDays = totalMins / 1440;

                //There are 60 mins in 1h.
                totalHours = totalMins / 60;

                hoursToDisplay = totalHours % 24;
                minsToDisplay = totalMins % 60;


                TxtResult.Text += day1 + " days " + hours1 + " hours " + mins1 + " mins " + " + " +
                         day2 + " days " + hours2 + " hours " + mins2 + " mins " + Environment.NewLine;

                TxtResult.Text += "equals" + Environment.NewLine;

                TxtResult.Text += totalDays + " days " + hoursToDisplay + " hours " + minsToDisplay + " mins " + Environment.NewLine;

                TxtResult.Text += Environment.NewLine;
            }      
        }

        private int ConvertDaysToMins(int days)
        {
            int mins = days * 24 * 60;

            return mins;
        }

        private int ConvertHoursToMins(int hours)
        {
            int mins = hours * 60;

            return mins;
        }

    }
}
