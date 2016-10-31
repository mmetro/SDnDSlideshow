using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDnDSlideshow
{
    public class Slideshow
    {
        public Slideshow()
        {
            _files = new HashSet<String>();
        }

        // If i is >= the number of files, it will loop around
        /**
        public string getImage(int i)
        {
            if (_files.Count <= 0)
                return "";
            return _files[i%_files.Count];
        }
        */


        public IEnumerator<String> GetEnumerator()
        {
            foreach (String f in _files)
            {
                yield return f;
            }
        }

        public void addImage(string path)
        {
            _files.Add(path);
        }

        public void addDirectory(string path)
        {
            try
            {
                foreach(string f in Directory.GetFiles(path))
                {
                    _files.Add(f);
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

        private HashSet<String> _files;
    }
}
