using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_11_InClass
//namespace YahtzeeGame
{
    public partial class DieControl : UserControl
    {


        private int _face;

        public int Face
        {
            get { return _face; }
            set 
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Face value must be between 1 and 6");
                }
                else
                {
                    int dieSize = 223;
                    _face = value;

                    Bitmap original = (Bitmap)pictureBoxHold.Image;
                    Rectangle srcRect = new Rectangle(0,0,0,0);
                    switch (_face)
                    {
                        case 1:
                            srcRect = new Rectangle(0, 0, dieSize, dieSize);
                            //Bitmap cropped = (Bitmap)original.Clone(srcRect, original);
                            break;
                        case 2:
                            srcRect = new Rectangle(dieSize, 0, dieSize, dieSize);
                            break;
                        case 3:
                            srcRect = new Rectangle(dieSize * 2, 0, dieSize, dieSize);
                            break;
                        case 4:
                            srcRect = new Rectangle(0, dieSize, dieSize, dieSize);
                            break;
                        case 5:
                            srcRect = new Rectangle(dieSize, dieSize, dieSize, dieSize);
                            break;
                        case 6:
                            srcRect = new Rectangle(dieSize * 2, dieSize, dieSize, dieSize);
                            break;
                    }
                    // pixleformat just leaves it in the format it was in
                    Bitmap cropped = (Bitmap)original.Clone(srcRect, original.PixelFormat);
                    pictureBoxFace.Image = cropped;
                    //pictureBoxFace.Image = pictureBoxHold.Image;
                }

            }
        }
        

        public DieControl()
        {
            InitializeComponent();
        }

        private void DieControl_Load(object sender, EventArgs e)
        {

            pictureBoxFace.Location = new Point(0, 0);
            DieControl_Resize(sender, e);
            //this.DieControl_Resize(sender, e);
            //Face = 1;
            Face = new Random().Next(1, 7);
        }

        // automajicly
        private void DieControl_Resize(object sender, EventArgs e)
        {
            // this is the size of the container or control
            pictureBoxFace.Size = this.Size;
        }

        private void DieControl_Click(object sender, EventArgs e)
        {

        }




    }
}
