using CoreCarBook.Domain.Services;
using CoreCarBook.Domain.Entities;
using CoreCarBook.Domain.Repositories;

namespace CoreCarBook.Application.Services;
public class CarService(ICarRepository carRepository) : ICarService
{
    public async Task AddCarAsync(Car car)
    {
        await carRepository.AddAsync(car);
        await carRepository.SaveChangesAsync();
    }

    public async Task DeleteCarAsync(int id)
    {
        var car = await carRepository.GetByIdAsync(id);
        if(car is not null)
        {
            carRepository.Remove(car);
            await carRepository.SaveChangesAsync();
        }
    }

    public async Task<List<Car>> GetAllCarsAysnc()
    {
        return await carRepository.GetAllAsync();
    }

    public async Task<Car> GetCarByIdAsync(int id)
    {
        return await carRepository.GetByIdAsync(id);
    }

    public async Task UpdateCarAsync(Car car)
    {
        carRepository.Update(car);
        await carRepository.SaveChangesAsync();
    }
}