using MyLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Linq
{
    public static class BasicLinq
    {

        public static IEnumerable<int> orberArray(int[] array)
        {
            IEnumerable<int> lst = from d in array
                                   orderby d
                                   select d;
            return lst;
        }

        public static IEnumerable<int> getNumbsFromArray(int numb, int[] array)
        {
            IEnumerable<int> lst = from d in array
                                   where d == numb
                                   orderby d
                                   select d;
            return lst;
        }

        public static IEnumerable<int> getNumbsBetweenRangeFromArray(int numbA, int numbB, int[] array)
        {
            IEnumerable<int> lst = from d in array
                                   where d > numbA && d < numbB 
                                   orderby d
                                   select d;
            return lst;
        }

        public static Person getPersonFromArray(int id, Person[] personas)
        {
            Person p = (from d in personas where d.id == id select d).FirstOrDefault();

            return p;
        }

        public static IOrderedEnumerable<Person> orderArrayForValue(Person[] personas)
        {
            var list = (from d in personas orderby d.id select d);
            return list;
        }

    }
}
