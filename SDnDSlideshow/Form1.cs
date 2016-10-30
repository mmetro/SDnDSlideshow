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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var screen in Screen.AllScreens)
            {
                screenComboBox1.Items.Add(screen.DeviceName);
            }
            _slideShowForms = new List<SlideshowForm>();
            _slideshows = new List<Slideshow>();
            _slideshowMap = new Dictionary<SlideshowForm, Slideshow>();
            _listMap = new Dictionary<ListViewItem, SlideshowForm>();

            // update the image every 1000 MS
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += HandleTimer;
            timer.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath.ToString();
                slideShowDirTextBox.Text = path;
            }
        }

        private void HandleTimer(object source, ElapsedEventArgs e)
        {
            foreach (SlideshowForm sf in _slideShowForms)
            {
                sf.changeImage(_slideshowMap[sf].getImage(currFile));
                currFile++;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SlideshowForm slideForm = new SlideshowForm();
            slideForm.Show();
            _slideShowForms.Add(slideForm);
            Slideshow ss = new Slideshow();
            ss.addDirectory(folderBrowserDialog1.SelectedPath.ToString());
            _slideshows.Add(ss);
            _slideshowMap[slideForm] = ss;
            ListViewItem lvi = new ListViewItem(folderBrowserDialog1.SelectedPath.ToString(), 0);
            _listMap[lvi] = slideForm;
            slideShowListView.Items.Add(lvi);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in slideShowListView.SelectedItems)
            {
                _slideShowForms.Remove(_listMap[lvi]);
                _listMap[lvi].Dispose();
                slideShowListView.Items.Remove(lvi);
            }
        }


        private int currFile;
        private List<Slideshow> _slideshows;
        private List<SlideshowForm> _slideShowForms;
        private Dictionary<SlideshowForm, Slideshow> _slideshowMap;
        private Dictionary<ListViewItem, SlideshowForm> _listMap;
    }
}
