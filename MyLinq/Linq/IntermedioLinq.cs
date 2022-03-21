using MyLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Linq
{
    public static class IntermedioLinq
    {

        public static List<string> getNamePersons(List<Person> persons)
        {
            List<string> result = (from d in persons
                                   orderby d.nombres
                                   select d.IdNombres).ToList();
            return result;
        }

        public static List<string> getItemsNamePersons(int numItem, List<Person> persons)
        {
            List<string> result = (from d in persons
                                   orderby d.nombres
                                   select d.IdNombres).Take(numItem).ToList();
            return result;
        }

        public static List<string> getItemsNameSkipPersons(int numSkip, int numItem, List<Person> persons)
        {
            List<string> result = (from d in persons
                                   orderby d.nombres
                                   select d.IdNombres).Skip(numSkip).Take(numItem).ToList();
            return result;
        }

        public static List<string> getListUnion(List<Person> values, List<Person> persons)
        {
            List<string> result = (from d in persons
                                   orderby d.nombres
                                   select d).Union(values)
                                   .OrderBy(d => d.nombres)
                                   .Select(d => d.IdNombres).ToList();
            return result;
        }

        public static List<string> getListSubLinq(List<Person> values, List<Person> persons)
        {
            List<string> result = (from d in persons
                                   orderby d.nombres
                                   select d.IdNombres).Union(
                                    from d in values
                                    select d.IdNombres).ToList();
            return result;
        }

        public static List<string> getListQuery(List<Person> values, List<Person> persons)
        {
            List<string> result = (from a in (from d in persons
                                              where d.id > 10
                                       orderby d.nombres
                                       select d ).Union(
                                        from d in values
                                        where d.id > 10
                                        select d) 
                                   orderby a.nombres 
                                   select a.IdNombres).ToList();
            return result;
        }

    }
}
