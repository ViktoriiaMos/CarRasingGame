namespace CarRasingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gameSpeed);
            enemy(gameSpeed);
            gameOver();
            moveCoint(gameSpeed);
            collectCoins();
        }
        int getCoins = 0;
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);

                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);

                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);

                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        void moveCoint(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(0, 400);

                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);

                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }


        }
        void gameOver()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
        }
        void moveLine(int speed)
        {

            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }


        }
        int gameSpeed = 0;

        void collectCoins()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                getCoins++;
                label2.Text = "Coins = " + getCoins.ToString();
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                getCoins++;
                label2.Text = "Coins = " + getCoins.ToString();
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                getCoins++;
                label2.Text = "Coins = " + getCoins.ToString();
                x = r.Next(0, 400);

                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                getCoins++;
                label2.Text = "Coins = " + getCoins.ToString();
                x = r.Next(0, 200);

                coin4.Location = new Point(x, 0);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                    car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                    car.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
                if (gameSpeed < 21)
                { gameSpeed++; }
            if (e.KeyCode == Keys.Down)
                if (gameSpeed > 0)
                { gameSpeed--; }
        }
    }
}