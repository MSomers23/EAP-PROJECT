using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String f_name = firstname.Text;
            String l_name = lastName.Text;
            String gender = "";
            String s_street = street.Text;
            String c_city = city.Text;
            String p_parish = parish.Text;
            String s_subpack = package.Text;
            String video = "";
            String tot_vid_rent = total.Text;


            //radio button

            bool isChecked = maleBtn.Checked;
            if (!isChecked)
            {
                gender = maleBtn.Text;
            }
            else
            {
                gender = femaleBtn.Text;
            }


            //radio button 2

            bool isTicked = yesBtn.Checked;
            if (!isTicked)
            {
                video = yesBtn.Text;
            }
            else
            {
                video = noBtn.Text;
            }

            if (isChecked)
            {
                if (isTicked)
                {
                    MessageBox.Show(f_name + "" + l_name + "" + gender + "" + street + "" + city + "" + parish + "" + package + "" +  ""+ video+ total + "");
                }
            }
            MessageBox.Show(f_name + "" + l_name + "" + gender + "" + street + "" + city + "" + parish + "" + package + "" +video + total + "");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstname.Text = String.Empty;
            lastName.Text = String.Empty;
            maleBtn.Checked = false;
            femaleBtn.Checked = false;
            street.Text = String.Empty;
            city.Text = String.Empty;
            parish.Text = String.Empty;
            package.Text = String.Empty;
            yesBtn.Checked = false;
            noBtn.Checked = false;
            total.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
