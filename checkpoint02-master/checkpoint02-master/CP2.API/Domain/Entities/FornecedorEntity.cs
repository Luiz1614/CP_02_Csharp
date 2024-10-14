using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.API.Domain.Entities;

[Table("CP_Fornecedor")]
public class FornecedorEntity : BaseEntity
{
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}
