using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp1_Lab_5
{
    class Data
    {
        public string Text { get; private set; }
        public   string FileName { get; private set; }
        public   Match  Match { get; set; }

        internal void ReadFromFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                Text = sr.ReadToEnd().Replace("\r", "");  //стандартный символ конца строки	
            }

        }
    }
}
