namespace LojaDeCarros.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set;}
        public int AnoFabricacao { get; set;}
        public int AnoModelo { get; set;}
        public int Chassi { get; set;}  
        public double preco { get; set;}
      
    }
}
