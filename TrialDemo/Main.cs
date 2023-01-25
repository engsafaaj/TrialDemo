using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrialDemo
{
    public partial class Main : Form
    {
        ActiveHelper activeHelper;
        public Main()
        {
            InitializeComponent();
            activeHelper = new ActiveHelper(this);
            // activeHelper.CheckTrial();
            SetLimit();
        }


       
        private void SetLimit()
        {
            if (Properties.Settings.Default.IsSoftwerAcitve == false)
            {
                // Set Limit

                button1.Enabled = false;
                MessageBox.Show("You are using demo verion");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivationForm activationForm = new ActivationForm();
            activationForm.Show();
        }
    }
}
