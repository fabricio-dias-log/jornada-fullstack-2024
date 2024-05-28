namespace SuyxFlow.Core.Requests.Transactions;

public class GetTransactionByPeriodRequest : PagedRequest
{
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
}