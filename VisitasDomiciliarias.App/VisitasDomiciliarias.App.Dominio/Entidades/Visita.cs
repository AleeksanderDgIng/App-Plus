namespace VisitasDomiciliarias.App.Dominio
{   public class Visita
    {
        public int VisitaId {get; set;}
        public string Fecha {get ; set;}
        public Veterinario Visitante {get ; set;}
    }
}