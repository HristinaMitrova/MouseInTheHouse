using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseInTheHouse
{
    public partial class Playing_Scene : Form
    {
        bool PAUSE;
        private int time = 60;
        private Congratulations_Form youWonForm;
        private YouLost_Form loserForm;
        private Congratulations_Form win;
        Point start = new Point();
        Size SIZE = new Size();
        int countCheese;
        int countLives;
        int nivo;
        bool c1 = false;
        bool c2 = false;
        bool c3 = false;

        public Playing_Scene()
        {
            InitializeComponent();
            timer1.Interval = 35;
            timer1.Start();



            KeyDown += new KeyEventHandler(Form2_KeyDown);
            start = pb_movingMouse.Location;
            SIZE = pb_movingMouse.Size;
            countLives = 3;
            countCheese = 0;
            PAUSE = false;
           // label1.Text = "Lives:";
            label6.Text = countLives.ToString();
            nivo = 1;
            label7.Text ="1";


        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private bool IsInTouch(PictureBox pb_movingMouse, PictureBox pb)
        {
            if (pb_movingMouse.Bounds.IntersectsWith(pb.Bounds))
            {
                return true;
            }
            else return false;
        }
        private void Playing_Scene_Load(object sender, EventArgs e)
        {
            KeyDown += new KeyEventHandler(Form2_KeyDown);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pb_movingMouse.Location.X;
            int y = pb_movingMouse.Location.Y;
            int cekor = 10;
            bool pom = false;
            if (e.KeyCode == Keys.Right)
            {
                if (pb_movingMouse.Location.X <= 230 &&
                    !IsInTouch(pb_movingMouse, pictureBox20) &&
                    !IsInTouch(pb_movingMouse, pictureBox2) &&
                    !IsInTouch(pb_movingMouse, pictureBox13) &&
                    !IsInTouch(pb_movingMouse, pictureBox21))
                {


                    x += cekor;
                    if (IsInTouch(pb_movingMouse, sirenje1) && c1==false){
                        countCheese++;
                        sirenje1.Hide();
                        c1 = true;
                    }
                    if (IsInTouch(pb_movingMouse, sirenje2)&& c2==false)
                    {
                        countCheese++;
                        sirenje2.Hide();
                        c2 = true;
                    }
                    if (IsInTouch(pb_movingMouse, sirenje3) && c3==false)
                    {
                        countCheese++;
                        sirenje3.Hide();
                        c3 = true;
                    }
                    if (IsInTouch(pb_movingMouse, kukja) && countCheese==3)
                    {
                        pobedi(nivo);
                        pb_movingMouse.Location = new Point(132, 520);
                    }

                }
            }
            else if (e.KeyCode == Keys.Left)

            {
                
                if (pb_movingMouse.Location.X >= 44 &&
                    !IsInTouch(pb_movingMouse, pictureBox14) &&
                    !IsInTouch(pb_movingMouse, pictureBox3) &&
                    !IsInTouch(pb_movingMouse, pictureBox4) &&
                    !IsInTouch(pb_movingMouse, pictureBox19) 
                    )
                {
                    x -= cekor;
                    if (IsInTouch(pb_movingMouse, sirenje1) && c1 == false)
                    {
                        countCheese++;
                        sirenje1.Hide();
                        c1 = true;
                    }
                    if (IsInTouch(pb_movingMouse, sirenje2) && c2 == false)
                    {
                        countCheese++;
                        sirenje2.Hide();
                        c2 = true;
                    }
                    if (IsInTouch(pb_movingMouse, sirenje3) && c3 == false)
                    {
                        countCheese++;
                        sirenje3.Hide();
                        c3 = true;
                    }
                    if (IsInTouch(pb_movingMouse, kukja) && countCheese == 3)
                    {
                        pobedi(nivo);
                        pb_movingMouse.Location = new Point(132, 520);
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                
                //label1.Text = "prrrrrrrrp";
                if (pb_movingMouse.Location.Y >= 45 &&
                    !IsInTouch(pb_movingMouse, pictureBox1)&&
                    !IsInTouch(pb_movingMouse, pictureBox17) &&
                    !IsInTouch(pb_movingMouse, pictureBox16) &&
                    !IsInTouch(pb_movingMouse, pictureBox15) &&
                    !IsInTouch(pb_movingMouse, pictureBox12) &&
                    !IsInTouch(pb_movingMouse, pictureBox13))// &&
                    
                    //!IsInTouch(pb_movingMouse, pictureBox2) ) 
                    
                {
                    y -= cekor;
                    if (IsInTouch(pb_movingMouse, sirenje1) && c1 == false)
                    {
                        countCheese++;
                        sirenje1.Hide();
                        c1 = true;
                    }
                    if (IsInTouch(pb_movingMouse, sirenje2) && c2 == false)
                    {
                        countCheese++;
                        sirenje2.Hide();
                        c2 = true;
                    }
                    if (IsInTouch(pb_movingMouse, sirenje3) && c3 == false)
                    {
                        countCheese++;
                        sirenje3.Hide();
                        c3 = true;
                    }
                    if (IsInTouch(pb_movingMouse, kukja) && countCheese == 3)
                    {
                        pobedi(nivo);
                        pb_movingMouse.Location = new Point(132, 520);
                    }
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                
                if (pb_movingMouse.Location.Y <= 520 &&
                    !IsInTouch(pb_movingMouse, pictureBox10) &&
                    !IsInTouch(pb_movingMouse, pictureBox11) &&
                    !IsInTouch(pb_movingMouse, pictureBox18))
                {
                    y += cekor;
                    if (IsInTouch(pb_movingMouse, sirenje1) && c1 == false)
                    {
                        countCheese++;
                        sirenje1.Hide();
                        c1 = true;
                    }
                    if (IsInTouch(pb_movingMouse, sirenje2) && c2 == false)
                    {
                        countCheese++;
                        sirenje2.Hide();
                        c2 = true;
                    }
                    if (IsInTouch(pb_movingMouse, sirenje3) && c3 == false)
                    {
                        countCheese++;
                        sirenje3.Hide();
                        c3 = true;
                    }
                    if (countCheese == 3 && IsInTouch(pb_movingMouse, kukja))
                    {
                        pom = true;
                        pobedi(nivo);
                        pb_movingMouse.Location = new Point(132, 520);
                        countCheese = 0;
                        sirenje1.Show();
                        sirenje2.Show();
                        sirenje3.Show();
                        c1 = false;
                        c2 = false;
                        c3 = false;


                    }
                }
            }
            if (pom==false)pb_movingMouse.Location = new Point(x, y);
        }
        /*private void Form2_KeyPress(object sender,KeyPressEventArgs e)
        {
            if (PAUSE == false)
            {
                if (e.KeyChar == 'p' || e.KeyChar == 'P')
                {
                    PAUSE = true;
                }
            }
            else PAUSE = false;
        }*/
        private void pobedi (int niv)
        {
            string message = "LEVEL ";
            string title = "";
        
            if (niv == 1)
            {
                message += "2";
                nivo = 2;
                pb_movingMouse.Location = new Point(132, 520);
                timer1.Interval = 13;
                
                label7.Text = "2";
                MessageBox.Show(message, title);
                pb_movingMouse.Location = new Point(132, 520);
            }
            else if (niv == 2)
            {
                nivo = 3;
                message += "3";
                pb_movingMouse.Location = new Point(132, 520);
                timer1.Interval = 5;
                
                label7.Text = "3";
                MessageBox.Show(message, title);
                pb_movingMouse.Location = new Point(132, 520);
            }
            else
            {
                this.Hide();
                win = new Congratulations_Form();
                win.Show();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = countLives.ToString();
            pb_movingCat1.Location = new Point(pb_movingCat1.Location.X, pb_movingCat1.Location.Y - 1);
            pb_movingCat2.Location = new Point(pb_movingCat2.Location.X-1, pb_movingCat2.Location.Y);
            if (pb_movingCat1.Location.Y == 10) pb_movingCat1.Location = new Point(pb_movingCat1.Location.X,500);
            if (pb_movingCat2.Location.X == 40) pb_movingCat2.Location = new Point(225, pb_movingCat2.Location.Y);
            if (IsInTouch(pb_movingMouse, pb_movingCat1) || IsInTouch(pb_movingMouse, pb_movingCat2)
                    || IsInTouch(pb_movingMouse, stapica1) || IsInTouch(pb_movingMouse, stapica2)
                    || IsInTouch(pb_movingMouse, stapica3)||IsInTouch(pb_movingMouse,fire))
            {

                pb_movingMouse.Location = new Point(132,520);
                countLives =countLives-1;
                if (countLives == 0)
                {
                    this.Hide();
                    loserForm = new YouLost_Form();
                    loserForm.Show();
                }
            }
            stapica1.Location = new Point(stapica1.Location.X + 1, stapica1.Location.Y);
            stapica2.Location = new Point(stapica2.Location.X + 1, stapica2.Location.Y);
            stapica3.Location = new Point(stapica3.Location.X - 1, stapica3.Location.Y);
            if (stapica1.Location.X == 225) stapica1.Location = new Point(40, stapica1.Location.Y);
            if (stapica3.Location.X == 40) stapica3.Location = new Point(225, stapica3.Location.Y);
            if (stapica2.Location.X == 225) stapica2.Location = new Point(40, stapica2.Location.Y);
            fire.Location = new Point(fire.Location.X, fire.Location.Y + 1);
            if (fire.Location.Y == 102) fire.Location = new Point(fire.Location.X, 35);
        }
    }
}
