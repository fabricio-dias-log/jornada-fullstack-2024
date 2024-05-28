using SuyxFlow.Core.Models;
using SuyxFlow.Core.Requests.Categories;
using SuyxFlow.Core.Responses;

namespace SuyxFlow.Core.Handlers;

public interface ICategoryHandler
{
    Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
    Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
    Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
    Task<PagedResponse<List<Category>?>> GetAllAsync(CreateCategoryRequest request);
}