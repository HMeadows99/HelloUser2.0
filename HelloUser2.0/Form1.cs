
/*
 * Haidan
 * Mr. Hardman
 * Assignment #2, Hello User2.0
 * Date Last Modified: october 17 2016
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloUser2._0
{
    public partial class FrmHelloUser : Form
    {
        public FrmHelloUser()
        {
            InitializeComponent();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLandeskog_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMonahan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuberdeau_Click(object sender, EventArgs e)
        {
            
        }

        private void btnScheifele_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {

        }

        private void btnOther_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "you are wrong, scheifele is a better player";
        }

        private void rdoHuberdeau_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "you are wrong, scheifele is better than Huberdeau";
        }

        private void rdoLandeskog_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "you are wrong, scheifele is better than Landeskog";
        }

        private void rdoMonahan_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "you are wrong, scheifele is better than Monahan";
        }

        private void rdoScheifele_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Correct!";
        }
    }
}
