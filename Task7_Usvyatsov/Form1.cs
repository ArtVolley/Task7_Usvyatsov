using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7_Usvyatsov
{
    public partial class Form1 : Form
    {
        private readonly int Width;
        private readonly int Height;
        private double scaleY = 4;
        private double scaleX = 0.5;
        private double ei, es, x_, d, x_changed;
        private double def = 100000;
        private int scaleAll = 10000;


        public Form1()
        {
            InitializeComponent();

            Width = pxGraph.Width;
            Height = pxGraph.Height;

            teEi.Text = "0,006";
            teEs.Text = "0,055";
            teX_.Text = "0,026";
            teD.Text = "0,012";

            teEi.BackColor = Color.Red;
            teEs.BackColor = Color.Red;
            teD.BackColor = Color.Blue;

            buDraw.Click += BuDraw_Click;
        }

        private void BuDraw_Click(object sender, EventArgs e)
        {
            // read input
            ei = Convert.ToDouble(teEi.Text) * scaleAll;
            es = Convert.ToDouble(teEs.Text) * scaleAll;
            x_ = Convert.ToDouble(teX_.Text) * scaleAll;
            d = Convert.ToDouble(teD.Text);

            // graphics tools
            Graphics gGraph = pxGraph.CreateGraphics();
            Graphics gGraphChanged = pxGraphChanged.CreateGraphics();
            gGraph.Clear(Color.White);
            gGraphChanged.Clear(Color.White);

            Pen pGrid = new Pen(Color.LightGray);
            Pen pGraph = new Pen(Color.Black);
            Pen pE = new Pen(Color.Red);
            Pen pD = new Pen(Color.Blue);

            // draw 
            gGraph.DrawString("Начальное расположение", new Font("Arial", 10), Brushes.Black, 2, 2);

            DrawGrid(gGraph, pGrid);
            DrawGraph(gGraph, pGraph, x_);
            DrawD(gGraph, pD, x_);
            DrawE(gGraph, pE);

            // changed
            x_changed = x_ + ei - (x_ - d * scaleAll * 3);
            grOutChanged.Text = "Выходные данные при x (ср. зн.) = " + x_changed / scaleAll;

            gGraphChanged.DrawString("Расположение после подналадки", new Font("Arial", 10), Brushes.Black, 2, 2);

            DrawGrid(gGraphChanged, pGrid);
            DrawGraph(gGraphChanged, pGraph, x_changed);
            DrawD(gGraphChanged, pD, x_changed);
            DrawE(gGraphChanged, pE);

            // output
            teOk.Text = Fok(x_);
            teFix.Text = Ffix(x_);
            teUnfix.Text = Funfix(x_);
            teOkChanged.Text = Fok(x_changed);
            teFixChanged.Text = Ffix(x_changed);
        }


        // DRAWs
        private void DrawGraph(Graphics g, Pen p, double x_)
        {
            double xMin = -10000;
            double xMax = 10000;
            double step = (xMax - xMin) / def; 
            double x1 = xMin, x2;
            double y1 = FunctionGraph(x1, x_), y2;
            for (int i = 0; i < def; i++)   
            {
                x2 = x1 + step;
                y2 = - FunctionGraph(x2, x_);
                g.DrawLine(p, (int)(x1 * scaleX) + Width / 4, (int)(y1 * scaleY) + Height * 3 / 4, 
                              (int)(x2 * scaleX) + Width / 4, (int)(y2 * scaleY) + Height * 3 / 4);
                x1 = x2;
                y1 = y2;
            }
            g.DrawLine(p, (int)((x_) * scaleX) + Width / 4, 0, (int)((x_) * scaleX) + Width / 4, Height);
            g.DrawString(Convert.ToString(x_ / scaleAll), new Font("Arial", 7), Brushes.Black,
                (int)((x_) * scaleX) + Width / 4, Height * 1 / 12);
        }

        //const
        private void DrawE(Graphics g, Pen p)
        {
            g.DrawLine(p, (int)(ei * scaleX) + Width / 4, 0, (int)(ei * scaleX) + Width / 4, Height);
            g.DrawLine(p, (int)(es * scaleX) + Width / 4, 0, (int)(es * scaleX) + Width / 4, Height);
            g.DrawString(Convert.ToString(ei / scaleAll), new Font("Arial", 7), Brushes.Red,
                (int)(ei * scaleX) + Width / 4, Height * 4 / 5);
            g.DrawString(Convert.ToString(es / scaleAll), new Font("Arial", 7), Brushes.Red,
                (int)(es * scaleX) + Width / 4, Height * 4 / 5);
        }

        private void DrawD(Graphics g, Pen p, double x_)
        {
            g.DrawLine(p, (int)((3 * scaleAll * d + x_) * scaleX) + Width / 4, 0, (int)((3 * scaleAll * d + x_) * scaleX) + Width / 4, Height);
            g.DrawLine(p, (int)((-3 * scaleAll * d + x_) * scaleX) + Width / 4, 0, (int)((-3 * scaleAll * d + x_) * scaleX) + Width / 4, Height);
            g.DrawString("3σ", new Font("Arial", 7), Brushes.Blue, 
                (int)((3 * scaleAll * d + x_) * scaleX) + Width / 4, Height * 3 / 4);
            g.DrawString("-3σ", new Font("Arial", 7), Brushes.Blue,
                (int)((-3 * scaleAll * d + x_) * scaleX) + Width / 4, Height * 3 / 4);
        }

        //grid
        private void DrawGrid(Graphics g, Pen p)
        {
            g.DrawLine(p, 0, Height * 3 / 4, Width, Height * 3 / 4);
            g.DrawLine(p, Width / 4, 0, Width / 4, Height);
            g.DrawString("0", new Font("Arial", 7), Brushes.LightGray,
                Width / 4, Height * 3 / 4);
        }




        // FUNCs
        private double FunctionGraph(double x, double x_)
        {
            return (1 / (d * Math.Sqrt(2 * Math.PI))) * Math.Pow(Math.E, -Math.Pow(x - x_, 2) / 2 * Math.Pow(d, 2));
        }

        private double F(double z0, double z)
        {
            double s = z - z0;
            double h = s / def;
            double step = s / def;
            double result = 0;
            for (int i = 0; i < def; i++)
            {
                double x = h * (Math.Pow(Math.E, -Math.Pow(step + z0, 2) / 2));
                if (x < 0)
                {
                    x = -x;
                }
                result += x;
                step += h;
            }

            result = 1 / Math.Sqrt(2 * Math.PI) * result;
            if (z > 0)
            {
                return result;
            }
            else
            {
                return -result;
            }
        }

        private string Fok(double x)
        {
            return Convert.ToString( (F(0, (es - x) / (d * scaleAll)) - F(0, (ei - x) / (d * scaleAll)) )* 100 );
        }

        private string Funfix(double x)
        {
            return Convert.ToString((F(0, (ei - x) / (d * scaleAll)) - F(0, -3)) * 100);
        }

        private string Ffix(double x)
        {
            return Convert.ToString((F(0, 3) - F(0, (es - x) / (d * scaleAll))) * 100);
        }
    }
}
