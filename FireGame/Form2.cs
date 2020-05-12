using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame
{
    public partial class Form2 : Form
    {

        Click obj = new Click();

        public int shoot = 0, shoot_Count = 0;

        int shoot_Away = 0, shot_Away_Count = 0;
        int shot_Away_Click = 0;

        int shoot_CLick = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            Gun_Load.Enabled = false;
            Gun_Spin.Enabled = false;
            Gun_Shoot.Enabled = false;
            Gun_Away.Enabled = false;
            Gun_Reload.Enabled = false;

        }

        private void Gun_Load_Click(object sender, EventArgs e)
        {
            //disable it self and enable the spin button and load the bullet into the gun 
            Gun_Load.Enabled = false;
            //load the gun so thus we can perform the next step 
            Photo.Image = FireGame.Properties.Resources.gun2_load;
            Gun_Spin.Enabled = true;
        }

        private void Gun_Spin_Click(object sender, EventArgs e)
        {
            //spin the gun after loading the bullet 
            Gun_Spin.Enabled = false;
            Gun_Shoot.Enabled = true;
            Gun_Away.Enabled = true;
            //spin image must be loaded into the memory 
            Photo.Image = FireGame.Properties.Resources.gun2_spin;
        }

        private void Gun_Reload_Click(object sender, EventArgs e)
        {
            Gun_Reload.Enabled = false;
            Game_Start.Enabled = true;

            //reset the all variable 
            shoot = obj.gen();
            shoot_Count = 0;

            shoot_Away = obj.gen();
            shot_Away_Count = 0;
            shot_Away_Click = 0;

            shoot_CLick = 0;
            Photo.Image = FireGame.Properties.Resources.gun2_start;
        }

        private void Gun_Shoot_Click(object sender, EventArgs e)
        {
            //load the image 
            Photo.Image = FireGame.Properties.Resources.gun2_shoot;
            //count the click on the shoot 
            shoot_Count++;

            System.Media.SoundPlayer objSound = new System.Media.SoundPlayer(FireGame.Properties.Resources.fire);
            objSound.Play();

            //compare the click
            if (shoot == shoot_Count)
            {
                //when value is equal then the fire sound will be generated   
                shoot_CLick++;
                //when two chances are clicked then the chances are over 
                Gun_Shoot.Enabled = false;
                Gun_Away.Enabled = false;
                MessageBox.Show("Your are die ");
                Gun_Reload.Enabled = true;

            }
            else if (shoot_Count == 4)
            {
                MessageBox.Show("Your are alive  ");
                Gun_Shoot.Enabled = false;
                Gun_Away.Enabled = false;

                Gun_Reload.Enabled = true;

            }
            else
            {
                MessageBox.Show("Try again Better Luck Next ");
            }

        }

        private void Gun_Away_Click(object sender, EventArgs e)
        {

            //this is another calling the trigger to shoot away the 
            shot_Away_Count++;
            System.Media.SoundPlayer objSound = new System.Media.SoundPlayer(FireGame.Properties.Resources.fire);
            objSound.Play();
            if (shoot_Away == shot_Away_Count)
            {
                //when value is equal then the fire sound will be generated 
                shot_Away_Click++;
                MessageBox.Show("you are die ");
                Gun_Reload.Enabled = true;
                Gun_Away.Enabled = false;
                Gun_Shoot.Enabled = false;
            }
            if (shot_Away_Count == 2)
            {
                MessageBox.Show("you are alive ");

                shoot_Away = obj.gen();
                Gun_Reload.Enabled = true;
                Gun_Away.Enabled = false;
                Gun_Shoot.Enabled = false;
            }

        }

        public Form2()
        {
            InitializeComponent();
            shoot = obj.gen();
            shot_Away_Click = obj.gen();
        }

        private void Game_Start_Click(object sender, EventArgs e)
        {
            //display the pop up as Alert and Enable  the next button 
            MessageBox.Show("Wel Come to the Fire Game ");
            Gun_Load.Enabled = true;
            Game_Start.Enabled = false;

        }
    }
}
