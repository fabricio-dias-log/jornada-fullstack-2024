using System.ComponentModel.DataAnnotations;
using SuyxFlow.Core.Enums;

namespace SuyxFlow.Core.Requests.Transactions;

public class UpdateTransactionRequest : Request
{
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O tútlo deve conter até 80 catacteres")]
    public string Title { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Tipo inválido")]
    public ETransactionType Type { get; set; }
    
    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Descrição inválida")]
    public string Description { get; set; } = string.Empty;
}