using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerProject
{
    public partial class Form2 : Form
    {
        public int currentTime = 0;
        


        public Form2()
        {
            InitializeComponent();
        }

        private void SECbtnDone_Click(object sender, EventArgs e)
        {
            SECtimer.Stop();
            this.Hide();
           
        }

        private void SECtimer_Tick(object sender, EventArgs e)
        {
            currentTime++;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
