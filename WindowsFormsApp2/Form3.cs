﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            int Number = GetNum();
            DisplayImg(Number);
        }
        private int GetNum()
        {
            Random random = new Random();
            int Number = random.Next(8, 15);
            return Number;
        }
        private void DisplayImg(int FUCK)
        {
            pictureBox1.Image = Image.FromFile("TheBigGay/image" + FUCK + ".png");
            //"You're sending number into FUCK"
        }

    }
}
