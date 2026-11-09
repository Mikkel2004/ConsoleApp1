using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class AwesomeClass3
    {
        private string _awesome;
        private int _cool;
        private bool _incredible;
        public AwesomeClass3(string awesome, int cool, bool incredible)
        {
            _awesome = awesome;
            _cool = cool;
            _incredible = incredible;
        }

        public override string ToString()
        {
            return $"awesome: {_awesome}, cool: {_cool}, incredible: {_incredible}";
        }
    }
}
