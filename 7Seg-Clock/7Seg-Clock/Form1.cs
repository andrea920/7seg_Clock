using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Seg_Clock
{
    public partial class Form1 : Form
    {
        public DateTime dt;
        public string hr, min, sec, hrA, hrB, minA, minB, secA, secB;

        private void cBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button[] buttonDot = new Button[2] { Q1, Q2};
            switch (cBox1.SelectedIndex)
            {
                case 0:
                    timeColor = Color.Red;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 1:
                    timeColor = Color.Blue;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 2:
                    timeColor = Color.Yellow;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 3:
                    timeColor = Color.Pink;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 4:
                    timeColor = Color.Green;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 5:
                    timeColor = Color.Purple;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 6:
                    timeColor = Color.Orange;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;

            }
            foreach (Button but in buttonDot)
            {
                but.BackColor = timeColor;
            }
        }
        

        public Color timeColor = Color.Red, backColor = Color.Black;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Tick_tok();
        }

        public Button[] button1, button2, button3, button4, button5, button6;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1 = new Button[7] { btA1, btA2, btA3, btA4, btA5, btA6, btA7 };
            button2 = new Button[7] { btB1, btB2, btB3, btB4, btB5, btB6, btB7 };
            button3 = new Button[7] { btC1, btC2, btC3, btC4, btC5, btC6, btC7 };
            button4 = new Button[7] { btD1, btD2, btD3, btD4, btD5, btD6, btD7 };
            button5 = new Button[7] { btE1, btE2, btE3, btE4, btE5, btE6, btE7 };
            button6 = new Button[7] { btF1, btF2, btF3, btF4, btF5, btF6, btF7 };
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void Clock_Update(Button[] buttons, string number)
        {
            switch (number)
            {
                case "0":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "1":
                    buttons[0].BackColor = backColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "2":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = backColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "3":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "4":
                    buttons[0].BackColor = backColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "5":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = backColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "6":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = backColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "7":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "8":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "9":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
            }
        }
        public void Tick_tok()
        {
            dt = DateTime.Now;
            hr = $"{dt:hh}";
            min = $"{dt:mm}";
            sec = $"{dt:ss}";
            hrA = hr.Substring(0, 1);
            hrB = hr.Substring(1, 1);
            minA = min.Substring(0, 1);
            minB = min.Substring(1, 1);
            secA = sec.Substring(0, 1);
            secB = sec.Substring(1, 1);
            Clock_Update(button1, hrA);
            Clock_Update(button2, hrB);
            Clock_Update(button3, minA);
            Clock_Update(button4, minB);
            Clock_Update(button5, secA);
            Clock_Update(button6, secB);
        }
    }
}
