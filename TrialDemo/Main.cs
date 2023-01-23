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
            activeHelper.CheckTrial();
        }

    }
}
