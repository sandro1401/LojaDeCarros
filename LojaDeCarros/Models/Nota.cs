namespace LojaDeCarros.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Garantia { get; set; }
        public double ValorVenda { get; set; }
        public Cliente Comprador {  get; set; }
        public Seller Seller { get; set; }
        public Carro Carro { get; set; }
    }
}
