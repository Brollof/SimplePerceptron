using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        float xmin, xmax, ymin, ymax;
        Trainer[] training = new Trainer[300];
        Perceptron perc;
        int count = 0;
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();

            xmin = -canvas.Width / 2;
            xmax = canvas.Width / 2;
            ymin = -canvas.Height / 2;
            ymax = canvas.Height / 2;

            t.Tick += UpdateScreen;
            t.Tick += RefreshLabel;
            t.Interval = 10;
            t.Start();

            perc = new Perceptron(3, (float)0.0001);
            for (int i = 0; i < training.Length; i++)
            {
                float x = Perceptron.r.Next((int)xmin, (int)xmax);
                float y = Perceptron.r.Next((int)ymin, (int)ymax);
                int answer = 1;
                if (y < f(x)) answer = -1;
                training[i] = new Trainer(x, y, answer);
            }
        }

        private void RefreshLabel(object sender, EventArgs e)
        {
            labWeights.Text = "Weights: x: " + perc.GetWeights()[0] + ", y: " + perc.GetWeights()[1];
            labLr.Text = perc.learningRate.ToString();
        }

        void UpdateScreen(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        float map(float s, float a1, float a2, float b1, float b2)
        {
            return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
        }

        Point CartesianToDefault(float x, float y)
        {
            float x1 = (int)map(x,-canvas.Width/2, canvas.Width/2, 0, canvas.Width);
            float y1 = (int)map(y, canvas.Height/2, -canvas.Height/2, 0, canvas.Height);
            return new Point((int)x1, (int)y1);
        }

        float f(float x)
        {
            return (float)(1 * x);
        }

        private void DrawBrain(Graphics g)
        {
            float[] weights = perc.GetWeights();
            float x1 = xmin;
            float y1 = (-weights[2] - weights[0] * x1) / weights[1];
            float x2 = xmax;
            float y2 = (-weights[2] - weights[0] * x2) / weights[1];
            g.DrawLine(Pens.Black, CartesianToDefault(x1, y1), CartesianToDefault(x2, y2));
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.DrawLine(Pens.Black, CartesianToDefault(xmin, f(xmin)), CartesianToDefault(xmax, f(xmax)));

            DrawBrain(g);

            perc.Train(training[count].inputs, training[count].answer);
            count = (count + 1) % training.Length;

            // Draw all the points based on what the Perceptron would "guess"
            // Does not use the "known" correct answer
            for (int i = 0; i < count; i++)
            {
                int guess = perc.Guess(training[i].inputs);
                Point p = CartesianToDefault(training[i].inputs[0], training[i].inputs[1]);
                if (guess > 0) g.DrawEllipse(Pens.Blue, p.X, p.Y, 8, 8);
                else g.FillEllipse(Brushes.Blue, p.X, p.Y, 8, 8);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            perc.learningRate = map((float)trackBar1.Value, (float)trackBar1.Minimum, (float)trackBar1.Maximum, (float)0.00001, (float)0.1);
        }
    }
}
