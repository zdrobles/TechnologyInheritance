using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public readonly bool HasDiscDrive;
        public Laptop(bool hasDiscDrive, double rAM, double storage) : base(rAM, storage)
        {
            HasDiscDrive = hasDiscDrive;
        }

        public bool RunDisc()
        {
            if (HasDiscDrive)
            {
                Console.WriteLine("Running Disc...");
                return true;
            } else return false;
        }
    }
}
