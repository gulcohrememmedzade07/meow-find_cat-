using System.Media;

namespace meow_find_cat_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int num;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Oyundan çıxış edilsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
        bool k = false;
        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            label2.Text = count.ToString();
            Random r = new Random();
            num = r.Next(1, 7);
            if (k == false)
            {
                k = true;
                pictureBox1.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox2.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox3.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox4.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox5.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox6.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox7.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox8.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
            }
            else
            {
                k = false;
                pictureBox1.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox2.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox3.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox4.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox5.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox6.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox7.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
                pictureBox8.ImageLocation = "C:\\Users\\Huawei\\Downloads\\808255464408428838.jpeg";
            }
        }
        int count = 0;
        SoundPlayer sp = new SoundPlayer("C:\\Users\\Huawei\\Downloads\\explosion.wav");

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (num == 1)
            {
                if (count != 0)
                    count--;
                pictureBox1.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Art by Sith666.jpeg";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox1.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Black Cat with Mystical Symbols Art.jpeg";
            }
            label2.Text = count.ToString();
            if (count == 7)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (num == 2)
            {
                if (count != 0)
                    count--;
                pictureBox2.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Art by Sith666.jpeg";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox2.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Black Cat with Mystical Symbols Art.jpeg";
            }
            label2.Text = count.ToString();
            if (count == 7)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (num == 3)
            {
                if (count != 0)
                    count--;
                pictureBox3.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Art by Sith666.jpeg";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox3.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Black Cat with Mystical Symbols Art.jpeg";
            }
            label2.Text = count.ToString();
            if (count == 7)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (num == 4)
            {
                if (count != 0)
                    count--;
                pictureBox4.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Art by Sith666.jpeg";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox4.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Black Cat with Mystical Symbols Art.jpeg";
            }
            label2.Text = count.ToString();
            if (count == 7)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (num == 5)
            {
                if (count != 0)
                    count--;
                pictureBox5.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Art by Sith666.jpeg";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox5.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Black Cat with Mystical Symbols Art.jpeg";
            }
            label2.Text = count.ToString();
            if (count == 7)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (num == 6)
            {
                if (count != 0)
                    count--;
                pictureBox6.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Art by Sith666.jpeg";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox6.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Black Cat with Mystical Symbols Art.jpeg";
            }
            label2.Text = count.ToString();
            if (count == 7)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (num == 7)
            {
                if (count != 0)
                    count--;
                pictureBox7.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Art by Sith666.jpeg";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox7.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Black Cat with Mystical Symbols Art.jpeg";
            }
            label2.Text = count.ToString();
            if (count == 7)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (num == 8)
            {
                if (count != 0)
                    count--;
                pictureBox8.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Art by Sith666.jpeg";
                sp.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün Ok edin", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                count++;
                pictureBox8.ImageLocation = "C:\\Users\\Huawei\\Downloads\\Black Cat with Mystical Symbols Art.jpeg";
            }
            label2.Text = count.ToString();
            if (count == 7)
            {
                MessageBox.Show("Oyunu qazandınız");
            }
        }
    }
}
