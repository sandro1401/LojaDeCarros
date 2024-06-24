using System.ComponentModel.DataAnnotations;

namespace LojaDeCarros.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        [Required]
        [MinLength(2), MaxLength(30)]
        public string Name { get; set; }
        public DateTime DataAdmissão { get; set; }
        public int Matricula {  get; set; }

        [DisplayFormat(DataFormatString = "{0:#,##0.00}")]
        public double Salary { get; set; }

        public List<Nota> Notas { get; set; } = new List<Nota>();


    }
}
