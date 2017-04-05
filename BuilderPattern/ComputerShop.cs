using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Interface;

namespace BuilderPattern
{
    public class ComputerShop
    {
        public void ConstructComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildMotherboard();
            computerBuilder.BuildProcessor();
            computerBuilder.BuildHardDisk();
            computerBuilder.BuildScreen();
        }
    }
}
