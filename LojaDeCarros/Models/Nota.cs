using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace LojaDeCarros.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Garantia { get; set; }
        public double ValorVenda { get; set; }
        
        [Display(Name = "Cliente")]
        public int CompradorId { get; set; }
        public Cliente Comprador {  get; set; }
       
        [Display(Name ="Vendedor")]
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        
        [Display(Name = "Veiculo")]
        public int CarroId { get; set; }
        public Carro Carro { get; set; }

       
    }
}
