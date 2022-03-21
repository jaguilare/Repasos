using MyLinq.Linq;
using MyLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> lst;
            int[] array = { 4, 1, 65, 8, 4, 0, 9, 5, 2 };

            Console.WriteLine("orberArray()");

            lst = BasicLinq.orberArray(array);

            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\ngetNumbsFromArray()");

            lst = BasicLinq.getNumbsFromArray(4, array);

            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\ngetNumbsBetweenRangeFromArray()");

            lst = BasicLinq.getNumbsBetweenRangeFromArray(0, 4, array);

            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\ngetPersonFromArray");

            Person[] personas =
            {
                new Person(1, "Jose"),
                new Person(2, "Luis"),
                new Person(3, "Puma"),
                new Person(4, "Leon"),
            };

            Person p = BasicLinq.getPersonFromArray(1, personas);

            Console.WriteLine(p.print());

            Console.WriteLine("\norderArrayForValue");

            Person[] personas2 =
            {
                new Person(4, "Jose"),
                new Person(5, "Luis"),
                new Person(2, "Puma"),
                new Person(9, "Leon"),
            };

            IOrderedEnumerable<Person> lstP = BasicLinq.orderArrayForValue(personas2);

            foreach (var item in lstP)
            {
                Console.WriteLine(item.print());
            }

            Console.WriteLine("\ngetNamePersons");
            List<Person> persons = new List<Person>()
            {
                new Person(){id = 4, nombres = "Jose"},
                new Person(){id = 5, nombres = "Luis"},
                new Person(){id = 2, nombres = "Puma"},
                new Person(){id = 9, nombres = "Leon"},
            };

            List<string> names = IntermedioLinq.getNamePersons(persons);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\ngetItemsNamePersons");
            List<string> namesItemNum = IntermedioLinq.getItemsNamePersons(2, persons);

            foreach (var item in namesItemNum)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\ngetItemsNameSkipPersons");
            List<string> namesItemNumSkip = IntermedioLinq.getItemsNameSkipPersons(2, 2, persons);

            foreach (var item in namesItemNumSkip)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\ngetListUnion");

            List<Person> values = new List<Person>()
            {
                new Person(){id = 40, nombres = "Noel"},
                new Person(){id = 34, nombres = "Maria"},
                new Person(){id = 62, nombres = "Margot"},

            };
            List<string> listUnion = IntermedioLinq.getListUnion(values, persons);

            foreach (var item in listUnion)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\ngetListSubLinq");

            List<string> listSubLinq= IntermedioLinq.getListSubLinq(values, persons);

            foreach (var item in listSubLinq)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\ngetListQuery");

            List<string> listQuery= IntermedioLinq.getListQuery(values, persons);

            foreach (var item in listQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
