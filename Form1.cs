using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices; //FLAT GUI drag mouse
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter=0, lang=0;

        //Panel2 = Mouse Drag (Flat GUI)
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_Load(object sender, EventArgs e)
        {

            Size = new Size(739, 194);
           panel1.Location = new Point(-12, 150);

            label1.Text = "Zaczynajmy ! Najpierw ułóż biały krzyż, którego ramiona będą tego\n" +
                "samego koloru co środki innych ścian do niego przylegających.";
        }

        //gonext button
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter == 0)
            {
                Size = new Size(739, 194);
                panel1.Location = new Point(-12, 150);

                label1.Text = "Zaczynajmy ! Najpierw ułóż biały krzyż, którego ramiona będą tego\n" +
                    "samego koloru co środki innych ścian do niego przylegających.";
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.PictureBox11;
            }

            if (counter == 1)
            {
                label1.Text = "A teraz zajmijmy się wstawianiem narożników do naszego krzyża,\n" +
                "tak aby zachować ten sam kolor jaki jest na klockach obok,\n przy czym podstaw " +
                "klocek pod wybrane przez nas miejsce. \nAlgorytm powtarzać aż do skutku.";
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._2;
                pictureBox2.Image = WindowsFormsApp1.Properties.Resources.o1;
                Size = new Size(739, 294);
                panel1.Location = new Point(-12, 250);
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.l2;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.g1;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.l1;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.g2;

            }
            if (counter==2)
            {
                    label1.Text = "Następnie odwróc kostkę białym kolorem do dołu, gdyż\n " +
                        "zajmiemy się teraz wkładaniem klocków z punktu\nA w miejsce " +
                        "klocków w punkcie B.";
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._3;

                pictureBox2.Image = WindowsFormsApp1.Properties.Resources.o21;
                pictureBox19.Image = WindowsFormsApp1.Properties.Resources.o22;

                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;

                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.l1;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.l2;
                pictureBox7.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox8.Image = WindowsFormsApp1.Properties.Resources.k1;
                pictureBox9.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox10.Image = WindowsFormsApp1.Properties.Resources.k2;

                pictureBox18.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox17.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox16.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox15.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox14.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox13.Image = WindowsFormsApp1.Properties.Resources.k2;
                pictureBox12.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox11.Image = WindowsFormsApp1.Properties.Resources.k1;

                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                pictureBox21.Visible = true;
                pictureBox20.Visible = true;

                Size = new Size(739, 378);
                    panel1.Location = new Point(-12, 334);
            }
            if (counter == 3)
            {
                label1.Text = "W tej części wazne jest ułożenie kostki w dłoni przed\n" +
                              "wykonaniem algorytmu, który jest ten sam dla 3 różnych\n" +
                              "wzorów w celu ułożenia żółtego krzyża nie naruszając reszty.";
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._4;

                pictureBox2.Image = WindowsFormsApp1.Properties.Resources.o31;
                pictureBox19.Image = WindowsFormsApp1.Properties.Resources.o32;
                pictureBox28.Image = WindowsFormsApp1.Properties.Resources.o33;

                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.k1;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox7.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox8.Image = WindowsFormsApp1.Properties.Resources.k2;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;


                pictureBox18.Image = WindowsFormsApp1.Properties.Resources.k1;
                pictureBox17.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox16.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox15.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox14.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox13.Image = WindowsFormsApp1.Properties.Resources.k2;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;

                pictureBox27.Image = WindowsFormsApp1.Properties.Resources.k1;
                pictureBox26.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox25.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox24.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox23.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox22.Image = WindowsFormsApp1.Properties.Resources.k2;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                label3.Visible = false;
                Size = new Size(739, 458);
                panel1.Location = new Point(-12, 415);

                pictureBox2.Visible = true;
                pictureBox19.Visible = true;

                pictureBox17.Visible = true;
                pictureBox16.Visible = true;
                pictureBox15.Visible = true;
                pictureBox13.Visible = true;

                label4.Visible = false;
                label5.Visible = false;

            }
            if (counter == 4)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._5;

                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                pictureBox21.Visible = true;
                pictureBox20.Visible = true;

                Size = new Size(739, 378);
                panel1.Location = new Point(-12, 334);

                label1.Text = "Kolejny etapem będzie ustawienie ramion naszego krzyża " +
                    "tak by\nkolor był ten sam co środki innych ścian. W celu wykonania\n" +
                    "algorytmu przesuwamy górną żółtą ściane tak by uzyskać któryś z\n" +
                    "przedstawionych poniżej wzorów.";

                label3.Visible = true;
                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox7.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox8.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox9.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox10.Image = WindowsFormsApp1.Properties.Resources.j2;

                pictureBox18.Image = WindowsFormsApp1.Properties.Resources.o41;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Image = WindowsFormsApp1.Properties.Resources.o42;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;

                pictureBox2.Visible = false;
                pictureBox19.Visible = false;

                label4.Visible = true;
                label5.Visible = true;
                label4.Text = "Dwa sąsiadujące obok siebie\nUkładamy w tym przypadku\nod koloru zielonego.";
                label5.Text = "Dwa na przeciwko siebie\nUkładamy od jednego z\nwybranych, tutaj niebieski.";
            }
            if (counter == 5)
            {
                label4.Visible = false;
                label5.Visible = false;

                label3.Visible = false;

                pictureBox2.Visible = true;
                pictureBox2.Image = WindowsFormsApp1.Properties.Resources.o51;

                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._6;

                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.l1;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox7.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox8.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox9.Image = WindowsFormsApp1.Properties.Resources.l2;
                pictureBox10.Image = WindowsFormsApp1.Properties.Resources.j2;

                label1.Text = "Znajdź narożnik, który jest na swoim miejscu, może być źle " +
                    "odwrócony,\n algorytm wykonuj trzymając kostkę mając go po z lewej strony.\n" +
                    "Jeżeli nie znaleziono żadnego, algorytm zacznij z jakiejkolwiek strony." +
                    "\nAlgorytm robić do skutku, aż narożniki znajdą się na swoich miejscach.";

                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;

                Size = new Size(739, 294);
                panel1.Location = new Point(-12, 250);
            }
            if (counter == 6)
            {
                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.l2;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.g1;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.l1;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.g2;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                label1.Text = "Teraz wystarczy tylko obrócić narożniki we właściwym kierunku.\n" +
                    "Powtarzamy 1 algorytm, aż narożnik nie wejdzie prawidłowo na swoje\nmiejsce. " +
                    "Nie obracamy całej kostki leczy tylko górną żółtą warstwę i\nrobimy tak dla wszystkich źle obróconych narożników.";
            }
            if (counter>=7)
            {
                counter = 6;
            }
            if (counter<0)
            {
                counter = 0;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //language switcher
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (lang==0)
            {
                //eng -> pl
                lang = 1;
            }
            if (lang==1)
            {
                //pl -> eng
                lang = 0;
            }
        }

        //goback button
        private void button2_Click(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                Size = new Size(739, 194);
                panel1.Location = new Point(-12, 150);

                label1.Text = "Zaczynajmy ! Najpierw ułóż biały krzyż, którego ramiona będą tego\n" +
                    "samego koloru co środki innych ściando niego przylegających.";
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.PictureBox11;
            }

            if (counter == 1)
            {
                label1.Text = "A teraz zajmijmy się wstawianiem narożników do naszego krzyża,\n" +
                "tak aby zachować ten sam kolor jaki jest na klockach obok,\n przy czym podstaw " +
                "klocek pod wybrane przez nas miejsce. \nAlgorytm powtarzać aż do skutku.";
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._2;
                pictureBox2.Image = WindowsFormsApp1.Properties.Resources.o1;
                Size = new Size(739, 294);
                panel1.Location = new Point(-12, 250);
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.l2;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.g1;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.l1;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.g2;

            }
            if (counter == 2)
            {
                label1.Text = "Następnie odwróc kostkę białym kolorem do dołu, gdyż\n " +
                    "zajmiemy się teraz wkładaniem klocków z punktu\nA w miejsce " +
                    "klocków w punkcie B.";
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._3;

                pictureBox2.Image = WindowsFormsApp1.Properties.Resources.o21;
                pictureBox19.Image = WindowsFormsApp1.Properties.Resources.o22;

                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;

                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.l1;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.l2;
                pictureBox7.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox8.Image = WindowsFormsApp1.Properties.Resources.k1;
                pictureBox9.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox10.Image = WindowsFormsApp1.Properties.Resources.k2;

                pictureBox18.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox17.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox16.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox15.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox14.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox13.Image = WindowsFormsApp1.Properties.Resources.k2;
                pictureBox12.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox11.Image = WindowsFormsApp1.Properties.Resources.k1;

                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                pictureBox21.Visible = true;
                pictureBox20.Visible = true;

                Size = new Size(739, 378);
                panel1.Location = new Point(-12, 334);
            }
            if (counter == 3)
            {
                label1.Text = "W tej części wazne jest ułożenie kostki w dłoni przed\n" +
                              "wykonaniem algorytmu, który jest ten sam dla 3 różnych\n" +
                              "wzorów w celu ułożenia żółtego krzyża nie naruszając reszty.";
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._4;

                pictureBox2.Image = WindowsFormsApp1.Properties.Resources.o31;
                pictureBox19.Image = WindowsFormsApp1.Properties.Resources.o32;
                pictureBox28.Image = WindowsFormsApp1.Properties.Resources.o33;

                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.k1;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox7.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox8.Image = WindowsFormsApp1.Properties.Resources.k2;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;


                pictureBox18.Image = WindowsFormsApp1.Properties.Resources.k1;
                pictureBox17.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox16.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox15.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox14.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox13.Image = WindowsFormsApp1.Properties.Resources.k2;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;

                pictureBox27.Image = WindowsFormsApp1.Properties.Resources.k1;
                pictureBox26.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox25.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox24.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox23.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox22.Image = WindowsFormsApp1.Properties.Resources.k2;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                label3.Visible = false;
                Size = new Size(739, 458);
                panel1.Location = new Point(-12, 415);

                pictureBox2.Visible = true;
                pictureBox19.Visible = true;

                pictureBox17.Visible = true;
                pictureBox16.Visible = true;
                pictureBox15.Visible = true;
                pictureBox13.Visible = true;

                label4.Visible = false;
                label5.Visible = false;

            }
            if (counter == 4)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._5;

                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                pictureBox21.Visible = true;
                pictureBox20.Visible = true;

                Size = new Size(739, 378);
                panel1.Location = new Point(-12, 334);

                label1.Text = "Kolejny etapem będzie ustawienie ramion naszego krzyża " +
                    "tak by\nkolor był ten sam co środki innych ścian. W celu wykonania\n" +
                    "algorytmu przesuwamy górną żółtą ściane tak by uzyskać któryś z\n" +
                    "przedstawionych poniżej wzorów.";

                label3.Visible = true;
                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox7.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox8.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox9.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox10.Image = WindowsFormsApp1.Properties.Resources.j2;

                pictureBox18.Image = WindowsFormsApp1.Properties.Resources.o41;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Image = WindowsFormsApp1.Properties.Resources.o42;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;

                pictureBox2.Visible = false;
                pictureBox19.Visible = false;

                label4.Visible = true;
                label5.Visible = true;
                label4.Text = "Dwa sąsiadujące obok siebie\nUkładamy w tym przypadku\nod koloru zielonego.";
                label5.Text = "Dwa na przeciwko siebie\nUkładamy od jednego z\nwybranych, tutaj niebieski.";
            }
            if (counter == 5)
            {
                label4.Visible = false;
                label5.Visible = false;

                label3.Visible = false;

                pictureBox2.Visible = true;
                pictureBox2.Image = WindowsFormsApp1.Properties.Resources.o51;

                pictureBox1.Image = WindowsFormsApp1.Properties.Resources._6;

                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.h2;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.l1;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.j2;
                pictureBox7.Image = WindowsFormsApp1.Properties.Resources.h1;
                pictureBox8.Image = WindowsFormsApp1.Properties.Resources.j1;
                pictureBox9.Image = WindowsFormsApp1.Properties.Resources.l2;
                pictureBox10.Image = WindowsFormsApp1.Properties.Resources.j2;

                label1.Text = "Znajdź narożnik, który jest na swoim miejscu, może być źle " +
                    "odwrócony,\n algorytm wykonuj trzymając kostkę mając go po z lewej strony.\n" +
                    "Jeżeli nie znaleziono żadnego, algorytm zacznij z jakiejkolwiek strony." +
                    "\nAlgorytm robić do skutku, aż narożniki znajdą się na swoich miejscach.";

                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;

                Size = new Size(739, 294);
                panel1.Location = new Point(-12, 250);
            }
            if (counter == 6)
            {
                pictureBox3.Image = WindowsFormsApp1.Properties.Resources.l2;
                pictureBox4.Image = WindowsFormsApp1.Properties.Resources.g1;
                pictureBox5.Image = WindowsFormsApp1.Properties.Resources.l1;
                pictureBox6.Image = WindowsFormsApp1.Properties.Resources.g2;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                label1.Text = "Teraz wystarczy tylko obrócić narożniki we właściwym kierunku.\n" +
                    "Powtarzamy 1 algorytm, aż narożnik nie wejdzie prawidłowo na swoje\nmiejsce. " +
                    "Nie obracamy całej kostki leczy tylko górną żółtą warstwę i\nrobimy tak dla wszystkich źle obróconych narożników.";
            }
            if (counter >= 7)
            {
                counter = 6;
            }
            if (counter < 0)
            {
                counter = 0;
            }
        }
    }
}
