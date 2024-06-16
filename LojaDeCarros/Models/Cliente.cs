using System.ComponentModel.DataAnnotations;

namespace LojaDeCarros.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        [Required]
        [MinLength(2), MaxLength(30)]
        public string Name { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        [MinLength(6, ErrorMessage = "Insira um email com mais caracteres")]
        [MaxLength(30, ErrorMessage = "Email muito lomgo")]
        public string Email { get; set; }
        public int telefone { get; set; }
        public string Endereco { get; set; }
        public int CPF { get; set; }

    }
}
