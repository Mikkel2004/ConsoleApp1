using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FredrikClass
    {

        private string _name;

        private int _id;

        public FredrikClass(string name, int id)
        {
            name = _name;
            id = _id;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }




    }
}
