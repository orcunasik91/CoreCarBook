using CoreCarBook.Domain.Repositories;
using CoreCarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CoreCarBook.Persistence.Repositories;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly CarBookContext context;
    private readonly DbSet<T> dbSet;

    public GenericRepository(CarBookContext _context)
    {
        context = _context;
        dbSet = context.Set<T>();
    }

    public async Task AddAsync(T entity) => await dbSet.AddAsync(entity);

    public async Task<List<T>> GetAllAsync() => await dbSet.ToListAsync();

    public async Task<T> GetByIdAsync(int id) => await dbSet.FindAsync(id);

    public void Remove(T entity) => dbSet.Remove(entity);

    public async Task<int> SaveChangesAsync() => await context.SaveChangesAsync();

    public void Update(T entity) => dbSet.Update(entity);
}