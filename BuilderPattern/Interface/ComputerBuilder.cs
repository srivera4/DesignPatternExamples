using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Interface
{
    public abstract class ComputerBuilder
    {
        public Computer Computer { get; set; }

        public abstract void BuildMotherboard();
        public abstract void BuildProcessor();
        public abstract void BuildHardDisk();
        public abstract void BuildScreen();
    }
}
