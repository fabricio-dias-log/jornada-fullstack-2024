using System.ComponentModel.DataAnnotations;

namespace SuyxFlow.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O tútlo deve conter até 80 catacteres")]
    public string Title { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Descrição inválida")]
    public string Description { get; set; } = string.Empty;
}