using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Models
{
    public class Person
    {
        public Person() { }

        public Person(int id, string name)
        {
            this.id = id;
            this.nombres = name;
        }

        public int id { get; set; }
        public string nombres { get; set; }

        public string IdNombres
        {
            get
            {
                return $"{id} - {nombres}";
            }
            set { }
        }


        public string print()
        {
            return $"{this.id} {this.nombres}";
        }
    }
}
