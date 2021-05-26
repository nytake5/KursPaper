using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HaoticForm : Form
    {
        private int _iterCnt = 0;

        public HaoticForm()
        {
            InitializeComponent();
        }

        public int IterCnt()
        {
            return _iterCnt;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _iterCnt = int.Parse(comboBox1.Text);
            this.Close();
        }

        private void HaoticForm_Load(object sender, EventArgs e)
        {

        }

    }
}
