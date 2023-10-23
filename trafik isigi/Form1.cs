using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafik_isigi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            timer1.Start();
        }
        int panelNo = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
          

            if (panelNo == 1)
            {
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.DimGray;
                panel3.BackColor = Color.DimGray;
                panelNo = 2;
            }
            else if (panelNo == 2)
            {
                panel1.BackColor = Color.DimGray;
                panel2.BackColor = Color.Yellow;
                panel3.BackColor = Color.DimGray;
                panelNo = 3;
            }
            else if (panelNo == 3)
            {
                panel1.BackColor = Color.DimGray;
                panel2.BackColor = Color.DimGray;
                panel3.BackColor = Color.Green;
                panelNo = 1;
            }
        }
    }
}
