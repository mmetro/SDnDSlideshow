﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SDnDSlideshow
{
    public class Slideshow
    {
        public Slideshow()
        {
            _files = new HashSet<String>();
            isLocked = false;
            _directories = new HashSet<String>();
            // check for new files every 10 seconds
            System.Timers.Timer timer = new System.Timers.Timer(10000);
            timer.Elapsed += HandleTimer;
            timer.Start();
        }

        public IEnumerator<String> GetEnumerator()
        {
            // Need ToList() to prevent problems when new files are added
            foreach (String f in _files.ToList())
            {
                yield return f;
            }
        }

        // prevent new files from being added to the slideshow
        public void lockSlideshow()
        {
            isLocked = true;
        }

        // allow new files to be automatically added to the slideshow
        public void unlockSlideshow()
        {
            isLocked = false;
        }

        public void addImage(string path)
        {
            _files.Add(path);
        }

        public void removeImage(string path)
        {
            _files.Remove(path);
        }

        public void addDirectory(string path)
        {
            _directories.Add(path);
            try
            {
                foreach(string f in Directory.GetFiles(path))
                {
                    _files.Add(f);
                }
            }
            catch (System.ArgumentException)
            {
                // directory doesn't exist
            }
        }

        public void removeDirectory(string path)
        {
            _directories.Remove(path);
        }

        public bool loadFromFile(string filePath)
        {
            return false;
        }

        public bool saveToFile(string filePath)
        {
            return false;
        }

        // periodically called to update new files
        // Does not currently remove deleted files. XXX do we need to do this?
        private void updateFilesFromDirectories()
        {
            foreach( String d in _directories.ToList())
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

        private void HandleTimer(object source, ElapsedEventArgs e)
        {
            if(!isLocked)
                updateFilesFromDirectories();
        }

        private HashSet<String> _files;
        private HashSet<String> _directories;
        private bool isLocked;
    }
}
