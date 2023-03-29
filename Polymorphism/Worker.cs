using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Worker
    {
        private string FSname;
        private string LSname;
        // constructor of class
        public Worker(string FSnameval, string LSnameval)
        {
            FSname = FSnameval;
            LSname = LSnameval;
        }
        // Set & Get for FSname
        public string Fsname
        {
            get
            {
                return Fsname;
            }
            set
            {
                Fsname = value;
            }
        }

        public string Lsname
        {
            get
            {
                return Lsname;
            }
            set
            {
                Lsname = value;
            }
        }

        public override string ToString()
        {
        return FSname + " " + LSname;
        }

        public abstract decimal Income();

       
    }
}
