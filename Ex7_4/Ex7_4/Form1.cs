﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Ex7_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen;
            Point point = new Point(10, 10);
            Size sizeLine = new Size(0, 150);
            Size sizeOff = new Size(30, 0);
            pen = Pens.LimeGreen;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen = SystemPens.MenuText;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen = new Pen(Color.Red);
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen = new Pen(Color.Red, 8);
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen.DashStyle = DashStyle.Dash;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen.DashStyle = DashStyle.Dot;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen.DashStyle = DashStyle.Solid;
            pen.StartCap = LineCap.Round;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen.EndCap = LineCap.Triangle;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen.DashPattern = new float[] { 0.5f, 1f, 1.5f, 2f, 2.5f };
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
