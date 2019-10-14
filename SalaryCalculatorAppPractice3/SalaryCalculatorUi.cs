using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        Salary salary = new Salary();

        public string EmpleNme;
        public double BscAmnt;
        public double HmeRnt;
        public double MdclAlwnce;
        public double Show;
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }

        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(employeeNameTextBox.Text))
            {
                MessageBox.Show("Employee can not be Empty");
                return;
            }
            if (String.IsNullOrEmpty(basicAmountTextBox.Text))
            {
                MessageBox.Show("Amount can not be Empty");
                return;
            }

            EmpleNme = salary.EmployeeName = employeeNameTextBox.Text;
            BscAmnt = salary.BasicAmount = Convert.ToDouble(basicAmountTextBox.Text);

            HmeRnt = (BscAmnt * 3) / 100;
            MdclAlwnce = (BscAmnt * 5) / 100;

            homeRentTextBox.Text = HmeRnt.ToString();
            medicalAllowanceTextBox.Text = MdclAlwnce.ToString();

            Show = BscAmnt + HmeRnt + MdclAlwnce;

            MessageBox.Show("Show Me Salary:" + Show);




        }
    }
}
