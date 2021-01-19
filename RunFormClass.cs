using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForGame
{
    public class RunFormClass
    {
        int LifeSpane = 2;
        int Bullets = 0;
        int point = 0;
        int notp = 0;
     public   int pic = 2;
        public void Forspingun()
        {
            if (point == 1)
            {
                Random rr = new Random();
                Bullets = rr.Next(1, 7);
                notp = 1;
                MessageBox.Show("Gun Spined");
            }
        }
        public void Gunreload()
      {            
            {
                point = 1;                
                if (Bullets == 6)
                {
                    MessageBox.Show("You Have Bullets");
                                    }
                else
                {
                    Bullets = 5;
                    pic = pic +2;
                    if (pic >= 5)
                    {
                        pic = 4;
                    }

                    MessageBox.Show("Your Gun Reload");
                    SoundPlayer SD = new SoundPlayer(ProjectForGame.Properties.Resources.Gun_Reload);
                    SD.Play();
                }
            }
        }
        public void GunShoot()
        {
            if (notp == 1)
            {
                if (LifeSpane > 0)
                {
                    if (Bullets == 0 || Bullets == pic)
                    {
                        MessageBox.Show("you hit on target .. \n Your Points Are " + Bullets + " ");
                        point = 0;
                        notp = 0;
                    }

                    else
                    {
                        MessageBox.Show("Shooting");
                        Bullets = Bullets - 1;
                        SoundPlayer SD = new SoundPlayer(ProjectForGame.Properties.Resources.GUN);
                        SD.Play();
                    }
                }
            }
        }
        public void GunShootAway()
        {
            if (notp == 1)
            {

                if (LifeSpane == 0 || Bullets == pic)
                {
                    MessageBox.Show("You Lost");
                    point = 0;
                    notp = 0;
                }
                else
                {
                    MessageBox.Show("You Miss Your Chance");
                    LifeSpane = LifeSpane - 1;
                    SoundPlayer SD = new SoundPlayer(ProjectForGame.Properties.Resources.EmptyShoot);
                    SD.Play();
                }
            }
        }
    }
}
