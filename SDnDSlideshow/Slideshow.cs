using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SDnDSlideshow
{
    public class Slideshow : IDisposable
    {
        public Slideshow()
        {
            _files = new HashSet<String>();
            isLocked = false;
            _directories = new HashSet<String>();
            // check for new files every 10 seconds
            _timer = new System.Timers.Timer(10000);
            _timer.Elapsed += handleTimer;
            _timer.Start();
        }

        /// <summary>Call to dispose the Slideshow</summary>
        public void Dispose()
        {
            _timer.Stop();
        }

        /// <summary>Return an IEnumerator for all the files in the slideshow</summary>
        /// <returns>An IEnumerator of type String that iterates over filepaths</returns>
        public IEnumerator<String> GetEnumerator()
        {
            // Need ToList() to prevent problems when new files are added
            foreach (String f in _files.ToList())
            {
                yield return f;
            }
        }

        /// <summary>Prevent new files from being added to the slideshow</summary>
        public void lockSlideshow()
        {
            isLocked = true;
        }

        /// <summary>Allow new files to be automatically added to the slideshow</summary>
        public void unlockSlideshow()
        {
            isLocked = false;
        }

        /// <summary>Add an image to the slideshow</summary>
        /// <param name="path">The file path to the image </param>
        public void addImage(string path)
        {
            _files.Add(path);
        }

        /// <summary>Remove an image from the slideshow</summary>
        /// <param name="path">The file path to the image </param>
        public void removeImage(string path)
        {
            _files.Remove(path);
        }

        /// <summary>Add a directory to the slideshow</summary>
        /// <param name="path">The file path to the directory </param>
        public void addDirectory(string path)
        {
            _directories.Add(path);
            try
            {
                foreach (string f in Directory.GetFiles(path))
                {
                    _files.Add(f);
                }
            }
            catch (System.ArgumentException)
            {
                // directory doesn't exist
            }
        }

        /// <summary>Remove a directory from the slideshow</summary>
        /// <param name="path">The file path to the directory </param>
        public void removeDirectory(string path)
        {
            _directories.Remove(path);
        }

        /// <summary>Load a slideshow from a file</summary>
        /// <param name="path">The file path to the slideshow file</param>
        public bool loadFromFile(string filePath)
        {
            throw new NotImplementedException();
        }

        /// <summary>Save a slideshow to a file</summary>
        /// <param name="path">The file path to the slideshow file</param>
        public bool saveToFile(string filePath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// periodically called to update new files
        /// Does not currently remove deleted files. XXX do we need to do this?
        ///</summary>
        private void updateFilesFromDirectories()
        {
            foreach (String d in _directories.ToList())
            {
                try
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        _files.Add(f);
                    }
                }
                catch (System.ArgumentException)
                {
                    // directory doesn't exist
                    _directories.Remove(d);
                }
            }
        }

        /// <summary>Handles the timer for updating the slideshow</summary>
        private void handleTimer(object source, ElapsedEventArgs e)
        {
            if (!isLocked)
                updateFilesFromDirectories();
        }

        /// <summary>The set of all files contained in the slideshow</summary>
        private HashSet<String> _files;
        /// <summary>The set of all directories to periodically check for new files in</summary>
        private HashSet<String> _directories;
        /// <summary>Periodically check for new files</summary>
        private System.Timers.Timer _timer;
        /// <summary>The lock state of the slideshow</summary>
        private bool isLocked;
    }
}
