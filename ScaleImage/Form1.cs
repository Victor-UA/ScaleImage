using System;
using System.Drawing;
using System.Windows.Forms;
using ScaleImage.Actions;

namespace ScaleImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Controls.Add(pictureBox_model);
            pictureBox_model.Size = pictureBox1.Size;
            pictureBox_model.Location = new Point(0, 0);
            pictureBox_model.BackColor = Color.Transparent;
            pictureBox_model.BorderStyle = BorderStyle.None;
            pictureBox_model.BringToFront();

            isScaling = false;
            firstClick = false;
            setCurrentOperationInfo("Малюнок не завантажено, масштаб не визначено");

            webcam = new WebCam(ref pictureBox1);
        }

        private bool isScaling;
        private bool firstClick;

        private WebCam webcam;
        
        private object setCurrentOperationInfo(string text)
        {
            toolStripStatusLabel_Operation.Text = text;
            return null;
        }
        
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            firstClick = false;
            setCurrentOperationInfo("Завантаження малюнку");
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(OPF.FileName);
                Model.Scale = 0;
                setCurrentOperationInfo("Малюнок завантажено, масштаб не визначено");
            }
            else
            {
                setCurrentOperationInfo("Малюнок не було завантажено");
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Model.PCurrent = e.Location;
            if (firstClick)
            {
                toolStripStatusLabel_X.Text = e.X.ToString();
                toolStripStatusLabel_Y.Text = e.Y.ToString();
                toolStripStatusLabel_rX.Text = Math.Round(Model.PRelative.X / Model.Scale, 2).ToString();
                toolStripStatusLabel_rY.Text = Math.Round(Model.PRelative.Y / Model.Scale, 2).ToString();
                toolStripStatusLabel_Length.Text = Model.getLength().ToString();
                toolStripStatusLabel_realLength.Text = Model.getRealLength().ToString();
            }

            Bitmap bitmap = new Bitmap(pictureBox_model.Width, pictureBox_model.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            bitmap.MakeTransparent();
            Graphics g = Graphics.FromImage(bitmap);

            if (firstClick || (isScaling && !(isScaling && !Operations.getScaling.firstClick)))
            {
                g.DrawLine(new Pen(Brushes.Lime, 1), Model.P0, Model.PCurrent);
                int x = Model.P0.X < Model.PCurrent.X ? Model.P0.X : Model.PCurrent.X;
                int y = Model.P0.Y < Model.PCurrent.Y ? Model.P0.Y : Model.PCurrent.Y;
                g.DrawRectangle(new Pen(Brushes.Lime, 1), x, y, Math.Abs(Model.PRelative.X), Math.Abs(Model.PRelative.Y));
            }

            pictureBox_model.BackgroundImage = bitmap;
            g.Dispose();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(isScaling)
            {
                isScaling = Operations.runScaling(pictureBox_model, setCurrentOperationInfo);
                if (!isScaling)
                {
                    Bitmap bitmap = new Bitmap(pictureBox_model.Width, pictureBox_model.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    bitmap.MakeTransparent();
                    Graphics g = Graphics.FromImage(bitmap);
                    pictureBox_model.BackgroundImage = bitmap;
                    g.Dispose();
                }
                return;
            }

            firstClick = !firstClick;
            Model.P0 = Model.PCurrent;
        }
        private void button_Scaling_Click(object sender, EventArgs e)
        {
            isScaling = true;
            firstClick = false;
            setCurrentOperationInfo("Зазначте першу точку на малюнку");
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            isScaling = false;
            setCurrentOperationInfo("Масштаб не визначено");
            Model.Scale = 0;
        }

        private void button_WC_Start_Click(object sender, EventArgs e)
        {
            if (webcam.isRunning)
            {
                webcam.Stop();
                button_WC_Start.Text = "WC Start";
            }
            else
            {
                webcam.Start();
                button_WC_Start.Text = "WC Stop";
            }
        }

    }
}
