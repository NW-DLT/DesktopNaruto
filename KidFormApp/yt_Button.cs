using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KidFormApp
{
    public class yt_Button : Button
    {
        private StringFormat SF = new StringFormat();

        private bool MouseEntered = false;
        private bool MousePressed = false;

        private bool roundingEnable = true;
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Refresh();
            }
        }
        private int roundingPercent = 100;
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if(value >= 0 && value <= 100)
                {
                    roundingPercent = value;

                    Refresh();
                }
            }
        }
        public yt_Button()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100, 30);

            BackColor = Color.Purple;
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(-1, -1, Width, Height);

            float roundingValue = 0.1f;
            if(RoundingEnable && roundingPercent > 0)
            {
                roundingValue = Height / 200f * roundingPercent;
            }
            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundingValue);

            graph.DrawPath(new Pen(BackColor), rectPath);
            graph.FillPath(new SolidBrush(BackColor), rectPath);

            graph.SetClip(rectPath);

            Region = new Region(rectPath);

            graph.DrawString(Text, Font,new SolidBrush(ForeColor), rect, SF);

            if (MouseEntered)
            {
                graph.DrawPath(new Pen(Color.FromArgb(60, Color.White)), rectPath);
                graph.FillPath(new SolidBrush(Color.FromArgb(60, Color.White)), rectPath);
            }
            if (MousePressed)
            {
                graph.DrawPath(new Pen(Color.FromArgb(30, Color.White)), rectPath);
                graph.FillPath(new SolidBrush(Color.FromArgb(30, Color.White)), rectPath);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;

            Invalidate();
        }
    }
}
