using System.ComponentModel.DataAnnotations;

namespace SuyxFlow.Core.Requests.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = "O tútlo deve conter até 80 catacteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição inválida")]
    public string Description { get; set; } = string.Empty;
}