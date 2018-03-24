using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Snake_And_Ladder_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer2.Start();
        }

        static Random random = new Random();
        int player1 = 0, player2 = 0, pre1 = 0, pre2 = 0, i = 0, n = 0, credit = 0;

        private void pl1()
        {
            player1 ++;
            switch (pre1)
            {
                case 0: break;
                case 1:
                    label1.BackColor = bc1;
                    label1.ForeColor = c1;
                    break;
                case 2:
                    label2.BackColor = bc1;
                    label2.ForeColor = c1;
                    break;
                case 3:
                    label3.BackColor = bc1;
                    label3.ForeColor = c1;
                    break;
                case 4:
                    label4.BackColor = bc1;
                    label4.ForeColor = c1;
                    break;
                case 5:
                    label5.BackColor = bc1;
                    label5.ForeColor = c1;
                    break;
                case 6:
                    label6.BackColor = bc1;
                    label6.ForeColor = c1;
                    break;
                case 7:
                    label7.BackColor = bc1;
                    label7.ForeColor = c1;
                    break;
                case 8:
                    label8.BackColor = bc1;
                    label8.ForeColor = c1;
                    break;
                case 9:
                    label9.BackColor = bc1;
                    label9.ForeColor = c1;
                    break;
                case 10:
                    label10.BackColor = bc1;
                    label10.ForeColor = c1;
                    break;
                case 11:
                    label11.BackColor = bc1;
                    label11.ForeColor = c1;
                    break;
                case 12:
                    label12.BackColor = bc1;
                    label12.ForeColor = c1;
                    break;
                case 13:
                    label13.BackColor = bc1;
                    label13.ForeColor = c1;
                    break;
                case 14:
                    label14.BackColor = bc1;
                    label14.ForeColor = c1;
                    break;
                case 15:
                    label15.BackColor = bc1;
                    label15.ForeColor = c1;
                    break;
                case 16:
                    label16.BackColor = bc1;
                    label16.ForeColor = c1;
                    break;
                case 17:
                    label17.BackColor = bc1;
                    label17.ForeColor = c1;
                    break;
                case 18:
                    label18.BackColor = bc1;
                    label18.ForeColor = c1;
                    break;
                case 19:
                    label19.BackColor = bc1;
                    label19.ForeColor = c1;
                    break;
                case 20:
                    label20.BackColor = bc1;
                    label20.ForeColor = c1;
                    break;
                case 21:
                    label21.BackColor = bc1;
                    label21.ForeColor = c1;
                    break;
                case 22:
                    label22.BackColor = bc1;
                    label22.ForeColor = c1;
                    break;
                case 23:
                    label23.BackColor = bc1;
                    label23.ForeColor = c1;
                    break;
                case 24:
                    label24.BackColor = bc1;
                    label24.ForeColor = c1;
                    break;
                case 25:
                    label25.BackColor = bc1;
                    label25.ForeColor = c1;
                    break;
                case 26:
                    label26.BackColor = bc1;
                    label26.ForeColor = c1;
                    break;
                case 27:
                    label27.BackColor = bc1;
                    label27.ForeColor = c1;
                    break;
                case 28:
                    label28.BackColor = bc1;
                    label28.ForeColor = c1;
                    break;
                case 29:
                    label29.BackColor = bc1;
                    label29.ForeColor = c1;
                    break;
                case 30:
                    label30.BackColor = bc1;
                    label30.ForeColor = c1;
                    break;
                case 31:
                    label31.BackColor = bc1;
                    label31.ForeColor = c1;
                    break;
                case 32:
                    label32.BackColor = bc1;
                    label32.ForeColor = c1;
                    break;
                case 33:
                    label33.BackColor = bc1;
                    label33.ForeColor = c1;
                    break;
                case 34:
                    label34.BackColor = bc1;
                    label34.ForeColor = c1;
                    break;
                case 35:
                    label35.BackColor = bc1;
                    label35.ForeColor = c1;
                    break;
                case 36:
                    label36.BackColor = bc1;
                    label36.ForeColor = c1;
                    break;
                case 37:
                    label37.BackColor = bc1;
                    label37.ForeColor = c1;
                    break;
                case 38:
                    label38.BackColor = bc1;
                    label38.ForeColor = c1;
                    break;
                case 39:
                    label39.BackColor = bc1;
                    label39.ForeColor = c1;
                    break;
                case 40:
                    label40.BackColor = bc1;
                    label40.ForeColor = c1;
                    break;
                case 41:
                    label41.BackColor = bc1;
                    label41.ForeColor = c1;
                    break;
                case 42:
                    label42.BackColor = bc1;
                    label42.ForeColor = c1;
                    break;
                case 43:
                    label43.BackColor = bc1;
                    label43.ForeColor = c1;
                    break;
                case 44:
                    label44.BackColor = bc1;
                    label44.ForeColor = c1;
                    break;
                case 45:
                    label45.BackColor = bc1;
                    label45.ForeColor = c1;
                    break;
                case 46:
                    label46.BackColor = bc1;
                    label46.ForeColor = c1;
                    break;
                case 47:
                    label47.BackColor = bc1;
                    label47.ForeColor = c1;
                    break;
                case 48:
                    label48.BackColor = bc1;
                    label48.ForeColor = c1;
                    break;
                case 49:
                    label49.BackColor = bc1;
                    label49.ForeColor = c1;
                    break;
                case 50:
                    label50.BackColor = bc1;
                    label50.ForeColor = c1;
                    break;
                case 51:
                    label51.BackColor = bc1;
                    label51.ForeColor = c1;
                    break;
                case 52:
                    label52.BackColor = bc1;
                    label52.ForeColor = c1;
                    break;
                case 53:
                    label53.BackColor = bc1;
                    label53.ForeColor = c1;
                    break;
                case 54:
                    label54.BackColor = bc1;
                    label54.ForeColor = c1;
                    break;
                case 55:
                    label55.BackColor = bc1;
                    label55.ForeColor = c1;
                    break;
                case 56:
                    label56.BackColor = bc1;
                    label56.ForeColor = c1;
                    break;
                case 57:
                    label57.BackColor = bc1;
                    label57.ForeColor = c1;
                    break;
                case 58:
                    label58.BackColor = bc1;
                    label58.ForeColor = c1;
                    break;
                case 59:
                    label59.BackColor = bc1;
                    label59.ForeColor = c1;
                    break;
                case 60:
                    label60.BackColor = bc1;
                    label60.ForeColor = c1;
                    break;
                case 61:
                    label61.BackColor = bc1;
                    label61.ForeColor = c1;
                    break;
                case 62:
                    label62.BackColor = bc1;
                    label62.ForeColor = c1;
                    break;
                case 63:
                    label63.BackColor = bc1;
                    label63.ForeColor = c1;
                    break;
                case 64:
                    label64.BackColor = bc1;
                    label64.ForeColor = c1;
                    break;
                case 65:
                    label65.BackColor = bc1;
                    label65.ForeColor = c1;
                    break;
                case 66:
                    label66.BackColor = bc1;
                    label66.ForeColor = c1;
                    break;
                case 67:
                    label67.BackColor = bc1;
                    label67.ForeColor = c1;
                    break;
                case 68:
                    label68.BackColor = bc1;
                    label68.ForeColor = c1;
                    break;
                case 69:
                    label69.BackColor = bc1;
                    label69.ForeColor = c1;
                    break;
                case 70:
                    label70.BackColor = bc1;
                    label70.ForeColor = c1;
                    break;
                case 71:
                    label71.BackColor = bc1;
                    label71.ForeColor = c1;
                    break;
                case 72:
                    label72.BackColor = bc1;
                    label72.ForeColor = c1;
                    break;
                case 73:
                    label73.BackColor = bc1;
                    label73.ForeColor = c1;
                    break;
                case 74:
                    label74.BackColor = bc1;
                    label74.ForeColor = c1;
                    break;
                case 75:
                    label75.BackColor = bc1;
                    label75.ForeColor = c1;
                    break;
                case 76:
                    label76.BackColor = bc1;
                    label76.ForeColor = c1;
                    break;
                case 77:
                    label77.BackColor = bc1;
                    label77.ForeColor = c1;
                    break;
                case 78:
                    label78.BackColor = bc1;
                    label78.ForeColor = c1;
                    break;
                case 79:
                    label79.BackColor = bc1;
                    label79.ForeColor = c1;
                    break;
                case 80:
                    label80.BackColor = bc1;
                    label80.ForeColor = c1;
                    break;
                case 81:
                    label81.BackColor = bc1;
                    label81.ForeColor = c1;
                    break;
                case 82:
                    label82.BackColor = bc1;
                    label82.ForeColor = c1;
                    break;
                case 83:
                    label83.BackColor = bc1;
                    label83.ForeColor = c1;
                    break;
                case 84:
                    label84.BackColor = bc1;
                    label84.ForeColor = c1;
                    break;
                case 85:
                    label85.BackColor = bc1;
                    label85.ForeColor = c1;
                    break;
                case 86:
                    label86.BackColor = bc1;
                    label86.ForeColor = c1;
                    break;
                case 87:
                    label87.BackColor = bc1;
                    label87.ForeColor = c1;
                    break;
                case 88:
                    label88.BackColor = bc1;
                    label88.ForeColor = c1;
                    break;
                case 89:
                    label89.BackColor = bc1;
                    label89.ForeColor = c1;
                    break;
                case 90:
                    label90.BackColor = bc1;
                    label90.ForeColor = c1;
                    break;
                case 91:
                    label91.BackColor = bc1;
                    label91.ForeColor = c1;
                    break;
                case 92:
                    label92.BackColor = bc1;
                    label92.ForeColor = c1;
                    break;
                case 93:
                    label93.BackColor = bc1;
                    label93.ForeColor = c1;
                    break;
                case 94:
                    label94.BackColor = bc1;
                    label94.ForeColor = c1;
                    break;
                case 95:
                    label95.BackColor = bc1;
                    label95.ForeColor = c1;
                    break;
                case 96:
                    label96.BackColor = bc1;
                    label96.ForeColor = c1;
                    break;
                case 97:
                    label97.BackColor = bc1;
                    label97.ForeColor = c1;
                    break;
                case 98:
                    label98.BackColor = bc1;
                    label98.ForeColor = c1;
                    break;
                case 99:
                    label99.BackColor = bc1;
                    label99.ForeColor = c1;
                    break;
                case 100:
                    label100.BackColor = bc1;
                    label100.ForeColor = c1;
                    break;
            }

            switch (player1)
            {
                case 0: break;
                case 1:
                    bc1 = label1.BackColor;
                    c1 = label1.ForeColor;
                    label1.BackColor = Color.White;
                    label1.ForeColor = Color.White;
                    pre1 = player1; break;
                case 2:
                    bc1 = label2.BackColor;
                    c1 = label2.ForeColor;
                    label2.BackColor = Color.White;
                    label2.ForeColor = Color.White;
                    pre1 = player1; break;
                case 3:
                    bc1 = label3.BackColor;
                    c1 = label3.ForeColor;
                    label3.BackColor = Color.White;
                    label3.ForeColor = Color.White;
                    pre1 = player1; break;
                case 4:
                    bc1 = label4.BackColor;
                    c1 = label4.ForeColor;
                    label4.BackColor = Color.White;
                    label4.ForeColor = Color.White;
                    pre1 = player1; break;
                case 5:
                    bc1 = label5.BackColor;
                    c1 = label5.ForeColor;
                    label5.BackColor = Color.White;
                    label5.ForeColor = Color.White;
                    pre1 = player1; break;
                case 6:
                    bc1 = label6.BackColor;
                    c1 = label6.ForeColor;
                    label6.BackColor = Color.White;
                    label6.ForeColor = Color.White;
                    pre1 = player1; break;
                case 7:
                    bc1 = label7.BackColor;
                    c1 = label7.ForeColor;
                    label7.BackColor = Color.White;
                    label7.ForeColor = Color.White;
                    pre1 = player1; break;
                case 8:
                    bc1 = label8.BackColor;
                    c1 = label8.ForeColor;
                    label8.BackColor = Color.White;
                    label8.ForeColor = Color.White;
                    pre1 = player1; break;
                case 9:
                    bc1 = label9.BackColor;
                    c1 = label9.ForeColor;
                    label9.BackColor = Color.White;
                    label9.ForeColor = Color.White;
                    pre1 = player1; break;
                case 10:
                    bc1 = label10.BackColor;
                    c1 = label10.ForeColor;
                    label10.BackColor = Color.White;
                    label10.ForeColor = Color.White;
                    pre1 = player1; break;
                case 11:
                    bc1 = label11.BackColor;
                    c1 = label11.ForeColor;
                    label11.BackColor = Color.White;
                    label11.ForeColor = Color.White;
                    pre1 = player1; break;
                case 12:
                    bc1 = label12.BackColor;
                    c1 = label12.ForeColor;
                    label12.BackColor = Color.White;
                    label12.ForeColor = Color.White;
                    pre1 = player1; break;
                case 13:
                    bc1 = label13.BackColor;
                    c1 = label13.ForeColor;
                    label13.BackColor = Color.White;
                    label13.ForeColor = Color.White;
                    pre1 = player1; break;
                case 14:
                    bc1 = label14.BackColor;
                    c1 = label14.ForeColor;
                    label14.BackColor = Color.White;
                    label14.ForeColor = Color.White;
                    pre1 = player1; break;
                case 15:
                    bc1 = label15.BackColor;
                    c1 = label15.ForeColor;
                    label15.BackColor = Color.White;
                    label15.ForeColor = Color.White;
                    pre1 = player1; break;
                case 16:
                    bc1 = label16.BackColor;
                    c1 = label16.ForeColor;
                    label16.BackColor = Color.White;
                    label16.ForeColor = Color.White;
                    pre1 = player1; break;
                case 17:
                    bc1 = label17.BackColor;
                    c1 = label17.ForeColor;
                    label17.BackColor = Color.White;
                    label17.ForeColor = Color.White;
                    pre1 = player1; break;
                case 18:
                    bc1 = label18.BackColor;
                    c1 = label18.ForeColor;
                    label18.BackColor = Color.White;
                    label18.ForeColor = Color.White;
                    pre1 = player1; break;
                case 19:
                    bc1 = label19.BackColor;
                    c1 = label19.ForeColor;
                    label19.BackColor = Color.White;
                    label19.ForeColor = Color.White;
                    pre1 = player1; break;
                case 20:
                    bc1 = label20.BackColor;
                    c1 = label20.ForeColor;
                    label20.BackColor = Color.White;
                    label20.ForeColor = Color.White;
                    pre1 = player1; break;
                case 21:
                    bc1 = label21.BackColor;
                    c1 = label21.ForeColor;
                    label21.BackColor = Color.White;
                    label21.ForeColor = Color.White;
                    pre1 = player1; break;
                case 22:
                    bc1 = label22.BackColor;
                    c1 = label22.ForeColor;
                    label22.BackColor = Color.White;
                    label22.ForeColor = Color.White;
                    pre1 = player1; break;
                case 23:
                    bc1 = label23.BackColor;
                    c1 = label23.ForeColor;
                    label23.BackColor = Color.White;
                    label23.ForeColor = Color.White;
                    pre1 = player1; break;
                case 24:
                    bc1 = label24.BackColor;
                    c1 = label24.ForeColor;
                    label24.BackColor = Color.White;
                    label24.ForeColor = Color.White;
                    pre1 = player1; break;
                case 25:
                    bc1 = label25.BackColor;
                    c1 = label25.ForeColor;
                    label25.BackColor = Color.White;
                    label25.ForeColor = Color.White;
                    pre1 = player1; break;
                case 26:
                    bc1 = label26.BackColor;
                    c1 = label26.ForeColor;
                    label26.BackColor = Color.White;
                    label26.ForeColor = Color.White;
                    pre1 = player1; break;
                case 27:
                    bc1 = label27.BackColor;
                    c1 = label27.ForeColor;
                    label27.BackColor = Color.White;
                    label27.ForeColor = Color.White;
                    pre1 = player1; break;
                case 28:
                    bc1 = label28.BackColor;
                    c1 = label28.ForeColor;
                    label28.BackColor = Color.White;
                    label28.ForeColor = Color.White;
                    pre1 = player1; break;
                case 29:
                    bc1 = label29.BackColor;
                    c1 = label29.ForeColor;
                    label29.BackColor = Color.White;
                    label29.ForeColor = Color.White;
                    pre1 = player1; break;
                case 30:
                    bc1 = label30.BackColor;
                    c1 = label30.ForeColor;
                    label30.BackColor = Color.White;
                    label30.ForeColor = Color.White;
                    pre1 = player1; break;
                case 31:
                    bc1 = label31.BackColor;
                    c1 = label31.ForeColor;
                    label31.BackColor = Color.White;
                    label31.ForeColor = Color.White;
                    pre1 = player1; break;
                case 32:
                    bc1 = label32.BackColor;
                    c1 = label32.ForeColor;
                    label32.BackColor = Color.White;
                    label32.ForeColor = Color.White;
                    pre1 = player1; break;
                case 33:
                    bc1 = label33.BackColor;
                    c1 = label33.ForeColor;
                    label33.BackColor = Color.White;
                    label33.ForeColor = Color.White;
                    pre1 = player1; break;
                case 34:
                    bc1 = label34.BackColor;
                    c1 = label34.ForeColor;
                    label34.BackColor = Color.White;
                    label34.ForeColor = Color.White;
                    pre1 = player1; break;
                case 35:
                    bc1 = label35.BackColor;
                    c1 = label35.ForeColor;
                    label35.BackColor = Color.White;
                    label35.ForeColor = Color.White;
                    pre1 = player1; break;
                case 36:
                    bc1 = label36.BackColor;
                    c1 = label36.ForeColor;
                    label36.BackColor = Color.White;
                    label36.ForeColor = Color.White;
                    pre1 = player1; break;
                case 37:
                    bc1 = label37.BackColor;
                    c1 = label37.ForeColor;
                    label37.BackColor = Color.White;
                    label37.ForeColor = Color.White;
                    pre1 = player1; break;
                case 38:
                    bc1 = label38.BackColor;
                    c1 = label38.ForeColor;
                    label38.BackColor = Color.White;
                    label38.ForeColor = Color.White;
                    pre1 = player1; break;
                case 39:
                    bc1 = label39.BackColor;
                    c1 = label39.ForeColor;
                    label39.BackColor = Color.White;
                    label39.ForeColor = Color.White;
                    pre1 = player1; break;
                case 40:
                    bc1 = label40.BackColor;
                    c1 = label40.ForeColor;
                    label40.BackColor = Color.White;
                    label40.ForeColor = Color.White;
                    pre1 = player1; break;
                case 41:
                    bc1 = label41.BackColor;
                    c1 = label41.ForeColor;
                    label41.BackColor = Color.White;
                    label41.ForeColor = Color.White;
                    pre1 = player1; break;
                case 42:
                    bc1 = label42.BackColor;
                    c1 = label42.ForeColor;
                    label42.BackColor = Color.White;
                    label42.ForeColor = Color.White;
                    pre1 = player1; break;
                case 43:
                    bc1 = label43.BackColor;
                    c1 = label43.ForeColor;
                    label43.BackColor = Color.White;
                    label43.ForeColor = Color.White;
                    pre1 = player1; break;
                case 44:
                    bc1 = label44.BackColor;
                    c1 = label44.ForeColor;
                    label44.BackColor = Color.White;
                    label44.ForeColor = Color.White;
                    pre1 = player1; break;
                case 45:
                    bc1 = label45.BackColor;
                    c1 = label45.ForeColor;
                    label45.BackColor = Color.White;
                    label45.ForeColor = Color.White;
                    pre1 = player1; break;
                case 46:
                    bc1 = label46.BackColor;
                    c1 = label46.ForeColor;
                    label46.BackColor = Color.White;
                    label46.ForeColor = Color.White;
                    pre1 = player1; break;
                case 47:
                    bc1 = label47.BackColor;
                    c1 = label47.ForeColor;
                    label47.BackColor = Color.White;
                    label47.ForeColor = Color.White;
                    pre1 = player1; break;
                case 48:
                    bc1 = label48.BackColor;
                    c1 = label48.ForeColor;
                    label48.BackColor = Color.White;
                    label48.ForeColor = Color.White;
                    pre1 = player1; break;
                case 49:
                    bc1 = label49.BackColor;
                    c1 = label49.ForeColor;
                    label49.BackColor = Color.White;
                    label49.ForeColor = Color.White;
                    pre1 = player1; break;
                case 50:
                    bc1 = label50.BackColor;
                    c1 = label50.ForeColor;
                    label50.BackColor = Color.White;
                    label50.ForeColor = Color.White;
                    pre1 = player1; break;
                case 51:
                    bc1 = label51.BackColor;
                    c1 = label51.ForeColor;
                    label51.BackColor = Color.White;
                    label51.ForeColor = Color.White;
                    pre1 = player1; break;
                case 52:
                    bc1 = label52.BackColor;
                    c1 = label52.ForeColor;
                    label52.BackColor = Color.White;
                    label52.ForeColor = Color.White;
                    pre1 = player1; break;
                case 53:
                    bc1 = label53.BackColor;
                    c1 = label53.ForeColor;
                    label53.BackColor = Color.White;
                    label53.ForeColor = Color.White;
                    pre1 = player1; break;
                case 54:
                    bc1 = label54.BackColor;
                    c1 = label54.ForeColor;
                    label54.BackColor = Color.White;
                    label54.ForeColor = Color.White;
                    pre1 = player1; break;
                case 55:
                    bc1 = label55.BackColor;
                    c1 = label55.ForeColor;
                    label55.BackColor = Color.White;
                    label55.ForeColor = Color.White;
                    pre1 = player1; break;
                case 56:
                    bc1 = label56.BackColor;
                    c1 = label56.ForeColor;
                    label56.BackColor = Color.White;
                    label56.ForeColor = Color.White;
                    pre1 = player1; break;
                case 57:
                    bc1 = label57.BackColor;
                    c1 = label57.ForeColor;
                    label57.BackColor = Color.White;
                    label57.ForeColor = Color.White;
                    pre1 = player1; break;
                case 58:
                    bc1 = label58.BackColor;
                    c1 = label58.ForeColor;
                    label58.BackColor = Color.White;
                    label58.ForeColor = Color.White;
                    pre1 = player1; break;
                case 59:
                    bc1 = label59.BackColor;
                    c1 = label59.ForeColor;
                    label59.BackColor = Color.White;
                    label59.ForeColor = Color.White;
                    pre1 = player1; break;
                case 60:
                    bc1 = label60.BackColor;
                    c1 = label60.ForeColor;
                    label60.BackColor = Color.White;
                    label60.ForeColor = Color.White;
                    pre1 = player1; break;
                case 61:
                    bc1 = label61.BackColor;
                    c1 = label61.ForeColor;
                    label61.BackColor = Color.White;
                    label61.ForeColor = Color.White;
                    pre1 = player1; break;
                case 62:
                    bc1 = label62.BackColor;
                    c1 = label62.ForeColor;
                    label62.BackColor = Color.White;
                    label62.ForeColor = Color.White;
                    pre1 = player1; break;
                case 63:
                    bc1 = label63.BackColor;
                    c1 = label63.ForeColor;
                    label63.BackColor = Color.White;
                    label63.ForeColor = Color.White;
                    pre1 = player1; break;
                case 64:
                    bc1 = label64.BackColor;
                    c1 = label64.ForeColor;
                    label64.BackColor = Color.White;
                    label64.ForeColor = Color.White;
                    pre1 = player1; break;
                case 65:
                    bc1 = label65.BackColor;
                    c1 = label65.ForeColor;
                    label65.BackColor = Color.White;
                    label65.ForeColor = Color.White;
                    pre1 = player1; break;
                case 66:
                    bc1 = label66.BackColor;
                    c1 = label66.ForeColor;
                    label66.BackColor = Color.White;
                    label66.ForeColor = Color.White;
                    pre1 = player1; break;
                case 67:
                    bc1 = label67.BackColor;
                    c1 = label67.ForeColor;
                    label67.BackColor = Color.White;
                    label67.ForeColor = Color.White;
                    pre1 = player1; break;
                case 68:
                    bc1 = label68.BackColor;
                    c1 = label68.ForeColor;
                    label68.BackColor = Color.White;
                    label68.ForeColor = Color.White;
                    pre1 = player1; break;
                case 69:
                    bc1 = label69.BackColor;
                    c1 = label69.ForeColor;
                    label69.BackColor = Color.White;
                    label69.ForeColor = Color.White;
                    pre1 = player1; break;
                case 70:
                    bc1 = label70.BackColor;
                    c1 = label70.ForeColor;
                    label70.BackColor = Color.White;
                    label70.ForeColor = Color.White;
                    pre1 = player1; break;
                case 71:
                    bc1 = label71.BackColor;
                    c1 = label71.ForeColor;
                    label71.BackColor = Color.White;
                    label71.ForeColor = Color.White;
                    pre1 = player1; break;
                case 72:
                    bc1 = label72.BackColor;
                    c1 = label72.ForeColor;
                    label72.BackColor = Color.White;
                    label72.ForeColor = Color.White;
                    pre1 = player1; break;
                case 73:
                    bc1 = label73.BackColor;
                    c1 = label73.ForeColor;
                    label73.BackColor = Color.White;
                    label73.ForeColor = Color.White;
                    pre1 = player1; break;
                case 74:
                    bc1 = label74.BackColor;
                    c1 = label74.ForeColor;
                    label74.BackColor = Color.White;
                    label74.ForeColor = Color.White;
                    pre1 = player1; break;
                case 75:
                    bc1 = label75.BackColor;
                    c1 = label75.ForeColor;
                    label75.BackColor = Color.White;
                    label75.ForeColor = Color.White;
                    pre1 = player1; break;
                case 76:
                    bc1 = label76.BackColor;
                    c1 = label76.ForeColor;
                    label76.BackColor = Color.White;
                    label76.ForeColor = Color.White;
                    pre1 = player1; break;
                case 77:
                    bc1 = label77.BackColor;
                    c1 = label77.ForeColor;
                    label77.BackColor = Color.White;
                    label77.ForeColor = Color.White;
                    pre1 = player1; break;
                case 78:
                    bc1 = label78.BackColor;
                    c1 = label78.ForeColor;
                    label78.BackColor = Color.White;
                    label78.ForeColor = Color.White;
                    pre1 = player1; break;
                case 79:
                    bc1 = label79.BackColor;
                    c1 = label79.ForeColor;
                    label79.BackColor = Color.White;
                    label79.ForeColor = Color.White;
                    pre1 = player1; break;
                case 80:
                    bc1 = label80.BackColor;
                    c1 = label80.ForeColor;
                    label80.BackColor = Color.White;
                    label80.ForeColor = Color.White;
                    pre1 = player1; break;
                case 81:
                    bc1 = label81.BackColor;
                    c1 = label81.ForeColor;
                    label81.BackColor = Color.White;
                    label81.ForeColor = Color.White;
                    pre1 = player1; break;
                case 82:
                    bc1 = label82.BackColor;
                    c1 = label82.ForeColor;
                    label82.BackColor = Color.White;
                    label82.ForeColor = Color.White;
                    pre1 = player1; break;
                case 83:
                    bc1 = label83.BackColor;
                    c1 = label83.ForeColor;
                    label83.BackColor = Color.White;
                    label83.ForeColor = Color.White;
                    pre1 = player1; break;
                case 84:
                    bc1 = label84.BackColor;
                    c1 = label84.ForeColor;
                    label84.BackColor = Color.White;
                    label84.ForeColor = Color.White;
                    pre1 = player1; break;
                case 85:
                    bc1 = label85.BackColor;
                    c1 = label85.ForeColor;
                    label85.BackColor = Color.White;
                    label85.ForeColor = Color.White;
                    pre1 = player1; break;
                case 86:
                    bc1 = label86.BackColor;
                    c1 = label86.ForeColor;
                    label86.BackColor = Color.White;
                    label86.ForeColor = Color.White;
                    pre1 = player1; break;
                case 87:
                    bc1 = label87.BackColor;
                    c1 = label87.ForeColor;
                    label87.BackColor = Color.White;
                    label87.ForeColor = Color.White;
                    pre1 = player1; break;
                case 88:
                    bc1 = label88.BackColor;
                    c1 = label88.ForeColor;
                    label88.BackColor = Color.White;
                    label88.ForeColor = Color.White;
                    pre1 = player1; break;
                case 89:
                    bc1 = label89.BackColor;
                    c1 = label89.ForeColor;
                    label89.BackColor = Color.White;
                    label89.ForeColor = Color.White;
                    pre1 = player1; break;
                case 90:
                    bc1 = label90.BackColor;
                    c1 = label90.ForeColor;
                    label90.BackColor = Color.White;
                    label90.ForeColor = Color.White;
                    pre1 = player1; break;
                case 91:
                    bc1 = label91.BackColor;
                    c1 = label91.ForeColor;
                    label91.BackColor = Color.White;
                    label91.ForeColor = Color.White;
                    pre1 = player1; break;
                case 92:
                    bc1 = label92.BackColor;
                    c1 = label92.ForeColor;
                    label92.BackColor = Color.White;
                    label92.ForeColor = Color.White;
                    pre1 = player1; break;
                case 93:
                    bc1 = label93.BackColor;
                    c1 = label93.ForeColor;
                    label93.BackColor = Color.White;
                    label93.ForeColor = Color.White;
                    pre1 = player1; break;
                case 94:
                    bc1 = label94.BackColor;
                    c1 = label94.ForeColor;
                    label94.BackColor = Color.White;
                    label94.ForeColor = Color.White;
                    pre1 = player1; break;
                case 95:
                    bc1 = label95.BackColor;
                    c1 = label95.ForeColor;
                    label95.BackColor = Color.White;
                    label95.ForeColor = Color.White;
                    pre1 = player1; break;
                case 96:
                    bc1 = label96.BackColor;
                    c1 = label96.ForeColor;
                    label96.BackColor = Color.White;
                    label96.ForeColor = Color.White;
                    pre1 = player1; break;
                case 97:
                    bc1 = label97.BackColor;
                    c1 = label97.ForeColor;
                    label97.BackColor = Color.White;
                    label97.ForeColor = Color.White;
                    pre1 = player1; break;
                case 98:
                    bc1 = label98.BackColor;
                    c1 = label98.ForeColor;
                    label98.BackColor = Color.White;
                    label98.ForeColor = Color.White;
                    pre1 = player1; break;
                case 99:
                    bc1 = label99.BackColor;
                    c1 = label99.ForeColor;
                    label99.BackColor = Color.White;
                    label99.ForeColor = Color.White;
                    pre1 = player1; break;
                case 100:
                    bc1 = label100.BackColor;
                    c1 = label100.ForeColor;
                    label100.BackColor = Color.White;
                    label100.ForeColor = Color.White;
                    pre1 = player1; break;
            }
        }

        private void pl2()
        {
            player2 ++;
            switch (pre2)
            {
                case 0: break;
                case 1:
                    label1.BackColor = bc2;
                    label1.ForeColor = c2;
                    break;
                case 2:
                    label2.BackColor = bc2;
                    label2.ForeColor = c2;
                    break;
                case 3:
                    label3.BackColor = bc2;
                    label3.ForeColor = c2;
                    break;
                case 4:
                    label4.BackColor = bc2;
                    label4.ForeColor = c2;
                    break;
                case 5:
                    label5.BackColor = bc2;
                    label5.ForeColor = c2;
                    break;
                case 6:
                    label6.BackColor = bc2;
                    label6.ForeColor = c2;
                    break;
                case 7:
                    label7.BackColor = bc2;
                    label7.ForeColor = c2;
                    break;
                case 8:
                    label8.BackColor = bc2;
                    label8.ForeColor = c2;
                    break;
                case 9:
                    label9.BackColor = bc2;
                    label9.ForeColor = c2;
                    break;
                case 10:
                    label10.BackColor = bc2;
                    label10.ForeColor = c2;
                    break;
                case 11:
                    label11.BackColor = bc2;
                    label11.ForeColor = c2;
                    break;
                case 12:
                    label12.BackColor = bc2;
                    label12.ForeColor = c2;
                    break;
                case 13:
                    label13.BackColor = bc2;
                    label13.ForeColor = c2;
                    break;
                case 14:
                    label14.BackColor = bc2;
                    label14.ForeColor = c2;
                    break;
                case 15:
                    label15.BackColor = bc2;
                    label15.ForeColor = c2;
                    break;
                case 16:
                    label16.BackColor = bc2;
                    label16.ForeColor = c2;
                    break;
                case 17:
                    label17.BackColor = bc2;
                    label17.ForeColor = c2;
                    break;
                case 18:
                    label18.BackColor = bc2;
                    label18.ForeColor = c2;
                    break;
                case 19:
                    label19.BackColor = bc2;
                    label19.ForeColor = c2;
                    break;
                case 20:
                    label20.BackColor = bc2;
                    label20.ForeColor = c2;
                    break;
                case 21:
                    label21.BackColor = bc2;
                    label21.ForeColor = c2;
                    break;
                case 22:
                    label22.BackColor = bc2;
                    label22.ForeColor = c2;
                    break;
                case 23:
                    label23.BackColor = bc2;
                    label23.ForeColor = c2;
                    break;
                case 24:
                    label24.BackColor = bc2;
                    label24.ForeColor = c2;
                    break;
                case 25:
                    label25.BackColor = bc2;
                    label25.ForeColor = c2;
                    break;
                case 26:
                    label26.BackColor = bc2;
                    label26.ForeColor = c2;
                    break;
                case 27:
                    label27.BackColor = bc2;
                    label27.ForeColor = c2;
                    break;
                case 28:
                    label28.BackColor = bc2;
                    label28.ForeColor = c2;
                    break;
                case 29:
                    label29.BackColor = bc2;
                    label29.ForeColor = c2;
                    break;
                case 30:
                    label30.BackColor = bc2;
                    label30.ForeColor = c2;
                    break;
                case 31:
                    label31.BackColor = bc2;
                    label31.ForeColor = c2;
                    break;
                case 32:
                    label32.BackColor = bc2;
                    label32.ForeColor = c2;
                    break;
                case 33:
                    label33.BackColor = bc2;
                    label33.ForeColor = c2;
                    break;
                case 34:
                    label34.BackColor = bc2;
                    label34.ForeColor = c2;
                    break;
                case 35:
                    label35.BackColor = bc2;
                    label35.ForeColor = c2;
                    break;
                case 36:
                    label36.BackColor = bc2;
                    label36.ForeColor = c2;
                    break;
                case 37:
                    label37.BackColor = bc2;
                    label37.ForeColor = c2;
                    break;
                case 38:
                    label38.BackColor = bc2;
                    label38.ForeColor = c2;
                    break;
                case 39:
                    label39.BackColor = bc2;
                    label39.ForeColor = c2;
                    break;
                case 40:
                    label40.BackColor = bc2;
                    label40.ForeColor = c2;
                    break;
                case 41:
                    label41.BackColor = bc2;
                    label41.ForeColor = c2;
                    break;
                case 42:
                    label42.BackColor = bc2;
                    label42.ForeColor = c2;
                    break;
                case 43:
                    label43.BackColor = bc2;
                    label43.ForeColor = c2;
                    break;
                case 44:
                    label44.BackColor = bc2;
                    label44.ForeColor = c2;
                    break;
                case 45:
                    label45.BackColor = bc2;
                    label45.ForeColor = c2;
                    break;
                case 46:
                    label46.BackColor = bc2;
                    label46.ForeColor = c2;
                    break;
                case 47:
                    label47.BackColor = bc2;
                    label47.ForeColor = c2;
                    break;
                case 48:
                    label48.BackColor = bc2;
                    label48.ForeColor = c2;
                    break;
                case 49:
                    label49.BackColor = bc2;
                    label49.ForeColor = c2;
                    break;
                case 50:
                    label50.BackColor = bc2;
                    label50.ForeColor = c2;
                    break;
                case 51:
                    label51.BackColor = bc2;
                    label51.ForeColor = c2;
                    break;
                case 52:
                    label52.BackColor = bc2;
                    label52.ForeColor = c2;
                    break;
                case 53:
                    label53.BackColor = bc2;
                    label53.ForeColor = c2;
                    break;
                case 54:
                    label54.BackColor = bc2;
                    label54.ForeColor = c2;
                    break;
                case 55:
                    label55.BackColor = bc2;
                    label55.ForeColor = c2;
                    break;
                case 56:
                    label56.BackColor = bc2;
                    label56.ForeColor = c2;
                    break;
                case 57:
                    label57.BackColor = bc2;
                    label57.ForeColor = c2;
                    break;
                case 58:
                    label58.BackColor = bc2;
                    label58.ForeColor = c2;
                    break;
                case 59:
                    label59.BackColor = bc2;
                    label59.ForeColor = c2;
                    break;
                case 60:
                    label60.BackColor = bc2;
                    label60.ForeColor = c2;
                    break;
                case 61:
                    label61.BackColor = bc2;
                    label61.ForeColor = c2;
                    break;
                case 62:
                    label62.BackColor = bc2;
                    label62.ForeColor = c2;
                    break;
                case 63:
                    label63.BackColor = bc2;
                    label63.ForeColor = c2;
                    break;
                case 64:
                    label64.BackColor = bc2;
                    label64.ForeColor = c2;
                    break;
                case 65:
                    label65.BackColor = bc2;
                    label65.ForeColor = c2;
                    break;
                case 66:
                    label66.BackColor = bc2;
                    label66.ForeColor = c2;
                    break;
                case 67:
                    label67.BackColor = bc2;
                    label67.ForeColor = c2;
                    break;
                case 68:
                    label68.BackColor = bc2;
                    label68.ForeColor = c2;
                    break;
                case 69:
                    label69.BackColor = bc2;
                    label69.ForeColor = c2;
                    break;
                case 70:
                    label70.BackColor = bc2;
                    label70.ForeColor = c2;
                    break;
                case 71:
                    label71.BackColor = bc2;
                    label71.ForeColor = c2;
                    break;
                case 72:
                    label72.BackColor = bc2;
                    label72.ForeColor = c2;
                    break;
                case 73:
                    label73.BackColor = bc2;
                    label73.ForeColor = c2;
                    break;
                case 74:
                    label74.BackColor = bc2;
                    label74.ForeColor = c2;
                    break;
                case 75:
                    label75.BackColor = bc2;
                    label75.ForeColor = c2;
                    break;
                case 76:
                    label76.BackColor = bc2;
                    label76.ForeColor = c2;
                    break;
                case 77:
                    label77.BackColor = bc2;
                    label77.ForeColor = c2;
                    break;
                case 78:
                    label78.BackColor = bc2;
                    label78.ForeColor = c2;
                    break;
                case 79:
                    label79.BackColor = bc2;
                    label79.ForeColor = c2;
                    break;
                case 80:
                    label80.BackColor = bc2;
                    label80.ForeColor = c2;
                    break;
                case 81:
                    label81.BackColor = bc2;
                    label81.ForeColor = c2;
                    break;
                case 82:
                    label82.BackColor = bc2;
                    label82.ForeColor = c2;
                    break;
                case 83:
                    label83.BackColor = bc2;
                    label83.ForeColor = c2;
                    break;
                case 84:
                    label84.BackColor = bc2;
                    label84.ForeColor = c2;
                    break;
                case 85:
                    label85.BackColor = bc2;
                    label85.ForeColor = c2;
                    break;
                case 86:
                    label86.BackColor = bc2;
                    label86.ForeColor = c2;
                    break;
                case 87:
                    label87.BackColor = bc2;
                    label87.ForeColor = c2;
                    break;
                case 88:
                    label88.BackColor = bc2;
                    label88.ForeColor = c2;
                    break;
                case 89:
                    label89.BackColor = bc2;
                    label89.ForeColor = c2;
                    break;
                case 90:
                    label90.BackColor = bc2;
                    label90.ForeColor = c2;
                    break;
                case 91:
                    label91.BackColor = bc2;
                    label91.ForeColor = c2;
                    break;
                case 92:
                    label92.BackColor = bc2;
                    label92.ForeColor = c2;
                    break;
                case 93:
                    label93.BackColor = bc2;
                    label93.ForeColor = c2;
                    break;
                case 94:
                    label94.BackColor = bc2;
                    label94.ForeColor = c2;
                    break;
                case 95:
                    label95.BackColor = bc2;
                    label95.ForeColor = c2;
                    break;
                case 96:
                    label96.BackColor = bc2;
                    label96.ForeColor = c2;
                    break;
                case 97:
                    label97.BackColor = bc2;
                    label97.ForeColor = c2;
                    break;
                case 98:
                    label98.BackColor = bc2;
                    label98.ForeColor = c2;
                    break;
                case 99:
                    label99.BackColor = bc2;
                    label99.ForeColor = c2;
                    break;
                case 100:
                    label100.BackColor = bc2;
                    label100.ForeColor = c2;
                    break;
            }

            switch (player2)
            {
                case 0: break;
                case 1:
                    bc2 = label1.BackColor;
                    c2 = label1.ForeColor;
                    label1.BackColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 2:
                    bc2 = label2.BackColor;
                    c2 = label2.ForeColor;
                    label2.BackColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 3:
                    bc2 = label3.BackColor;
                    c2 = label3.ForeColor;
                    label3.BackColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 4:
                    bc2 = label4.BackColor;
                    c2 = label4.ForeColor;
                    label4.BackColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 5:
                    bc2 = label5.BackColor;
                    c2 = label5.ForeColor;
                    label5.BackColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 6:
                    bc2 = label6.BackColor;
                    c2 = label6.ForeColor;
                    label6.BackColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 7:
                    bc2 = label7.BackColor;
                    c2 = label7.ForeColor;
                    label7.BackColor = Color.Black;
                    label7.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 8:
                    bc2 = label8.BackColor;
                    c2 = label8.ForeColor;
                    label8.BackColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 9:
                    bc2 = label9.BackColor;
                    c2 = label9.ForeColor;
                    label9.BackColor = Color.Black;
                    label9.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 10:
                    bc2 = label10.BackColor;
                    c2 = label10.ForeColor;
                    label10.BackColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 11:
                    bc2 = label11.BackColor;
                    c2 = label11.ForeColor;
                    label11.BackColor = Color.Black;
                    label11.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 12:
                    bc2 = label12.BackColor;
                    c2 = label12.ForeColor;
                    label12.BackColor = Color.Black;
                    label12.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 13:
                    bc2 = label13.BackColor;
                    c2 = label13.ForeColor;
                    label13.BackColor = Color.Black;
                    label13.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 14:
                    bc2 = label14.BackColor;
                    c2 = label14.ForeColor;
                    label14.BackColor = Color.Black;
                    label14.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 15:
                    bc2 = label15.BackColor;
                    c2 = label15.ForeColor;
                    label15.BackColor = Color.Black;
                    label15.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 16:
                    bc2 = label16.BackColor;
                    c2 = label16.ForeColor;
                    label16.BackColor = Color.Black;
                    label16.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 17:
                    bc2 = label17.BackColor;
                    c2 = label17.ForeColor;
                    label17.BackColor = Color.Black;
                    label17.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 18:
                    bc2 = label18.BackColor;
                    c2 = label18.ForeColor;
                    label18.BackColor = Color.Black;
                    label18.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 19:
                    bc2 = label19.BackColor;
                    c2 = label19.ForeColor;
                    label19.BackColor = Color.Black;
                    label19.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 20:
                    bc2 = label20.BackColor;
                    c2 = label20.ForeColor;
                    label20.BackColor = Color.Black;
                    label20.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 21:
                    bc2 = label21.BackColor;
                    c2 = label21.ForeColor;
                    label21.BackColor = Color.Black;
                    label21.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 22:
                    bc2 = label22.BackColor;
                    c2 = label22.ForeColor;
                    label22.BackColor = Color.Black;
                    label22.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 23:
                    bc2 = label23.BackColor;
                    c2 = label23.ForeColor;
                    label23.BackColor = Color.Black;
                    label23.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 24:
                    bc2 = label24.BackColor;
                    c2 = label24.ForeColor;
                    label24.BackColor = Color.Black;
                    label24.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 25:
                    bc2 = label25.BackColor;
                    c2 = label25.ForeColor;
                    label25.BackColor = Color.Black;
                    label25.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 26:
                    bc2 = label26.BackColor;
                    c2 = label26.ForeColor;
                    label26.BackColor = Color.Black;
                    label26.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 27:
                    bc2 = label27.BackColor;
                    c2 = label27.ForeColor;
                    label27.BackColor = Color.Black;
                    label27.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 28:
                    bc2 = label28.BackColor;
                    c2 = label28.ForeColor;
                    label28.BackColor = Color.Black;
                    label28.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 29:
                    bc2 = label29.BackColor;
                    c2 = label29.ForeColor;
                    label29.BackColor = Color.Black;
                    label29.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 30:
                    bc2 = label30.BackColor;
                    c2 = label30.ForeColor;
                    label30.BackColor = Color.Black;
                    label30.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 31:
                    bc2 = label31.BackColor;
                    c2 = label31.ForeColor;
                    label31.BackColor = Color.Black;
                    label31.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 32:
                    bc2 = label32.BackColor;
                    c2 = label32.ForeColor;
                    label32.BackColor = Color.Black;
                    label32.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 33:
                    bc2 = label33.BackColor;
                    c2 = label33.ForeColor;
                    label33.BackColor = Color.Black;
                    label33.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 34:
                    bc2 = label34.BackColor;
                    c2 = label34.ForeColor;
                    label34.BackColor = Color.Black;
                    label34.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 35:
                    bc2 = label35.BackColor;
                    c2 = label35.ForeColor;
                    label35.BackColor = Color.Black;
                    label35.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 36:
                    bc2 = label36.BackColor;
                    c2 = label36.ForeColor;
                    label36.BackColor = Color.Black;
                    label36.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 37:
                    bc2 = label37.BackColor;
                    c2 = label37.ForeColor;
                    label37.BackColor = Color.Black;
                    label37.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 38:
                    bc2 = label38.BackColor;
                    c2 = label38.ForeColor;
                    label38.BackColor = Color.Black;
                    label38.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 39:
                    bc2 = label39.BackColor;
                    c2 = label39.ForeColor;
                    label39.BackColor = Color.Black;
                    label39.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 40:
                    bc2 = label40.BackColor;
                    c2 = label40.ForeColor;
                    label40.BackColor = Color.Black;
                    label40.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 41:
                    bc2 = label41.BackColor;
                    c2 = label41.ForeColor;
                    label41.BackColor = Color.Black;
                    label41.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 42:
                    bc2 = label42.BackColor;
                    c2 = label42.ForeColor;
                    label42.BackColor = Color.Black;
                    label42.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 43:
                    bc2 = label43.BackColor;
                    c2 = label43.ForeColor;
                    label43.BackColor = Color.Black;
                    label43.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 44:
                    bc2 = label44.BackColor;
                    c2 = label44.ForeColor;
                    label44.BackColor = Color.Black;
                    label44.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 45:
                    bc2 = label45.BackColor;
                    c2 = label45.ForeColor;
                    label45.BackColor = Color.Black;
                    label45.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 46:
                    bc2 = label46.BackColor;
                    c2 = label46.ForeColor;
                    label46.BackColor = Color.Black;
                    label46.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 47:
                    bc2 = label47.BackColor;
                    c2 = label47.ForeColor;
                    label47.BackColor = Color.Black;
                    label47.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 48:
                    bc2 = label48.BackColor;
                    c2 = label48.ForeColor;
                    label48.BackColor = Color.Black;
                    label48.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 49:
                    bc2 = label49.BackColor;
                    c2 = label49.ForeColor;
                    label49.BackColor = Color.Black;
                    label49.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 50:
                    bc2 = label50.BackColor;
                    c2 = label50.ForeColor;
                    label50.BackColor = Color.Black;
                    label50.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 51:
                    bc2 = label51.BackColor;
                    c2 = label51.ForeColor;
                    label51.BackColor = Color.Black;
                    label51.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 52:
                    bc2 = label52.BackColor;
                    c2 = label52.ForeColor;
                    label52.BackColor = Color.Black;
                    label52.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 53:
                    bc2 = label53.BackColor;
                    c2 = label53.ForeColor;
                    label53.BackColor = Color.Black;
                    label53.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 54:
                    bc2 = label54.BackColor;
                    c2 = label54.ForeColor;
                    label54.BackColor = Color.Black;
                    label54.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 55:
                    bc2 = label55.BackColor;
                    c2 = label55.ForeColor;
                    label55.BackColor = Color.Black;
                    label55.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 56:
                    bc2 = label56.BackColor;
                    c2 = label56.ForeColor;
                    label56.BackColor = Color.Black;
                    label56.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 57:
                    bc2 = label57.BackColor;
                    c2 = label57.ForeColor;
                    label57.BackColor = Color.Black;
                    label57.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 58:
                    bc2 = label58.BackColor;
                    c2 = label58.ForeColor;
                    label58.BackColor = Color.Black;
                    label58.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 59:
                    bc2 = label59.BackColor;
                    c2 = label59.ForeColor;
                    label59.BackColor = Color.Black;
                    label59.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 60:
                    bc2 = label60.BackColor;
                    c2 = label60.ForeColor;
                    label60.BackColor = Color.Black;
                    label60.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 61:
                    bc2 = label61.BackColor;
                    c2 = label61.ForeColor;
                    label61.BackColor = Color.Black;
                    label61.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 62:
                    bc2 = label62.BackColor;
                    c2 = label62.ForeColor;
                    label62.BackColor = Color.Black;
                    label62.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 63:
                    bc2 = label63.BackColor;
                    c2 = label63.ForeColor;
                    label63.BackColor = Color.Black;
                    label63.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 64:
                    bc2 = label64.BackColor;
                    c2 = label64.ForeColor;
                    label64.BackColor = Color.Black;
                    label64.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 65:
                    bc2 = label65.BackColor;
                    c2 = label65.ForeColor;
                    label65.BackColor = Color.Black;
                    label65.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 66:
                    bc2 = label66.BackColor;
                    c2 = label66.ForeColor;
                    label66.BackColor = Color.Black;
                    label66.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 67:
                    bc2 = label67.BackColor;
                    c2 = label67.ForeColor;
                    label67.BackColor = Color.Black;
                    label67.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 68:
                    bc2 = label68.BackColor;
                    c2 = label68.ForeColor;
                    label68.BackColor = Color.Black;
                    label68.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 69:
                    bc2 = label69.BackColor;
                    c2 = label69.ForeColor;
                    label69.BackColor = Color.Black;
                    label69.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 70:
                    bc2 = label70.BackColor;
                    c2 = label70.ForeColor;
                    label70.BackColor = Color.Black;
                    label70.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 71:
                    bc2 = label71.BackColor;
                    c2 = label71.ForeColor;
                    label71.BackColor = Color.Black;
                    label71.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 72:
                    bc2 = label72.BackColor;
                    c2 = label72.ForeColor;
                    label72.BackColor = Color.Black;
                    label72.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 73:
                    bc2 = label73.BackColor;
                    c2 = label73.ForeColor;
                    label73.BackColor = Color.Black;
                    label73.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 74:
                    bc2 = label74.BackColor;
                    c2 = label74.ForeColor;
                    label74.BackColor = Color.Black;
                    label74.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 75:
                    bc2 = label75.BackColor;
                    c2 = label75.ForeColor;
                    label75.BackColor = Color.Black;
                    label75.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 76:
                    bc2 = label76.BackColor;
                    c2 = label76.ForeColor;
                    label76.BackColor = Color.Black;
                    label76.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 77:
                    bc2 = label77.BackColor;
                    c2 = label77.ForeColor;
                    label77.BackColor = Color.Black;
                    label77.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 78:
                    bc2 = label78.BackColor;
                    c2 = label78.ForeColor;
                    label78.BackColor = Color.Black;
                    label78.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 79:
                    bc2 = label79.BackColor;
                    c2 = label79.ForeColor;
                    label79.BackColor = Color.Black;
                    label79.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 80:
                    bc2 = label80.BackColor;
                    c2 = label80.ForeColor;
                    label80.BackColor = Color.Black;
                    label80.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 81:
                    bc2 = label81.BackColor;
                    c2 = label81.ForeColor;
                    label81.BackColor = Color.Black;
                    label81.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 82:
                    bc2 = label82.BackColor;
                    c2 = label82.ForeColor;
                    label82.BackColor = Color.Black;
                    label82.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 83:
                    bc2 = label83.BackColor;
                    c2 = label83.ForeColor;
                    label83.BackColor = Color.Black;
                    label83.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 84:
                    bc2 = label84.BackColor;
                    c2 = label84.ForeColor;
                    label84.BackColor = Color.Black;
                    label84.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 85:
                    bc2 = label85.BackColor;
                    c2 = label85.ForeColor;
                    label85.BackColor = Color.Black;
                    label85.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 86:
                    bc2 = label86.BackColor;
                    c2 = label86.ForeColor;
                    label86.BackColor = Color.Black;
                    label86.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 87:
                    bc2 = label87.BackColor;
                    c2 = label87.ForeColor;
                    label87.BackColor = Color.Black;
                    label87.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 88:
                    bc2 = label88.BackColor;
                    c2 = label88.ForeColor;
                    label88.BackColor = Color.Black;
                    label88.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 89:
                    bc2 = label89.BackColor;
                    c2 = label89.ForeColor;
                    label89.BackColor = Color.Black;
                    label89.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 90:
                    bc2 = label90.BackColor;
                    c2 = label90.ForeColor;
                    label90.BackColor = Color.Black;
                    label90.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 91:
                    bc2 = label91.BackColor;
                    c2 = label91.ForeColor;
                    label91.BackColor = Color.Black;
                    label91.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 92:
                    bc2 = label92.BackColor;
                    c2 = label92.ForeColor;
                    label92.BackColor = Color.Black;
                    label92.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 93:
                    bc2 = label93.BackColor;
                    c2 = label93.ForeColor;
                    label93.BackColor = Color.Black;
                    label93.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 94:
                    bc2 = label94.BackColor;
                    c2 = label94.ForeColor;
                    label94.BackColor = Color.Black;
                    label94.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 95:
                    bc2 = label95.BackColor;
                    c2 = label95.ForeColor;
                    label95.BackColor = Color.Black;
                    label95.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 96:
                    bc2 = label96.BackColor;
                    c2 = label96.ForeColor;
                    label96.BackColor = Color.Black;
                    label96.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 97:
                    bc2 = label97.BackColor;
                    c2 = label97.ForeColor;
                    label97.BackColor = Color.Black;
                    label97.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 98:
                    bc2 = label98.BackColor;
                    c2 = label98.ForeColor;
                    label98.BackColor = Color.Black;
                    label98.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 99:
                    bc2 = label99.BackColor;
                    c2 = label99.ForeColor;
                    label99.BackColor = Color.Black;
                    label99.ForeColor = Color.Black;
                    pre2 = player2; break;
                case 100:
                    bc2 = label100.BackColor;
                    c2 = label100.ForeColor;
                    label100.BackColor = Color.Black;
                    label100.ForeColor = Color.Black;
                    pre2 = player2; break;
            }
        }

        private void dice()
        {
            switch(n)
            {
                case 1:
                    lb1_1.Visible = true;
                    lb4_1.Visible = false;
                    lb4_2.Visible = false;
                    lb4_3.Visible = false;
                    lb4_4.Visible = false;
                    lb6_1.Visible = false;
                    lb6_2.Visible = false;
                    lb2_1.Visible = false;
                    lb2_2.Visible = false;
                    break;
                case 2:
                    lb1_1.Visible = false;
                    lb4_1.Visible = false;
                    lb4_2.Visible = false;
                    lb4_3.Visible = false;
                    lb4_4.Visible = false;
                    lb6_1.Visible = false;
                    lb6_2.Visible = false;
                    lb2_1.Visible = true;
                    lb2_2.Visible = true;
                    break;
                case 3:
                    lb1_1.Visible = true;
                    lb4_1.Visible = false;
                    lb4_2.Visible = false;
                    lb4_3.Visible = false;
                    lb4_4.Visible = false;
                    lb6_1.Visible = true;
                    lb6_2.Visible = true;
                    lb2_1.Visible = false;
                    lb2_2.Visible = false;
                    break;
                case 4:
                    lb1_1.Visible = false;
                    lb4_1.Visible = true;
                    lb4_2.Visible = true;
                    lb4_3.Visible = true;
                    lb4_4.Visible = true;
                    lb6_1.Visible = false;
                    lb6_2.Visible = false;
                    lb2_1.Visible = false;
                    lb2_2.Visible = false;
                    break;
                case 5:
                    lb1_1.Visible = true;
                    lb4_1.Visible = true;
                    lb4_2.Visible = true;
                    lb4_3.Visible = true;
                    lb4_4.Visible = true;
                    lb6_1.Visible = false;
                    lb6_2.Visible = false;
                    lb2_1.Visible = false;
                    lb2_2.Visible = false;
                    break;
                case 6:
                    lb1_1.Visible = false;
                    lb4_1.Visible = true;
                    lb4_2.Visible = true;
                    lb4_3.Visible = true;
                    lb4_4.Visible = true;
                    lb6_1.Visible = true;
                    lb6_2.Visible = true;
                    lb2_1.Visible = false;
                    lb2_2.Visible = false;
                    break;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch(credit)
            {
                case 0:
                    lb_Credits.ForeColor = Color.Red;          credit++;   break;
                case 1:
                    lb_Credits.ForeColor = Color.Lime;         credit++;   break;
                case 2:
                    lb_Credits.ForeColor = Color.Yellow;       credit++;   break;
                case 3:
                    lb_Credits.ForeColor = Color.LightBlue;    credit=0;   break;
            }
        }

        private void checks()
        {
            switch (player1)
            {
                case 1:
                    player1 = 37;   pl1();  break;
                case 4:
                    player1 = 13;   pl1();  break;
                case 9:
                    player1 = 30;   pl1();  break;
                case 17:
                    player1 = 6;    pl1();  break;
                case 21:
                    player1 = 41;   pl1();  break;
                case 28:
                    player1 = 83;   pl1();  break;
                case 51:
                    player1 = 66;   pl1();  break;
                case 54:
                    player1 = 33;   pl1();  break;
                case 62:
                    player1 = 18;   pl1();  break;
                case 64:
                    player1 = 59;   pl1();  break;
                case 72:
                    player1 = 90;   pl1();  break;
                case 80:
                    player1 = 98;   pl1();  break;
                case 87:
                    player1 = 23;   pl1();  break;
                case 93:
                    player1 = 72;   pl1();  break;
                case 95:
                    player1 = 74;   pl1();  break;
                case 98:
                    player1 = 78;   pl1();  break;
                default:
                    break;
            }
            switch (player2)
            {
                case 1:
                    player2 = 37;   pl2();  break;
                case 4:
                    player2 = 13;   pl2();  break;
                case 9:
                    player2 = 30;   pl2();  break;
                case 17:
                    player2 = 6;    pl2();  break;
                case 21:
                    player2 = 41;   pl2();  break;
                case 28:
                    player2 = 83;   pl2();  break;
                case 51:
                    player2 = 66;   pl2();  break;
                case 54:
                    player2 = 33;   pl2();  break;
                case 62:
                    player2 = 18;   pl2();  break;
                case 64:
                    player2 = 59;   pl2();  break;
                case 72:
                    player2 = 90;   pl2();  break;
                case 80:
                    player2 = 98;   pl2();  break;
                case 87:
                    player2 = 23;   pl2();  break;
                case 93:
                    player2 = 72;   pl2();  break;
                case 95:
                    player2 = 74;   pl2();  break;
                case 98:
                    player2 = 78;   pl2();  break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                pl1();
            }
            else
            {
                pl2();
            }
            if (i == n-1)
            {
                checks();
                timer1.Stop();
                button1.Enabled = true;

                if (radioButton1.Checked == true)
                {
                    radioButton2.Checked = true;
                    if (player1 == player2)
                    {
                        bc1 = Color.LightPink;
                        c1 = Color.Black;
                    }
                }
                else
                {
                    radioButton1.Checked = true;
                    if (player1 == player2)
                    {
                        bc2 = Color.LightPink;
                        c2 = Color.Black;
                    }
                }
            }
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "c:\\windows\\media\\Windows Default.wav";
            player.Play();
            i++;
        }

        Color bc1, bc2, c1, c2;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string rand = Convert.ToString(random.Next(1, 7));
            textBox1.Text = rand;
            n = int.Parse(rand);
            dice();

            if (radioButton1.Checked == true)
            {
                i = 0;
                timer1.Start();
                button1.Enabled = false;
            }
            else
            {
                i = 0;
                timer1.Start();
                button1.Enabled = false;
            }

            if (player1 >= 100)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "c:\\windows\\media\\tada.wav";
                player.Load();
                player.PlaySync();
                MessageBox.Show("Player 1 (White) win the game...");

                DialogResult dialog = MessageBox.Show("Do you want to try again?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            else if(player2 >= 100)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "c:\\windows\\media\\tada.wav";
                player.Load();
                player.PlaySync();
                MessageBox.Show("Player 2 (Black) win the game...");

                DialogResult dialog = MessageBox.Show("Do you want to try again?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}