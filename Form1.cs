using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForGame
{
    public partial class Form1 : Form
    {
        RunFormClass RFC = new RunFormClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void ForGunShooting_Click(object sender, EventArgs e)
        {

        }

        private void ForGunShootAway_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShootIMZ_Click(object sender, EventArgs e)
        {
            RFC.GunShoot();            
        }

        private void GunSHootAway_Click(object sender, EventArgs e)
        {
            RFC.GunShootAway();            
        }

        private void GunReloadingIMZ_Click(object sender, EventArgs e)
        {
            RFC.Gunreload();            
        }

        private void SpinBTN_Click(object sender, EventArgs e)
        {
            RFC.Forspingun();            
        }

        private void Exitthegame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainBackgroundIMZ_Click(object sender, EventArgs e)
        {

        }
    }
}
