using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            write2status("Application started");
            this.Text = "Test4Git ver. " + Application.ProductVersion.Substring(0, 5);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            write2status("Application exiting");
            Application.Exit();
        }
        
        private void write2status(string strData)
        {
            lstStatus.Items.Insert(0, DateTime.Now.ToString() + " - " + strData);
        }
    }
}
