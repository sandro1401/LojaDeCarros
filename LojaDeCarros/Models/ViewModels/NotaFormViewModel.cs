namespace LojaDeCarros.Models.ViewModels
{
    public class NotaFormViewModel
    {
        public Nota Nota { get; set; }

        public List<Carro> Carros { get; set; }

        public List<Seller> Sellers { get; set; }

        public List<Cliente> Clientes { get; set; }
    }
}
