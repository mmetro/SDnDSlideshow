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

    // tell the form to display the image given in the filepath
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
        try
        {
          _image = Image.FromFile(_imagePath);
          if (_image != null)
          {
            pictureBox1.Image = _image;

            if (i2 != null)
            {
              i2.Dispose();
            }
          }
        }
        catch (System.IO.FileNotFoundException)
        {
          // picture was removed
          _slideshow.removeImage(imagePath);
        }
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

    // override to not draw the form background
    protected override void OnPaintBackground(PaintEventArgs e)
    {
      //empty implementation
      //we don't want to paint the background
    }

    // XXX should probably get rid of this
    public void setSlideshow(ref Slideshow ss)
    {
      _slideshow = ss;
    }

    public void setController(Form1 c)
    {
      _controller = c;
    }

    private void SlideshowForm_SizeChanged(object sender, EventArgs e)
    {
      pictureBox1.Size = this.ClientSize;
    }

    private void SlideshowForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      _controller.slideFormClosedHandler(this);
    }

    private Image _image;
    private String _imagePath;
    private Slideshow _slideshow;
    private Form1 _controller;


  }

}
