using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DinoGuesser
{
    public partial class Form1 : Form
    {
        public int pos = -1;
        int[,] rebra = new int[256, 3];
        string[,] ans = new string[256, 2];
        string[] state = new string[256];
        string[] quest = new string[256];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ss = Properties.Resources.rebra.Split('\n');

            String[] ss1 = Properties.Resources.rebra1.Split('\n');

            String[] ss2 = Properties.Resources.rebra2.Split('\n');

            int n = ss2.Count();
            for (int i = 0; i < n; i += 2)
            {
                if (ss[i] != "")
                {
                    ans[Int32.Parse(ss[i]), 0] = ss2[i];
                    ans[Int32.Parse(ss[i]), 1] = ss2[i + 1];
                    rebra[Int32.Parse(ss[i]), 0] = Int32.Parse(ss[i]);
                    rebra[Int32.Parse(ss[i]), 1] = Int32.Parse(ss1[i]);
                    rebra[Int32.Parse(ss[i]), 2] = Int32.Parse(ss1[i + 1]);
                }
            }

            String[] ssStp = Properties.Resources.statePos.Split('\n');
            String[] ssStt = Properties.Resources.stateText.Split('\n');

            int ns = ssStp.Count();
            for (int i = 0; i < ns; i++)
            {
                if (ssStp[i] != "")
                {
                    state[Int32.Parse(ssStp[i])] = ssStt[i];
                }
            }

            String[] ssQp = Properties.Resources.questPos.Split('\n');
            String[] ssQt = Properties.Resources.questText.Split('\n');

            int nq = ssQp.Count();
            for (int i = 0; i < nq; i++)
            {
                if (ssQp[i] != "")
                {
                    quest[Int32.Parse(ssQp[i])] = ssQt[i];
                }
            }
        }

        public void Draw()
        {
            if (pos == 0)
                states.Text = "";

            button1.Text = ans[pos, 0];
            button2.Text = ans[pos, 1];
            label3.Text = state[pos];
            if (state[pos] != null)
                states.Text += state[pos] + "\n";
            label4.Text = quest[pos];

            switch (pos)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources._0;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources._2;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources._11;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources._13;
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources._15;
                    break;
                case 16:
                    pictureBox1.Image = Properties.Resources._16;
                    break;
                case 17:
                    pictureBox1.Image = Properties.Resources._17;
                    break;
                case 19:
                    pictureBox1.Image = Properties.Resources._19;
                    break;
                case 21:
                    pictureBox1.Image = Properties.Resources._21;
                    break;
                case 23:
                    pictureBox1.Image = Properties.Resources._23;
                    break;
                case 25:
                    pictureBox1.Image = Properties.Resources._25;
                    break;
                case 26:
                    pictureBox1.Image = Properties.Resources._26;
                    break;
                case 29:
                    pictureBox1.Image = Properties.Resources._29;
                    break;
                case 31:
                    pictureBox1.Image = Properties.Resources._31;
                    break;
                case 32:
                    pictureBox1.Image = Properties.Resources._32;
                    break;
                case 33:
                    pictureBox1.Image = Properties.Resources._33;
                    break;
                case 34:
                    pictureBox1.Image = Properties.Resources._34;
                    break;
                case 37:
                    pictureBox1.Image = Properties.Resources._37;
                    break;
                case 38:
                    pictureBox1.Image = Properties.Resources._38;
                    break;
                case 39:
                    pictureBox1.Image = Properties.Resources._39;
                    break;
                case 40:
                    pictureBox1.Image = Properties.Resources._40;
                    break;
                case 41:
                    pictureBox1.Image = Properties.Resources._41;
                    break;
                case 43:
                    pictureBox1.Image = Properties.Resources._43;
                    break;
                case 44:
                    pictureBox1.Image = Properties.Resources._44;
                    break;
                case 45:
                    pictureBox1.Image = Properties.Resources._45;
                    break;
                case 47:
                    pictureBox1.Image = Properties.Resources._47;
                    break;
                case 49:
                    pictureBox1.Image = Properties.Resources._49;
                    break;
                case 51:
                    pictureBox1.Image = Properties.Resources._51;
                    break;
                case 53:
                    pictureBox1.Image = Properties.Resources._53;
                    break;
                case 54:
                    pictureBox1.Image = Properties.Resources._54;
                    break;
                case 56:
                    pictureBox1.Image = Properties.Resources._56;
                    break;
                case 57:
                    pictureBox1.Image = Properties.Resources._57;
                    break;
                case 58:
                    pictureBox1.Image = Properties.Resources._58;
                    break;
                case 59:
                    pictureBox1.Image = Properties.Resources._59;
                    break;
                case 61:
                    pictureBox1.Image = Properties.Resources._61;
                    break;
                case 63:
                    pictureBox1.Image = Properties.Resources._63;
                    break;
                case 65:
                    pictureBox1.Image = Properties.Resources._65;
                    break;
                case 66:
                    pictureBox1.Image = Properties.Resources._66;
                    break;
                case 67:
                    pictureBox1.Image = Properties.Resources._67;
                    break;
                case 69:
                    pictureBox1.Image = Properties.Resources._69;
                    break;
                case 70:
                    pictureBox1.Image = Properties.Resources._70;
                    break;
                case 71:
                    pictureBox1.Image = Properties.Resources._71;
                    break;
                case 72:
                    pictureBox1.Image = Properties.Resources._72;
                    break;
                case 74:
                    pictureBox1.Image = Properties.Resources._74;
                    break;
                case 75:
                    pictureBox1.Image = Properties.Resources._75;
                    break;
                case 76:
                    pictureBox1.Image = Properties.Resources._76;
                    break;
                case 77:
                    pictureBox1.Image = Properties.Resources._77;
                    break;
                case 83:
                    pictureBox1.Image = Properties.Resources._83;
                    break;
                case 85:
                    pictureBox1.Image = Properties.Resources._85;
                    break;
                case 86:
                    pictureBox1.Image = Properties.Resources._86;
                    break;
                case 87:
                    pictureBox1.Image = Properties.Resources._87;
                    break;
                case 89:
                    pictureBox1.Image = Properties.Resources._89;
                    break;
                case 90:
                    pictureBox1.Image = Properties.Resources._90;
                    break;
                case 93:
                    pictureBox1.Image = Properties.Resources._93;
                    break;
                case 94:
                    pictureBox1.Image = Properties.Resources._94;
                    break;
                case 95:
                    pictureBox1.Image = Properties.Resources._95;
                    break;
                case 97:
                    pictureBox1.Image = Properties.Resources._97;
                    break;
                case 99:
                    pictureBox1.Image = Properties.Resources._99;
                    break;
                case 100:
                    pictureBox1.Image = Properties.Resources._100;
                    break;
                case 101:
                    pictureBox1.Image = Properties.Resources._101;
                    break;
                case 102:
                    pictureBox1.Image = Properties.Resources._102;
                    break;
                case 103:
                    pictureBox1.Image = Properties.Resources._103;
                    break;
                case 108:
                    pictureBox1.Image = Properties.Resources._108;
                    break;
                case 109:
                    pictureBox1.Image = Properties.Resources._109;
                    break;
                case 110:
                    pictureBox1.Image = Properties.Resources._110;
                    break;
                case 111:
                    pictureBox1.Image = Properties.Resources._111;
                    break;
                case 115:
                    pictureBox1.Image = Properties.Resources._115;
                    break;
                case 116:
                    pictureBox1.Image = Properties.Resources._116;
                    break;
                case 117:
                    pictureBox1.Image = Properties.Resources._117;
                    break;
                case 118:
                    pictureBox1.Image = Properties.Resources._118;
                    break;
                case 119:
                    pictureBox1.Image = Properties.Resources._119;
                    break;
                case 120:
                    pictureBox1.Image = Properties.Resources._120;
                    break;
                case 123:
                    pictureBox1.Image = Properties.Resources._123;
                    break;
                case 125:
                    pictureBox1.Image = Properties.Resources._125;
                    break;
                case 127:
                    pictureBox1.Image = Properties.Resources._127;
                    break;
                case 128:
                    pictureBox1.Image = Properties.Resources._128;
                    break;
                case 129:
                    pictureBox1.Image = Properties.Resources._129;
                    break;
                case 130:
                    pictureBox1.Image = Properties.Resources._130;
                    break;
                case 131:
                    pictureBox1.Image = Properties.Resources._131;
                    break;
                case 132:
                    pictureBox1.Image = Properties.Resources._132;
                    break;
                case 133:
                    pictureBox1.Image = Properties.Resources._133;
                    break;
                case 134:
                    pictureBox1.Image = Properties.Resources._134;
                    break;
                case 135:
                    pictureBox1.Image = Properties.Resources._135;
                    break;
                case 137:
                    pictureBox1.Image = Properties.Resources._137;
                    break;
                case 139:
                    pictureBox1.Image = Properties.Resources._139;
                    break;
                case 141:
                    pictureBox1.Image = Properties.Resources._141;
                    break;
                case 143:
                    pictureBox1.Image = Properties.Resources._143;
                    break;
                case 144:
                    pictureBox1.Image = Properties.Resources._144;
                    break;
                case 145:
                    pictureBox1.Image = Properties.Resources._145;
                    break;
                case 147:
                    pictureBox1.Image = Properties.Resources._147;
                    break;
                case 149:
                    pictureBox1.Image = Properties.Resources._149;
                    break;
                case 150:
                    pictureBox1.Image = Properties.Resources._150;
                    break;
                default:
                    break;
            }

            if (rebra[pos, 1] == 0)
            {
                button1.Text = "Начать с начала";
                button2.Text = "Выход";
                label4.Text = state[pos];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pos == -1)
            {
                pos = 0;
            }
            else
            {
                pos = rebra[pos, 1];
            }
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pos == -1)
            {
                Application.Exit();
                return;
            }
            else if (rebra[pos, 1] == 0)
            {
                Application.Exit();
                return;
            }
            else
            {
                pos = rebra[pos, 2];
            }
            Draw();
        }
    }
}
