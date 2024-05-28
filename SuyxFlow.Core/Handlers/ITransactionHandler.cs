using SuyxFlow.Core.Models;
using SuyxFlow.Core.Requests.Transactions;
using SuyxFlow.Core.Responses;

namespace SuyxFlow.Core.Handlers;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
    Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
    Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request);
    Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest request);
    Task<PagedResponse<List<Transaction>?>> GetByPeriodAsync(GetTransactionByPeriodRequest request);
}