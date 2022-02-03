using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to parse name
            
        }

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to edit the phone number
            string phoneNumber = txtPhoneNumber.Text.Replace("(",""); // now that you've made "phoneNumber" something else, you have to make a new variable to amke more changes
            string digitsOnly = phoneNumber.Replace(")","");          // now that you created dO from pN you have to keep modifying dO to remove all other spc.chars
            digitsOnly = digitsOnly.Replace(" ", "");
            digitsOnly = digitsOnly.Replace("-","");
            //string standardFormat = string.Empty;
            string standardFormat = digitsOnly.Substring(0,3) 


        }

        // TODO: Add ToInitialCap method here

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
