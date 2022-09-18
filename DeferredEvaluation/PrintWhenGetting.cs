using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredEvaluation
{
    class PrintWhenGetting
    {
        private int instanceNumber;
        public int InstanceNumber
        {
            get
            {
                Console.WriteLine($"Getting #{instanceNumber}");
                return instanceNumber;
            }
            set { instanceNumber = value; }
        }
    }
}
