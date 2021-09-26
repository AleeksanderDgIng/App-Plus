using System;

namespace VisitasDomiciliarias.App.Dominio
{   public class Mascota
    {
        
       public string Nombre {get ; set;}
       public string Raza {get;set;}
       public int Edad {get;set;}
       public enum Tipo {perro,gato};
       public int MascotaId {get;set;}
       public Propietario Owner {get;set;}
        
    }
}