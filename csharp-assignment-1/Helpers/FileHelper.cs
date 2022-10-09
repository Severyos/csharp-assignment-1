using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignment_1.Helpers
{
    internal class FileHelper
    {
        public void Save(string filepath, string content)
        {
            using var sw = new StreamWriter(filepath);
            sw.Write(content);
        }

        public string Read(string filepath)
        {
            try
            {
                using var sr = new StreamReader(filepath);
                return sr.ReadToEnd();
            }
            catch { }

            return null;
            
        }
    }
}
