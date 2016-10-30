using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDnDSlideshow
{
    public partial class SlideshowForm : Form
    {
        public SlideshowForm()
        {
            InitializeComponent();
        }

        public void changeImage(String imagePath)
        {
            _imagePath = imagePath;
            if (_imagePath == null)
            {
                return;
            }
            String extension = Path.GetExtension(_imagePath);
            if (extension.Equals(".jpg") || extension.Equals(".bmp") || extension.Equals(".png") || extension.Equals(".gif"))
            {
                Image i2 = _image;
                _image = Image.FromFile(_imagePath);
                if (_image != null)
                {
                    changeSize(_image.Size);
                    pictureBox1.Image = _image;
                    
                    if (i2 != null)
                    {
                        i2.Dispose();
                    }
                }
            }
        }

        delegate void ChangeSizeCallback(Size s);

        private void changeSize(Size s)
        {
            if (this.InvokeRequired)
            {
                ChangeSizeCallback d = new ChangeSizeCallback(changeSize);
                this.Invoke(d, new object[] { s });
            }
            else
            {
                //this.ClientSize = s;
                //pictureBox1.Size = _image.Size;

                //pictureBox1.Size = this.ClientSize;
            }
        }

        private void SlideshowForm_Paint(object sender, PaintEventArgs e)
        {
            if (_image == null)
            {
                return;
            }
            //Graphics g = e.Graphics;
            //g.DrawImage(_image, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementationwe don't want to paint the background
            // 
        }

        public void setSlideshow(ref Slideshow ss)
        {
            _slideshow = ss;
        }

        private Image _image;
        private String _imagePath;
        private Slideshow _slideshow;

        private void SlideshowForm_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = this.ClientSize;
        }
    }

}
