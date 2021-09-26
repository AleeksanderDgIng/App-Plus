using System;
namespace VisitasDomiciliarias.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id {get; set;}
        public double Temperatura{get;set;}
        public double Peso{get;set;}
        public int FrecRespiratoria {get;set;}
        public int FrecCardiaca {get;set;}
        public string EstadoAnimo {get;set;}
        public string FechaVisita {get;set;}
        public string Recomendaciones {get;set;}
        public Mascota LePertenece {get;set;}
        public Veterinario EsRegistrada {get;set;}


    }

}