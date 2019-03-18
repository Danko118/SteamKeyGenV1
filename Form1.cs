using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamGenerator
{
    public partial class Form1 : Form
    {
        public string W1 = " ";
        public string W2 = " ";
        public string W3 = " ";
        public string W4 = " ";
        public string W5 = " ";
        public int OurType = 0;
        public char[] chars = new char[36];
        public Form1()
        {
            InitializeComponent();
            chars[0] = '1';
            chars[1] = '2';
            chars[2] = '3';
            chars[3] = '4';
            chars[4] = '5';
            chars[5] = '6';
            chars[6] = '7';
            chars[7] = '8';
            chars[8] = '9';
            chars[9] = '0';
            chars[10] = 'A';
            chars[11] = 'B';
            chars[12] = 'C';
            chars[13] = 'D';
            chars[14] = 'E';
            chars[15] = 'F';
            chars[16] = 'G';
            chars[17] = 'H';
            chars[18] = 'I';
            chars[19] = 'J';
            chars[20] = 'K';
            chars[21] = 'L';
            chars[22] = 'M';
            chars[23] = 'N';
            chars[24] = 'O';
            chars[25] = 'P';
            chars[26] = 'Q';
            chars[27] = 'R';
            chars[28] = 'S';
            chars[29] = 'T';
            chars[30] = 'U';
            chars[31] = 'V';
            chars[32] = 'W';
            chars[33] = 'X';
            chars[34] = 'Y';
            chars[35] = 'Z';
            radioButton1.Checked = true;
            radioButton5.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Generate(int type)
        {
            switch (type) {
                case 1:
                    W1 = " ";
                    W2 = " ";
                    W3 = " ";
                    Gen1(5, type);
                    Gen1(5, type);
                    Gen1(5, type);
                    textBox1.Text = W1 + "-" + W2 + "-" + W3;
                    break;
                case 2:
                    W1 = " ";
                    W2 = " ";
                    W3 = " ";
                    W4 = " ";
                    W5 = " ";
                    Gen1(5, type);
                    Gen1(5, type);
                    Gen1(5, type);
                    Gen1(5, type);
                    Gen1(5, type);
                    textBox1.Text = W1 + "-" + W2 + "-" + W3 + "-" + W4 + "-" + W5;
                    break;
                case 3:
                    W1 = " ";
                    Gen1(20, type);
                    textBox1.Text = W1;
                    break;
            }
        }
        public void Gen1(int Count,int type)
        {
            Random rand1 = new Random();
            switch (type)
            {
                case 1: 
                m1:
                    String words1 = "";
                    for (int i = 0; i < Count; i++)
                    {
                        String letter = " ";
                        int j = rand1.Next(35);
                        letter = chars[j].ToString();
                        words1 += letter;
                    }
                    if (W1 == " ")
                    {
                        W1 = words1;
                    }
                    else if (W2 == " ")
                    {
                        if (W1 == words1)
                        {
                            goto m1;
                        }
                        else
                        {
                            W2 = words1;
                        }
                    }
                    else if (W3 == " ")
                    {
                        if (W2 == words1 || W1 == words1)
                        {
                            goto m1;
                        }
                        else
                        {
                            W3 = words1;
                        }
                    }
                    break;
                case 2:
                m2:
                    String words2 = "";
                    for (int i = 0; i < Count; i++)
                    {
                        String letter = " ";
                        int j = rand1.Next(35);
                        letter = chars[j].ToString();
                        words2 += letter;
                    }
                    if (W1 == " ")
                    {
                        W1 = words2;
                    }
                    else if (W2 == " ")
                    {
                        if (W1 == words2)
                        {
                            goto m1;
                        }
                        else
                        {
                            W2 = words2;
                        }
                    }
                    else if (W3 == " ")
                    {
                        if (W2 == words2 || W1 == words2)
                        {
                            goto m2;
                        }
                        else
                        {
                            W3 = words2;
                        }
                    }
                    else if(W4 == " ")
                    {
                        if (W3 == words2 ||W2 == words2 || W1 == words2)
                        {
                            goto m2;
                        }
                        else
                        {
                            W4 = words2;
                        }
                    }else if(W5 == " ")
                    {
                        if (W4 == words2 || W3 == words2 || W2 == words2 || W1 == words2)
                        {
                            goto m2;
                        }
                        else
                        {
                            W5 = words2;
                        }
                    }
                    break;
                case 3:
                    String words3 = "";
                    for (int i = 0; i < Count; i++)
                    {
                        String letter = " ";
                        int j = rand1.Next(35);
                        letter = chars[j].ToString();
                        words3 += letter;
                    }
                    W1 = words3;
                    break;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                OurType = 1;
            }
            if (radioButton2.Checked == true)
            {
                OurType = 2;
            }
            if (radioButton3.Checked == true)
            {
                OurType = 3;
            }
            Generate(OurType);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked == true)
            {
                groupBox1.Text = "Тип ключа";
                radioButton1.Text = "Тип 1";
                radioButton2.Text = "Тип 2";
                radioButton3.Text = "Тип 3";
                button1.Text = "Сгенерировать";
                toolTip1.ToolTipTitle = "Тип 1:";
                toolTip2.ToolTipTitle = "Тип 2:";
                toolTip3.ToolTipTitle = "Тип 3:";
                label1.Text = "Ваш ключ:";
                groupBox2.Text = "Язык";
            }else
            {
                groupBox1.Text = "Type of key";
                radioButton1.Text = "Type 1";
                radioButton2.Text = "Type 2";
                radioButton3.Text = "Type 3";
                button1.Text = "Generate";
                toolTip1.ToolTipTitle = "Type 1:";
                toolTip2.ToolTipTitle = "Type 2:";
                toolTip3.ToolTipTitle = "Type 3:";
                label1.Text = "Your key:";
                groupBox2.Text = "Lang";
            }
        }
    }
}
