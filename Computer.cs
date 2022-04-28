using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public bool PowerOn { get; set; } = false;
        public double RAM { get; set; }
        public double Storage { get; set; }

        public Computer(double rAM, double storage)
        {
            RAM = rAM;
            Storage = storage;
        }

        public string ShowSpecs()
        {
            return $"RAM: {RAM}GB, Storage: {Storage}GB";
        }

        public bool SwitchPower()
        {
            PowerOn = !PowerOn;
            return PowerOn;
        }
    }
}
