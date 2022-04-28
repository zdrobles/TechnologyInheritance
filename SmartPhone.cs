using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        private string[] orientationArr = { "Portrait", "Landscape" };
        private bool binaryIterator = false;

        public SmartPhone(double rAM, double storage) : base(rAM, storage)
        {
        }

        public string Orientation { set; get; } = "Portrait";

        public void RotateScreen()
        {
            if (binaryIterator)
            {
                Orientation = orientationArr[0];
            }
            else
            {
                Orientation = orientationArr[1];
            }
            binaryIterator = !binaryIterator;
        }
    }
}
