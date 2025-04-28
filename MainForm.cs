using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeControlProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string URL = "";
            //Teszt
            MessageBox.Show(URL.Length.ToString());
        }
    }
}
