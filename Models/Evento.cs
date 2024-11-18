using System;

namespace MauiAppCE.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Calcula a duração em dias
        public int Duracao => (DataTermino - DataInicio).Days + 1;

        // Calcula o custo total
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}
