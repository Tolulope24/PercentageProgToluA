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

        private int ConvertToPercent(String level)
        {
            // determine the integer
            int percentage;
            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 85;
                    break;
                case "4-":
                    percentage = 80;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                    // set default
                default:
                    percentage = -1;
                    break;
                   
                    
            }
               // Return Percentage
               return percentage;
        }
        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Identify the integer and String
            string userLevel;
            int userPercentage;
            // Convert the grade level to a string
            userLevel = txtGradeLevel.Text;
            // call back the address
            userPercentage = ConvertToPercent(userLevel);
            // Show Message Box
            MessageBox.Show("The Grade is : " + userPercentage + "Percent" );

        }
    }
}
