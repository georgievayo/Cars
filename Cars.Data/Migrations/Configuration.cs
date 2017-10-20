using System.Collections.Generic;
using Cars.Models;

namespace Cars.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Cars.Data.CarsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarsDbContext context)
        {
            this.SeedOwners(context);
            this.SeedCarModels(context);
            this.SeedCars(context);
        }

        private void SeedOwners(CarsDbContext context)
        {
            var owners = new List<Owner>()
            {
                new Owner() {Id = 1, FullName = "Pesho Peshov"},
                new Owner() {Id = 2, FullName = "Gosho Goshov"},
                new Owner() {Id = 3, FullName = "Tosho Toshov"}
            };

            foreach (var owner in owners)
            {
                context.Owners.Add(owner);
                context.SaveChanges();
            }
        }

        private void SeedCarModels(CarsDbContext context)
        {
            var models = new List<CarModel>()
            {
                new CarModel() {Id = 1, Description = "Model 1"},
                new CarModel() {Id = 2, Description = "Model 2"}
            };

            foreach (var model in models)
            {
                context.CarModels.Add(model);
                context.SaveChanges();
            }
        }

        private void SeedCars(CarsDbContext context)
        {
            var cars = new List<Car>()
            {
                new Car() {Id = 1, OwnerId = 1, ModelId = 1, Description = "Car 1"},
                new Car() {Id = 2, OwnerId = 3, ModelId = 1, Description = "Car 2"},
                new Car() {Id = 3, OwnerId = 2, ModelId = 1, Description = "Car 3"},
                new Car() {Id = 4, OwnerId = 1, ModelId = 2, Description = "Car 4"},
                new Car() {Id = 5, OwnerId = 2, ModelId = 1, Description = "Car 5"},
                new Car() {Id = 6, OwnerId = 1, ModelId = 2, Description = "Car 6"},

            };

            foreach (var car in cars)
            {
                context.Cars.Add(car);
                context.SaveChanges();
            }
        }
    }
}
