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
            _needNewIterator = false;
            // check for new files every 10 seconds
            System.Timers.Timer timer = new System.Timers.Timer(10000);
            timer.Elapsed += HandleTimer;
            timer.Start();
        }

        public IEnumerator<String> GetEnumerator()
        {

            // Need this to prevent problems when new files are added
            IEnumerator<String> enumerator = _files.ToList().GetEnumerator();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        // prevent new files from being added to the slideshow
        public void lockSlideshow()
        {
            isLocked = true;
        }

        // allow new files to be automaticall added to the slideshow
        public void unlockSlideshow()
        {
            isLocked = false;
        }

        public void addImage(string path)
        {
            _files.Add(path);
        }

        public void addDirectory(string path)
        {
            _directories.Add(path);
            try
            {
                foreach(string f in Directory.GetFiles(path))
                {
                    _files.Add(f);
                    _needNewIterator = true;
                }
            }
            catch (System.ArgumentException)
            {

            }
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
            foreach( String d in _directories)
            {
                foreach (string f in Directory.GetFiles(d))
                {
                    _files.Add(f);
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
        bool _needNewIterator;
    }
}
