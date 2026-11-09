using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class FredrikClass
    {

        private string _name;

        private string _address;

        private int _id;

        public FredrikClass(string name, string address, int id)
        {
            name = _name;
            address = _address;
            id = _id;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, ID: {Id}";
        }


    }
}
