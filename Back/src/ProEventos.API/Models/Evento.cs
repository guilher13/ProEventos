namespace ProEventos.API.Models
{
    public class Evento
    {
        public int EventoId {get; set;}

        public string local {get; set; }

        public string DataEvento { get; set; }

        public string tema { get; set; }

        public int QtdPessoas { get; set; }

        public string Lote { get; set; }

        public string ImagemURL { get; set; }
    }
}