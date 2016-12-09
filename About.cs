using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Assistant
{
    class About
    {
        int _version;
        public int Version {
            get { return _version; }
            set { _version = Version; }
        }

        string Authors;
        public void Info()
        {
            Console.WriteLine("This tool makes use of Valve's Steam API to provide helpful information" + "\n" + "about games available on the platform and much more!");
        }
        
    }
}
