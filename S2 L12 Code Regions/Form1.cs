using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2_L12_Code_Regions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region SayHelloLogic

        private void button1_Click(object sender, EventArgs e)
        {
            SayHello();
        }

        private void SayHello()
        {
            MessageBox.Show("Hello...");
        }

        #endregion

    }
}
