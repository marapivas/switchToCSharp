using GuardiansApp.Database;
using GuardiansApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace GuardiansApp.Services
{
    public class DraxService
    {
        private ApplicationDbContext DbContext { get; set; }

        public DraxService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public FoodListResponse GetAllItems()
        {
            FoodListResponse foodList = new FoodListResponse()
            {
                Foods = DbContext.Foods.ToList()
            };

            return foodList;
        }

        public FoodListResponse Add(string name, int amount, int calorie)
        {
            Food food = new Food();
            food.Name = name;
            food.Amount = amount;
            food.Calorie = calorie;
            DbContext.Foods.Add(food);
            DbContext.SaveChanges();

            return GetAllItems();
        }

        public FoodListResponse Delete(int id)
        {
            

            DbContext.Foods.Remove(DbContext.Foods.Where(f => f.Id == id).First());
            DbContext.SaveChanges();

            return GetAllItems();
        }

        public FoodListResponse Edit(int id, int amount)
        {
            Food editFood = FindById(id);
            editFood.Amount = amount;

            return GetAllItems();
        }

        public Food FindById(int id)
        {
            return DbContext.Foods.Where(f => f.Id == id).First();
        }
    }
}
