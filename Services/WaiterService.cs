using Microsoft.EntityFrameworkCore;
using ctds_webapi.Models;

namespace ctds_webapi.Services;

public class WaiterService : IWaiterService
{
    OracleDBContext context;

    public WaiterService(OracleDBContext dbContext)
    {
        context = dbContext;
    }

    public IEnumerable<Waiter> Get()
    {
        return context.Waiters;
    }

    public async Task Save(Waiter waiter)
    {
        waiter.Id = Guid.NewGuid();
        context.Waiters.Add(waiter);
        await context.SaveChangesAsync();
    }

    public async Task Update(Guid id, Waiter waiter)
    {
        var waiterToUpdate = context.Waiters.Find(id);

        if(waiterToUpdate != null)
        {
            waiterToUpdate.Name = waiter.Name;
            waiterToUpdate.LastName = waiter.LastName;
            waiterToUpdate.Age = waiter.Age;
            waiterToUpdate.Seniority = waiter.Seniority;

            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        var waiterToDelete = context.Waiters.Find(id);

        if(waiterToDelete != null)
        {
            context.Waiters.Remove(waiterToDelete);

            await context.SaveChangesAsync();
        }
    }

    public IEnumerable<TotalSellsByWaiter> TotalSells()
    {
        var TOTAL_SELLS_BY_WAITER = context.TotalSellsByWaiter.FromSqlInterpolated($"SELECT \"w\".\"Name\", \"w\".\"LastName\", sum(\"dBill\".\"Value\") AS WaiterSells FROM \"Waiter\" \"w\" INNER JOIN \"Bill\" \"b\" ON \"w\".\"Id\" = \"b\".\"WaiterId\" INNER JOIN \"Detail_Bill\" \"dBill\" ON \"b\".\"BillId\" = \"dBill\".\"BillId\" GROUP BY \"w\".\"Name\", \"w\".\"LastName\" ORDER BY sum(\"dBill\".\"Value\") DESC;");

        return TOTAL_SELLS_BY_WAITER.ToList();
    }
}

public interface IWaiterService
{
    IEnumerable<Waiter> Get();
    Task Save(Waiter waiter);
    Task Update(Guid id, Waiter waiter);
    Task Delete(Guid id);
    IEnumerable<TotalSellsByWaiter> TotalSells();

}