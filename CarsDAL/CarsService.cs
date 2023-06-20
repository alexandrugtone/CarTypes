﻿using CarObjects;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CarsDAL
{
    public class CarsService
    {
        private readonly IMongoCollection<Car> _carsCollection;

        public CarsService(
            IOptions<CarsDatabaseSettings> carsDatabaseSettings) : this(carsDatabaseSettings.Value)
        {}

        public CarsService(CarsDatabaseSettings settings)
        {
            var mongoClient = new MongoClient(
               settings.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                settings.DatabaseName);

            _carsCollection = mongoDatabase.GetCollection<Car>(
                settings.CarsCollectionBrand);
        }

        public async Task<List<Car>> GetAsync() =>
            await _carsCollection.Find(_ => true).ToListAsync();

        public async Task<Car?> GetAsync(string id) =>
            await _carsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Car newCar) =>
            await _carsCollection.InsertOneAsync(newCar);

        public async Task UpdateAsync(string id, Car updatedCar) =>
            await _carsCollection.ReplaceOneAsync(x => x.Id == id, updatedCar);

        public async Task RemoveAsync(string id) =>
            await _carsCollection.DeleteOneAsync(x => x.Id == id);
    }
}