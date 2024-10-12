using System.ComponentModel.DataAnnotations;

namespace CP2.API.Application.Dtos
{
    public class VendedorDto
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email não é válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Phone(ErrorMessage = "O telefone não é válido.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "A data de contratação é obrigatória.")]
        public DateTime DataContratacao { get; set; }

        [Required(ErrorMessage = "O percentual de comissão é obrigatório.")]
        [Range(0, 100, ErrorMessage = "O percentual de comissão deve estar entre 0 e 100.")]
        public decimal ComissaoPercentual { get; set; }

        [Required(ErrorMessage = "A meta mensal é obrigatória.")]
        public decimal MetaMensal { get; set; }

        [Required(ErrorMessage = "A data de criação é obrigatória.")]
        public DateTime CriadoEm { get; set; }
    }
}
