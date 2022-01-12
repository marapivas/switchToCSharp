using GuardiansApp.Models;
using System.Collections.Generic;

namespace GuardiansApp.Interfaces
{
    public interface IDraxService
    {
        FoodListResponse GetAllItems();
        FoodListResponse Add(string name, int amount, int calorie);
        FoodListResponse Delete(int id);
        FoodListResponse Edit(int id, int amount);
        Food FindById(int id);
        List<int> GetAllIds();
    }
}
