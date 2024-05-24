using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee pt = new PartTimeEmployee(firstName.Text, lastName.Text, department.Text, jobTitle.Text);

            double hour = Convert.ToDouble(ratePerHour.Text);
            int totalHour = Convert.ToInt32(totalHours.Text);
            pt.computeSalary(totalHour, hour);

            label10.Text= firstName.Text;
            label11.Text = lastName.Text;
            label12.Text = Convert.ToString(pt.getSalary());
           
        }
    }
}
