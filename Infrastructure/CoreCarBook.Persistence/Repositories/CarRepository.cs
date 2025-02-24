using CoreCarBook.Domain.Entities;
using CoreCarBook.Domain.Repositories;
using CoreCarBook.Persistence.Context;

namespace CoreCarBook.Persistence.Repositories;
public class CarRepository : GenericRepository<Car>, ICarRepository
{
    public CarRepository(CarBookContext _context) : base(_context)
    {
    }
}