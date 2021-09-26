using System.Collections.Generic;
using System.Linq;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia

{
    public class RepositorioPropietario : IRepositorioPropietario
    {
        private readonly AppContext _appContext;

        public RepositorioPropietario(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Propietario AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        public void DeletePropietario(int propietarioId)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietarioId);
            if (propietarioEncontrado == null) return ;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Propietario> GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }

        public Propietario GetPropietario(int propietarioId)
        {
            return _appContext.Propietarios.FirstOrDefault(p => p.Id == propietarioId);
        }

        public Propietario UpdatePropietario(Propietario propietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietario.Id);
            if (propietarioEncontrado!=null)
            {
                propietarioEncontrado.Nombres=propietario.Nombres;
                propietarioEncontrado.Apellidos=propietario.Apellidos;
                propietarioEncontrado.Direccion=propietario.Direccion;
                propietarioEncontrado.Telefono= propietario.Telefono;
                _appContext.SaveChanges();
            }
            return propietarioEncontrado;
        }
    }
}