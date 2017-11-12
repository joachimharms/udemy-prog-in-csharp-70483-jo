using System;
using System.Windows.Forms;

namespace S03_L20_Classes_and_Objects_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var e1 = new Employee();
            e1.FirstName = "Mark";
            e1.LastName = "Long";
            e1.Seniority = 5;

            var p = e1.Promote();
            MessageBox.Show(p);

            var e2 = new Employee();
            e2.FirstName = "Alice";
            e2.LastName = "Jones";
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Seniority { get; set; }

        public string AnnualReview()
        {
            return "Annual review completed...";
        }

        public string Promote()
        {
            return "Employee has been promoted...";
        }
    }
}