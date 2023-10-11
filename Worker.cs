using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmethods
{
    public class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string WorkerCode { get; set; }
        private byte _experience;

        public byte Experience
        {
            get { return _experience; }
            set
            {
                if (value > 0)
                {
                    _experience = value;
                }
            }

        }
    }
}
