using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScaleImage.Dialogs;

namespace ScaleImage.Actions
{
    static class Operations
    {
        public static Graphics graphicsScaling { get; private set; }

        public static bool runScaling(PictureBox pictureBox, Func<string, object> setCurrentOperationInfo)
        {
            if (!Scaling.firstClick)
            {
                Model.P0 = Model.PCurrent;
                Scaling.P0 = Model.PCurrent;
                Scaling.firstClick = true;
                setCurrentOperationInfo("Зазначте другу точку на малюнку");
                graphicsScaling = pictureBox.CreateGraphics();
                return true;

            }
            else if (!Scaling.secondClick)
            {
                Scaling.P1 = Model.PCurrent;
                Scaling.secondClick = true;
                setCurrentOperationInfo("Зазначте реальну відстань");
                try
                {
                    Scaling.realDistance = Double.Parse(Prompt.ShowDialog("Зазначте реальну відстань", "Визначення масштабу"));
                    Model.Scale = Scaling.getScale;
                    setCurrentOperationInfo("Масштаб = " + Model.Scale.ToString());
                }
                catch (Exception)
                {
                    setCurrentOperationInfo("Помилка у визначенні реальної відстані");
                    Model.Scale = 0;
                }
                finally
                {
                    Scaling.Init();
                }
                return false;
            }
            return false;
        }

        public static class getScaling
        {
            public static bool firstClick { get { return Scaling.firstClick; } }
            public static bool secondClick { get { return Scaling.secondClick; } }
        }

        /*
        public static double Scale
        {
            get
            {
                return Model.Scale;
            }
            set
            {
                Model.Scale = value;
            }
        }
        public static Point P0
        {
            get
            {
                return Model.P0;
            }
            set
            {
                Model.P0 = value;
            }
        }
        public static Point PCurrent
        {
            get
            {
                return Model.PCurrent;
            }
            set
            {
                Model.PCurrent = value;
            }
        }
        public static Point PRelative
        {
            get
            {
                return Model.PRelative;
            }
        }
        public static double getLength()
        {
            return Model.getLength(PCurrent);
        }
        public static double getRealLength(Point p)
        {
            return Model.getLength(p);
        }
        public static double getRealLength()
        {
            return getRealLength();
        }
        */
        private static class Scaling
        {
            public static void Init()
            {
                firstClick = false;
                secondClick = false;
                realDistance = 1;
                P0 = new Point(0, 0);
                P1 = new Point(0, 0);
            }
            public static bool firstClick { get; set; } = false;
            public static bool secondClick { get; set; } = false;
            public static double realDistance { get; set; } = 1;
            public static double localDistance
            {
                get
                {
                    return Math.Sqrt(Math.Pow(P1.X - P0.X, 2) + Math.Pow(P1.Y - P0.Y, 2));
                }
            }
            public static Point P0 { get; set; } = new Point(0, 0);
            public static Point P1 { get; set; } = new Point(0, 0);
            public static double getScale
            {
                get
                {
                    return localDistance / realDistance;
                }
            }
        }

        
    }
}
