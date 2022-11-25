using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace teste_flap
{
    public partial class Form1 : Form
    {
       
        //Variaveis de movimento
        public int MoveSpeed = 30, Xspeed = 2, Yspeed, Gspeed=0, limitSpeed_G=5;
        public int MoveTicks = 0;
        private int z = 1, h = 1, contPoint=0;

        //variáveis para o objLava  usar a PositionX para o bloco point
        readonly int ObjSize_X = 50, newObjPosition_X = 590, ObjPosition_X = 600;
        readonly int ObjPositionY_Up=0;
        public int  ObjSizeY_Up,ObjPositionY_Down,ObjSizeY_Down= 420;

        //Variaveis para o bloco point
        readonly int pointSize_Y = 97, pointSize_X=41;
        public int pointPosition_Y=122;

        // tamanho max da tela é de 420 px
        private int pontos=0;

        private void DearhLava_Tick(object sender, EventArgs e)
        {
            int contLava = 0;
            foreach (Lava la in Lava.lava)
            {
                if (Lava.lava[contLava].Bounds.IntersectsWith(Caixa.Bounds))
                {
                    DearhLava.Enabled = false;
                    MoveTimer.Enabled = false;
                    timerX.Enabled = false;

                    string final_points = Convert.ToString(pontos);
                    string massage = $"You lose, but you can break your limits and get a higher score.\nYour Score: {final_points}\nClose the forms to play again";
                    MessageBox.Show(massage);
                    break;
                }
                else
                    contLava++;
                if (contLava >= Lava.lava.Count)
                    contLava = 0;
            }
        }
        public void Randon_Point()
        {
            int seconds,temp;

                Random rnd = new Random();
                pointPosition_Y = rnd.Next(20, 300);
                DateTime dt = DateTime.Now;
                seconds = (int)(dt.Millisecond / 10);
                if (pointPosition_Y > 103)
                    pointPosition_Y -= seconds;
                else
                    pointPosition_Y += seconds;
            
        }
        public void Randon_LavaBox()
        {
            ObjSizeY_Up = pointPosition_Y - 1;
            ObjPositionY_Down = pointSize_Y + pointPosition_Y + 1;
            ObjSizeY_Down = 420 - ObjPositionY_Down;
        }
    

        public Form1()
        {
            InitializeComponent();
            Lava.lava.Add(lava5);
            Lava.lava.Add(lava6);
            Lava.espaco.Add(espaco);

            System.IO.Stream str = Properties.Resources.Maluco_w;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(str);
            player.PlayLooping();

        }
        
        private void newObj_Tick(object sender, EventArgs e)
        {

            foreach (Lava x in Lava.lava)
            {
                if (Lava.lava[h].Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    Randon_Point();
                    Randon_LavaBox();

                    Lava temp3 = new Lava();

                    temp3.Location = new Point(newObjPosition_X, pointPosition_Y);
                    temp3.Size = new Size(pointSize_X, pointSize_Y);
                    temp3.Image = Properties.Resources.espacamento;
                    temp3.SizeMode = PictureBoxSizeMode.Normal;
                    temp3.Visible = false;
                    Controls.Add(temp3);
                    Lava.espaco.Add(temp3);

                    Lava temp1 = new Lava();

                    temp1.Location = new Point(newObjPosition_X, ObjPositionY_Up);
                    temp1.Size = new Size(ObjSize_X, ObjSizeY_Up);
                    temp1.Image = Properties.Resources.Lava_concertada;
                    temp1.SizeMode = PictureBoxSizeMode.Normal;
                    Controls.Add(temp1);
                    Lava.lava.Add(temp1);

                    Lava temp2 = new Lava(); 

                    temp2.Location = new Point(newObjPosition_X, ObjPositionY_Down);
                    temp2.Size = new Size(ObjSize_X, ObjSizeY_Down);
                    temp2.Image = Properties.Resources.Lava_concertada;
                    temp2.SizeMode = PictureBoxSizeMode.Normal;

                    Controls.Add(temp2);
                    Lava.lava.Add(temp2);
                    h += 2;
                    break;
                }

            }
        }

        private void ChangeAll()
        {
            int color1, color2, color3,rndTemp;
            Random rnd1 = new Random();
            DateTime dt = DateTime.Now;
          if (pontos % 5 == 0)
            {
                
                rndTemp = (int)(dt.Millisecond / 10);
                color1 = rnd1.Next(0, 157+rndTemp);

                rndTemp = (int)(dt.Millisecond / 10);
                color2 = rnd1.Next(0, 157 + rndTemp);

                rndTemp = (int)(dt.Millisecond / 10);
                color3 = rnd1.Next(0, 157 + rndTemp);
                
                BackColor = Color.FromArgb(color1, color2, color3);
                MoveSpeed += 1;
                Xspeed += 1;
                limitSpeed_G += 1;
            }
        }
        private void timerX_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < Lava.lava.Count; i++)
            {
                int x = Lava.lava[i].Location.X;
                int y = Lava.lava[i].Location.Y;
                Lava.lava[i].Location = new Point(x-Xspeed, y);
            }
            for (int i = 0; i <Lava.espaco.Count; i++)
            {
                int x = Lava.espaco[i].Location.X;
                int y = Lava.espaco[i].Location.Y;
                Lava.espaco[i].Location = new Point(x - Xspeed, y);
                

            }
            foreach (Lava x in Lava.lava)
            {
           
                if (Lava.lava[z].Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    Randon_Point();
                    Randon_LavaBox();

                    Lava.lava[z].Location = new Point(ObjPosition_X, ObjPositionY_Up);
                    Lava.lava[z].Size = new Size(ObjSize_X, ObjSizeY_Up);
                    Lava.lava[z -1].Location = new Point(ObjPosition_X, ObjPositionY_Down);
                    Lava.lava[z-1].Size = new Size(ObjSize_X, ObjSizeY_Down);

                    Lava.espaco[contPoint].Location = new Point(ObjPosition_X, pointPosition_Y);
                    Lava.espaco[contPoint].Size = new Size(pointSize_X, pointSize_Y);

                    pontos++;
                    Pontos.Text = Convert.ToString(pontos);
                    ChangeAll();

                    contPoint++;
                    z += 2;
                    newObj.Enabled = false;
                   
                }
                if (z >= Lava.lava.Count)
                {
                    z = 1;
                }
                if (contPoint >= Lava.espaco.Count)
                {
                    contPoint = 0;
                }
            }
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            int x = Caixa.Location.X;
            int y = Caixa.Location.Y;

            if (Caixa.Location.Y <= 0)
                y = 0;
            Caixa.Location = new Point(x, y - Yspeed);
            MoveTicks++;
            if (MoveTicks == Yspeed)
            {
                Gspeed = 0;
                MoveTicks = 0;
                timerG.Enabled = true;
                MoveTimer.Enabled = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int Hmax, TempUp;
            double result;
            timerG.Enabled = false;
            switch (e.KeyCode)
            {
                case Keys.W:
                    Hmax = fisica.Hmax(MoveSpeed);
                    TempUp= fisica.TempSubida(MoveSpeed);
                    result = Hmax / TempUp;
                    Yspeed = (int)result;
                break;
                case Keys.Q:
                    Hmax = fisica.Hmax((int)(MoveSpeed*1.5));
                    TempUp = fisica.TempSubida((int)(MoveSpeed * 1.5));
                    result = Hmax / TempUp;
                    Yspeed = (int)result;
                break;
                case Keys.E:
                    Hmax = fisica.Hmax((int)(MoveSpeed / 2));
                    TempUp = fisica.TempSubida((int)(MoveSpeed / 2));
                    result = Hmax / TempUp;
                    Yspeed = (int)result;
                break;

            }
            MoveTimer.Enabled = true;
        }
        private void timerG_Tick(object sender, EventArgs e)
        {
            int x = Caixa.Location.X;
            int y = Caixa.Location.Y;
            if (y >= 380)
                y = 380;
            if (Gspeed< limitSpeed_G)
                Gspeed++;
            Caixa.Location = new Point(x, y+Gspeed);
        }

    }
}
