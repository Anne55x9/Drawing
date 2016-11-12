using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Squares: DrawingShape, IDraw, IColor
    {
        //private int sidelength;
        //private int locX = 0, locY = 0;
        //private Rectangle rect = null;

        public Squares(int sidelength) : base(sidelength)
        {

        }

        public override void Draw(Canvas canvas)
        {
            if(this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Rectangle();
            }

            base.Draw(canvas);
        }

        //void IDraw.SetLocation(int xCoord, int yCoord)
        //{
        //    this.locX = xCoord;
        //    this.locY = yCoord;
        //}

        //void IDraw.Draw(Canvas canvas)
        //{
        //    if(this.rect != null)
        //    {
        //        canvas.Children.Remove(this.rect);
        //    }
        //    else
        //    {
        //        this.rect = new Rectangle();
        //    }

        //    this.rect.Height = this.sidelength;
        //    this.rect.Width = this.sidelength;
        //    Canvas.SetTop(this.rect, this.locY);
        //    Canvas.SetLeft(this.rect, this.locX);
        //    canvas.Children.Add(this.rect);
        //}

        //void IColor.SetColor(Color color)
        //{
        //    if(this.rect!= null)
        //    {
        //        SolidColorBrush brush = new SolidColorBrush(color);
        //        this.rect.Fill = brush;
        //    }
        //}
    }
}
