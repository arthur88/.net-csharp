using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyCSharpIntermediate4_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button) sender; //downcasting sender with explicit cast

            //if not use about type of object then use AS
            var btn = sender as Button;

            if(btn != null)
            {
                MessageBox.Show(btn.Height.ToString());
            }
       
            MessageBox.Show("Hello World");
        }
    }
}
