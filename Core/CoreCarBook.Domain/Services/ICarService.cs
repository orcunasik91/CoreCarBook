using CoreCarBook.Domain.Entities;

namespace CoreCarBook.Domain.Services;
public interface ICarService
{
    Task<List<Car>> GetAllCarsAysnc();
    Task<Car> GetCarByIdAsync(int id);
    Task AddCarAsync(Car car);
    Task UpdateCarAsync(Car car);
    Task DeleteCarAsync(int id);
}