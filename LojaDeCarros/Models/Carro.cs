namespace LojaDeCarros.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int AnoFabricacao { get; set;}
        public int AnoModelo { get; set;}
        public int Chassi { get; set;}  
        public int Preco { get; set;}

        public List<Nota> Notas { get; set; } = new List<Nota>();

    }
}
