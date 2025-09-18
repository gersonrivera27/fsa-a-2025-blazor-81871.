public static class CarRepository
{
    public static List<Car> GetCars() => new()
    {
        new() { Id = 1, Make = "Toyota", Model = "Corolla", Year = 2019, Color = "White", Mileage = 35000 },
        new() { Id = 2, Make = "Honda", Model = "Civic", Year = 2020, Color = "Black", Mileage = 28000 },
        new() { Id = 3, Make = "Ford", Model = "Focus", Year = 2018, Color = "Blue", Mileage = 45000 },
        new() { Id = 4, Make = "Tesla", Model = "Model 3", Year = 2021, Color = "Red", Mileage = 15000 },
        new() { Id = 5, Make = "BMW", Model = "X5", Year = 2017, Color = "Gray", Mileage = 60000 },
        // ... sigue hasta tener 25
    };
}