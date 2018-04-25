using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercentageProgToluA
{
    public partial class frmPercentageProgram : Form
    {
        public frmPercentageProgram()
        {
            InitializeComponent();
        }

        private int ConvertToPercent (String level)
        {
            int Percentage;
            switch (level)
            {
                case "4++":
                    Percentage = 98;
                    break;
                case "4+":
                    Percentage = 95;
                    break;
                case "4":
                    Percentage = 85;
                    break;


            }

        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
