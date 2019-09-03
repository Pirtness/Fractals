using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fractal
{
    public partial class Form1 : Form
    {
        Graphics graph; //For Drawing
        Bitmap bmp;  //For Drawing
        int initialW, initialH; //initial width and height for zooming
        int zoom; //zoom scale
        
        /// <summary>
        /// Set values
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            graph = Graphics.FromImage(bmp);
            colorDialog1.AllowFullOpen = true;
            initialW = pictureBox.Width;
            initialH = pictureBox.Height;
            zoom = 1;
        }

        /// <summary>
        /// Max and min sizes of the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(1200, 700);
            this.MaximumSize = Screen.PrimaryScreen.Bounds.Size;
        }

        /// <summary>
        /// Changing start color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = startColor.BackColor;
            colorDialog1.ShowDialog();
            startColor.BackColor = colorDialog1.Color;

        }
        /// <summary>
        /// Changing end color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void endColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = endColor.BackColor;
            colorDialog1.ShowDialog();
            endColor.BackColor = colorDialog1.Color;
        }

        /// <summary>
        /// Draw Kantor Fractal
        /// </summary>
        private void DrawKantor()
        {
            Fractal fract = new Kantor((int)depth.Value, (float)distanceKant.Value*zoom, 20, 10, (pictureBox.Width-40), 10*zoom);
            fract.startColor = startColor.BackColor;
            fract.endColor = endColor.BackColor;
            fract.Draw(fract.x, fract.y, ref graph);
            pictureBox.Image = bmp;
        }
        /// <summary>
        /// Draw Kvasiclever
        /// </summary>
        private void DrawKvasi()
        {
            Fractal fract = new Kvasi((int)depth.Value, Direction(), pictureBox.Width/2, pictureBox.Height/2, 50*zoom);
            fract.startColor = startColor.BackColor;
            fract.endColor = endColor.BackColor;
            fract.Draw(fract.x, fract.y, ref graph);
            pictureBox.Image = bmp;
        }

        /// <summary>
        /// Draw S-Levi
        /// </summary>
        private void DrawLevi()
        {
            Fractal fract = new Levi((int)depth.Value, 6, pictureBox.Width / 2, pictureBox.Height / 2, 200*zoom);
            fract.startColor = startColor.BackColor;
            fract.endColor = endColor.BackColor;
            fract.Draw(fract.x, fract.y + fract.length / 3, ref graph);
            pictureBox.Image = bmp;
        }

        /// <summary>
        /// Finds out direction of Kvasiclever
        /// </summary>
        /// <returns></returns>
        private int Direction()
        {
            if (radioButton0.Checked)
                return 0;
            else if (radioButton1.Checked)
                return 1;
            else if (radioButton2.Checked)
                return 2;
            else if (radioButton3.Checked)
                return 3;
            return 0;
        }

        /// <summary>
        /// Button to start drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DrawFractal();
        }

        /// <summary>
        /// Analyses fractal params
        /// </summary>
        private void DrawFractal()
        {
            if (depth.Text == "")
                MessageBox.Show("Введите глубину!");
            else
            {
                Clean();
                if (Kantor.Checked)
                {
                    DrawKantor();
                }
                else if (Kvasi.Checked)
                {
                    DrawKvasi();
                }
                else if (Levi.Checked)
                {
                    DrawLevi();
                }
            }
        }

        /// <summary>
        /// Changing interface when Kantor is drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Kantor_CheckedChanged(object sender, EventArgs e)
        {
            labelDepth.Visible = true;
            depth.Visible = true;
            depth.Maximum = 6;
            distanceKant.Visible = true;
            labelPar.Visible = true;
            labelPar.Text = "Расстояние между отрезками";
            direction.Visible = false;
            startColor.Visible = true;
            endColor.Visible = true;
            labelCol1.Visible = true;
            labelCol2.Visible = true;
            start_Drawing.Visible = true;

            zoom1.Visible = true;
            zoom2.Visible = true;
            zoom3.Visible = true;
            zoom5.Visible = true;
            zoomLabel.Visible = true;
            saveButton.Visible = true;
            center.Visible = true;
        }

        /// <summary>
        /// Changing interface when Kvasiclever is drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Kvasi_CheckedChanged(object sender, EventArgs e)
        {
            labelDepth.Visible = true;
            depth.Visible = true;
            depth.Maximum = 10;
            distanceKant.Visible = false;
            labelPar.Visible = true;
            labelPar.Text = "Не задействованная точка касания";
            direction.Visible = true;
            startColor.Visible = true;
            endColor.Visible = true;
            labelCol1.Visible = true;
            labelCol2.Visible = true;
            start_Drawing.Visible = true;

            zoom1.Visible = true;
            zoom2.Visible = true;
            zoom3.Visible = true;
            zoom5.Visible = true;
            zoomLabel.Visible = true;
            saveButton.Visible = true;
            center.Visible = true;
        }

        /// <summary>
        /// Changing interface when S-Levi is drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Levi_CheckedChanged(object sender, EventArgs e)
        {
            labelDepth.Visible = true;
            depth.Visible = true;
            depth.Maximum = 16;
            distanceKant.Visible = false;
            labelPar.Visible = false;
            direction.Visible = false;
            startColor.Visible = true;
            endColor.Visible = true;
            labelCol1.Visible = true;
            labelCol2.Visible = true;
            start_Drawing.Visible = true;

            zoom1.Visible = true;
            zoom2.Visible = true;
            zoom3.Visible = true;
            zoom5.Visible = true;
            zoomLabel.Visible = true;
            saveButton.Visible = true;
            center.Visible = true;
        }

        /// <summary>
        /// Clean picture
        /// </summary>
        void Clean()
        {
            graph.Clear(pictureBox.BackColor);
            pictureBox.Image = bmp;
        }

        /// <summary>
        /// Saves image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saving = new SaveFileDialog();
            saving.ShowDialog();
            string filename = saving.FileName + ".png";
            bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        int leftSide, topSide; //fields for picture coordinates
        int leftM, topM; //fields for cursor coordinates

        /// <summary>
        /// Finds out initial coordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            leftSide = pictureBox.Left;
            topSide = pictureBox.Top;
            leftM = Cursor.Position.X;
            topM = Cursor.Position.Y;
        }

        /// <summary>
        /// Move picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox.Left = leftSide + (Cursor.Position.X - leftM);
            pictureBox.Top = topSide + (Cursor.Position.Y - topM);
        }

        /// <summary>
        /// Zoom in 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(initialW * 5, initialH * 5);
            pictureBox.Width = initialW * 5;
            pictureBox.Height = initialH * 5;
            graph = Graphics.FromImage(bmp);
            zoom = 5;
            DrawFractal();
        }

        /// <summary>
        /// Zoom in 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(initialW * 3, initialH * 3);
            pictureBox.Width = initialW * 3;
            pictureBox.Height = initialH * 3;
            graph = Graphics.FromImage(bmp);
            zoom = 3;
            DrawFractal();
        }

        /// <summary>
        /// Zoom 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(initialW, initialH);
            pictureBox.Width = initialW;
            pictureBox.Height = initialH;
            graph = Graphics.FromImage(bmp);
            zoom = 1;
            DrawFractal();
        }

        /// <summary>
        /// Zoom in 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            bmp = new Bitmap(initialW * 2, initialH * 2);
            pictureBox.Width = initialW * 2;
            pictureBox.Height = initialH * 2;
            graph = Graphics.FromImage(bmp);
            zoom = 2;
            DrawFractal();
        }

        /// <summary>
        /// Move picturebox to the start point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox.Left = 340;
            pictureBox.Top = 30;
        }
    }
}