using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                slideShowDirTextBox.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }
    }
}
