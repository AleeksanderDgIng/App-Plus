using System.Collections.Generic;
using VisitasDomiciliarias.App.Dominio;

namespace VisitasDomiciliarias.App.Persistencia

{
    public interface IRepositorioPropietario 
    {
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario AddPropietario(Propietario propietario);
        Propietario UpdatePropietario(Propietario propietario);
        void DeletePropietario (int propietarioId);
        Propietario GetPropietario (int propietarioId);

    }
}