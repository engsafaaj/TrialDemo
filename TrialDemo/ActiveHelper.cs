using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TrialDemo
{
   public class ActiveHelper
    {
        private readonly Main main;

        public ActiveHelper(Main main)
        {
            this.main = main;
        }

        public void CheckTrial()
        {
            // Check if First Open
            if (Properties.Settings.Default.IsFirstOpen != true)
            {
                // SetUp DateTime
                DateTime StartDemo = DateTime.Now;
                Properties.Settings.Default.StartDate = StartDemo;
                Properties.Settings.Default.EndDate = StartDemo.AddMinutes(1);
                Properties.Settings.Default.IsFirstOpen = true;
                Properties.Settings.Default.Save(); // Save Changes
                MessageBox.Show("Your Trial Version is Started and End on  "+Properties.Settings.Default.EndDate.ToLongDateString()+"");

            }
            else
            {
                if(DateTime.Now>Properties.Settings.Default.EndDate && Properties.Settings.Default.IsActive == false)
                {
                    // Stop Gui // Exit 
                    main.Enabled = false;
                    MessageBox.Show("Your Trial Version is expired ");
                    // Show Activation Window
                }
                else
                {
                    if (Properties.Settings.Default.IsActive == true)
                    {
                        MessageBox.Show("You use Pro Verion");

                    }
                    else
                    {
                        MessageBox.Show("You use Trial Verion");

                    }
                }
            }
        }
    }
}
