using System;

namespace VisitasDomiciliarias.App.Dominio
{   public class Mascota
    {
        
        public int MascotaId {get; set;}
        public float Temperatura {get ; set;}
        public float Peso {get ; set;}
        public int FrecRespiratoria {get ; set;}
        public int FrecCardiaca {get ; set;}
        public string EstadoAnimo {get ; set;}
        public string Recomendaciones {get ; set;}
        public bool Tipo {get ; set;}
        public Visita Fechas {get ; set;}
        public Veterinario Identificacion {get ; set;}
        public Propietario Owner {get ; set;}
        
    }
}