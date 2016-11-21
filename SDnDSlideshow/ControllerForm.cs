using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SDnDSlideshow
{
  // XXX should rename the class
  public partial class ControllerForm : Form
  {
    public ControllerForm()
    {
      InitializeComponent();
      foreach (var screen in Screen.AllScreens)
      {
        screenComboBox1.Items.Add(screen.DeviceName);
      }
      _slideShowForms = new HashSet<SlideshowForm>();
      _slideshows = new HashSet<Slideshow>();
      _slideshowMap = new Dictionary<SlideshowForm, Slideshow>();
      _slideshowIEMap = new Dictionary<SlideshowForm, IEnumerator<String>>();
      _lviToSlideshowFormMap = new Dictionary<ListViewItem, SlideshowForm>();
      _SlideshowFormToLVIMap = new Dictionary<SlideshowForm, ListViewItem>();
      _slideshowIntervalMap = new Dictionary<SlideshowForm, uint>();
      elapsed = 0;

      // update the image every 1000 MS
      System.Timers.Timer timer = new System.Timers.Timer(1000);
      timer.Elapsed += handleTimer;
      timer.Start();
    }

    /// <summary>display information about the selected screen</summary>
    private void button1_Click_1(object sender, EventArgs e)
    {
      int selectedIndex = screenComboBox1.SelectedIndex;
      if (selectedIndex < 0 || selectedIndex > Screen.AllScreens.Length)
      {
        MessageBox.Show("Please select a valid screen from the dropdown.", "Invalid Screen");
        return;
      }
      Screen screen = Screen.AllScreens[selectedIndex];
      MessageBox.Show("Name: " + screen.DeviceName + "\n Working area: " + screen.WorkingArea.ToString(), "Selected Screen Info");
    }

    /// <summary>Handler for when the browse button is clicked</summary>
    private void browseButton_Click(object sender, EventArgs e)
    {
      DialogResult result = folderBrowserDialog1.ShowDialog();

      if (result == DialogResult.OK)
      {
        string path = folderBrowserDialog1.SelectedPath.ToString();
        slideShowDirTextBox.Text = path;
      }
    }

    /// <summary>Called by A SlideshowForm when it closes</summary>
    /// <param name="sf">The SlideshowForm that closed</param>
    public void slideFormClosedHandler(SlideshowForm sf)
    {
      // Remove the slideshow and all related objects from the collections
      slideShowListView.Items.Remove(_SlideshowFormToLVIMap[sf]);
      _slideshowMap[sf].Dispose();
      _slideshows.Remove(_slideshowMap[sf]);
      _lviToSlideshowFormMap.Remove(_SlideshowFormToLVIMap[sf]);
      _SlideshowFormToLVIMap.Remove(sf);
      _slideshowIEMap.Remove(sf);
      _slideshowMap.Remove(sf);
      _slideShowForms.Remove(sf);
      // XXX should we also remove their slideshow models? (Slideshow class)
    }

    /// <summary>Periodically called to change the displayed image in all SlideshowForms</summary>
    private void handleTimer(object source, ElapsedEventArgs e)
    {
      elapsed++;
      foreach (SlideshowForm sf in _slideShowForms.ToList())
      {
        if ((elapsed % _slideshowIntervalMap[sf]) == 0)
        {
          sf.changeImage(_slideshowIEMap[sf].Current);
          if (!_slideshowIEMap[sf].MoveNext())
          {
            _slideshowIEMap[sf] = _slideshowMap[sf].GetEnumerator();
          }
        }
      }
    }

    /// <summary>Handler for when the start slideshow button is clicked</summary>
    private void startButton_Click(object sender, EventArgs e)
    {
      // Create a new slideshow form
      SlideshowForm slideForm = new SlideshowForm();
      slideForm.Show();
      // Create a new slideshow model
      Slideshow ss = new Slideshow();
      slideForm.setSlideshow(ss);
      slideForm.setController(this);
      _slideShowForms.Add(slideForm);
      // add some pictures to the slideshow
      ss.addDirectory(folderBrowserDialog1.SelectedPath.ToString());
      _slideshows.Add(ss);
      // Map slideshow forms to slideshows (views to models)
      _slideshowMap[slideForm] = ss;
      // get an enumerator for the slideshow.
      // This allows us to have a one-to-many slideshow-to-view relationship
      _slideshowIEMap[slideForm] = ss.GetEnumerator();
      // Map an item in the list of slideshows to the slideshow itself
      // We need this to determine which slideshow the user wants to stop
      ListViewItem lvi = new ListViewItem(folderBrowserDialog1.SelectedPath.ToString(), 0);
      _lviToSlideshowFormMap[lvi] = slideForm;
      _SlideshowFormToLVIMap[slideForm] = lvi;
      slideShowListView.Items.Add(lvi);
      _slideshowIntervalMap[slideForm] = (uint) intervalNumericUpDown.Value;
    }

    /// <summary>Stop all of the selected slideshows</summary>
    private void stopButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem lvi in slideShowListView.SelectedItems)
      {
        _lviToSlideshowFormMap[lvi].Close();
      }
    }

    private void lockButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem lvi in slideShowListView.SelectedItems)
      {
        _slideshowMap[_lviToSlideshowFormMap[lvi]].lockSlideshow();
      }
    }

    private void unlockButton_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem lvi in slideShowListView.SelectedItems)
      {
        _slideshowMap[_lviToSlideshowFormMap[lvi]].unlockSlideshow();
      }
    }

    // Set of all slideshow models
    private HashSet<Slideshow> _slideshows;
    // Set of all slideshow forms
    private HashSet<SlideshowForm> _slideShowForms;
    // Map a slideshow form to its slideshow model
    private Dictionary<SlideshowForm, Slideshow> _slideshowMap;
    // Map a slideshow form to an IEnumerator for its images' filepaths
    private Dictionary<SlideshowForm, IEnumerator<String>> _slideshowIEMap;
    // Map a ListViewItem to its SlideshowForm
    private Dictionary<ListViewItem, SlideshowForm> _lviToSlideshowFormMap;
    // Map a SlideshowForm to its ListViewItem
    private Dictionary<SlideshowForm, ListViewItem> _SlideshowFormToLVIMap;
    // Elapsed Seconds
    private uint elapsed;
    // Map SLideShow forms to the intervals
    private Dictionary<SlideshowForm, uint> _slideshowIntervalMap;
  }
}
