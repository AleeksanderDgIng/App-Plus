using System;
using VisitasDomiciliarias.App.Dominio;
using VisitasDomiciliarias.App.Persistencia;
namespace VisitasDomiciliarias.App.Consola
{
    class Program
    {
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPropietario();
        }
        private static void AddPropietario()
        {
            var propietario = new Propietario
            {
              Identificacion = 123654,
              Nombres = "Ricardo",
              Apellidos = "González Uribe",
              Direccion = "Diagonal 9 7 30",
              Telefono = "107095"

            };
            _repoPropietario.AddPropietario(propietario);
        }
    }
}
