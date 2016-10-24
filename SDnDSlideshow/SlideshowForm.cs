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
            if (_image != null)
            {
                _image.Dispose();
            }
            String extension = Path.GetExtension(_imagePath);
            if (extension.Equals(".jpg") || extension.Equals(".bmp") || extension.Equals(".png") || extension.Equals(".gif"))
            {
                _image = Image.FromFile(_imagePath);
                if (_image != null)
                {
                    changeSize(_image.Size);
                    pictureBox1.Image = _image;
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
                this.ClientSize = s;
                pictureBox1.Size = _image.Size;
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

        private Image _image;
        private String _imagePath;
    }

}
