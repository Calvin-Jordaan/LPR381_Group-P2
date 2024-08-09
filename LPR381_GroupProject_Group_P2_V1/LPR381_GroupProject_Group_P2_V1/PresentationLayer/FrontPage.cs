using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPR381_GroupProject_Group_P2_V1
{
    public partial class Front_Page : Form
    {
        public Front_Page()
        {
            InitializeComponent();
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create the new page object
            Calculator calc_page = new Calculator();

            // Hide the front page
            this.Hide();

            // Show the new page
            calc_page.Show();

            // Link the closing function to the new page
            calc_page.FormClosing += Calculator_FormClosing;

        }

        
    }
}
