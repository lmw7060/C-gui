﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest05_Paint
{
    public partial class frmPaint : Form
    {
        static float PenWidth = 1.0f;
        Graphics g = null;
        Pen pen = new Pen(Color.Red, PenWidth);
        Brush brush = null;
        public frmPaint()
        {
            InitializeComponent();
            Canvas_Resize(null, null);
            g = Canvas.CreateGraphics();
            //sbLabel2.Text = $"㈜{Canvas.Size.Width} X {Canvas.Size.Height}      ";
        }
        Point p1, p2, p3;
        Point cp1, cp2, cp3;
        int DrawMethod = 0;     //0:free, 1:line, 2:circle
        bool DrawMode = false;
        private void Canvas_Resize(object sender, EventArgs e)
        {
            sbLabel2.Text = $"㈜{Canvas.Size.Width} X {Canvas.Size.Height}      ";
        }
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = new Point(e.X, e.Y);
            p3 = p1;
            cp1 = ((Control)sender).PointToScreen(p1);
            cp3 = cp1;
            DrawMode = true;
            //g.DrawLine(pen, e.Location, new Point(e.X+50,e.Y));
        }
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {   
            if(DrawMethod ==1)
            {
                g.DrawLine(pen, p1, new Point(e.X, e.Y));
            }
            DrawMode = false;
        }
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            sbLabel1.Text = $"※{e.X}, {e.Y}      ";
            if (DrawMode)
            {
             p2 = new Point(e.X, e.Y);
                switch(DrawMethod)
                {
                    case 0: //free draw
                        g.DrawLine(pen, p1, p2);
                        p1 = p2;
                        break;
                    case 1: //line draw
                        Point cp2 = ((Control)sender).PointToScreen(p2);
                        ControlPaint.DrawReversibleLine(cp1, cp3, DefaultBackColor);
                        ControlPaint.DrawReversibleLine(cp1, cp2, DefaultBackColor);
                        cp3 = cp2;
                        break;
                    case 2:
                        /*if(e.Button == MouseButtons.Left)
                        {
                           if(e.X > p2.X) 
                            {
                                if(e.Y > p2.Y)
                                {
                                    g.DrawEllipse(pen, p2.X, p2.Y, DefaultBackColor);
                                }
                            }
                        }*/
                        break;
                    default: break;
                }
            }
        }
        private void mnuEraser_Click(object sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
        }
        private void mnuFree_Click(object sender, EventArgs e)
        {
            DrawMethod= 0;
        }
        private void mnuLine_Click(object sender, EventArgs e)
        {
            DrawMethod = 1;
        }
        private void mnuCircle_Click(object sender, EventArgs e)
        {
            DrawMethod= 2;
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            //if(g == null) g = e.Graphics;
        }
    }
}
