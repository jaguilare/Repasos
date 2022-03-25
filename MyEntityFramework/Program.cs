using Microsoft.EntityFrameworkCore;
using MyEntityFramework.Models;
using System;
using System.Linq;

namespace MyEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new testdbContext())
            {

                // agregar
                var p = new Persona()
                {
                    Identificacion = "980857",
                    Nombres = "Francisco",
                    Apellidos = "Ceballos",
                };
                context.Personas.Add(p);
                context.SaveChanges();


                // actualizar
                p = context.Personas.Find(3);
                p.Nombres = "Puma";
                context.Entry(p).State = EntityState.Modified;
                context.SaveChanges();


                // eliminar
                p = context.Personas.Find(6);
                context.Remove(p);
                context.SaveChanges();


                foreach (var persona in context.Personas.ToList())
                {
                    Console.WriteLine($"{persona.Apellidos} {persona.Nombres}");
                }
            }

        }
    }
}
