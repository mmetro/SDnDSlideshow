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

    /// <summary>Change the image displayed by the form</summary>
    /// <param name="imagePath">The path to the image</param>
    public void changeImage(String imagePath)
    {
      _imagePath = imagePath;
      if (_imagePath == null)
      {
        return;
      }
      String extension = Path.GetExtension(_imagePath);
      if (extension.Equals(".jpg", StringComparison.InvariantCultureIgnoreCase)
        || extension.Equals(".bmp", StringComparison.InvariantCultureIgnoreCase)
        || extension.Equals(".png", StringComparison.InvariantCultureIgnoreCase)
        || extension.Equals(".gif", StringComparison.InvariantCultureIgnoreCase))
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
      else
      {
        _slideshow.removeImage(imagePath);
      }
    }

    /// <summary>Set the Slideshow model for the Slideshow Form</summary>
    /// <param name="ss">The slideshow model</param>
    public void setSlideshow(Slideshow ss)
    {
      _slideshow = ss;
    }

    /// <summary>Set the controller for the Slideshow Form</summary>
    /// <param name="c">The controller</param>
    public void setController(ControllerForm c)
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

    private void SlideshowForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (_image != null)
      {
        _image.Dispose();
      }
    }

    private Image _image;
    private String _imagePath;
    private Slideshow _slideshow;
    private ControllerForm _controller;
  }
}
