using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Mikkel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Tlf { get; set; }

        public Mikkel(string name, string address, int tlf)
        {
            Name = name;
            Address = address;
            Tlf = tlf;
        }

        public override string ToString()
        {
            return $"Name {Name} Address {Address} Telefone {Tlf}";
        }
    }
}
