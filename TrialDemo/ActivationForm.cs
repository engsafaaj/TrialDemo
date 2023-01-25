using DeviceId;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrialDemo
{
    partial class ActivationForm : Form
    {
        DataBase.DBContext db;
        DataBase.Activeation activeation;
        
        public ActivationForm()
        {
            InitializeComponent();
            db = new DataBase.DBContext();
            textBoxMacAddress.Text = new DeviceIdBuilder().AddMacAddress().ToString();


        }


        private async void buttonActivation_Click(object sender, EventArgs e)
        {
            var result = await Task.Run(() => Active(textBoxKey.Text, textBoxMacAddress.Text));
            if (result == true)
            {
                Properties.Settings.Default.IsSoftwerAcitve = true;
                Properties.Settings.Default.Save();

                MessageBox.Show("تم تفعيل البرنامج");

            }
            else
            {
                MessageBox.Show("هناك خطا في مفتاح التفعيل");

            }
        }

        private bool Active(string Key,string MacAddress)
        {
            try
            {
                activeation = db.Activeation.Where(x => x.Key == Key).First();
                if (activeation.Key != null)
                {
                    if (activeation.MacAddress == MacAddress || activeation.MacAddress == null)
                    {
                        // Activation
                        activeation.MacAddress = MacAddress;

                        db.Activeation.Update(activeation);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
              

            }
            catch (Exception EX)
            {
                return false;
            }

        }
             
    }
}
