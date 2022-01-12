using GuardiansApp.Controllers;
using GuardiansApp.Interfaces;
using GuardiansApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GuardiansAppTests
{
    public class DraxServiceTest
    {
        private Mock<IDraxService> draxServiceMoq = new Mock<IDraxService>();
        private Mock<IAwsomeMixService> awsomeMixServiceMoq = new Mock<IAwsomeMixService>();
        private ApiGuardianController guardianController;

        [Fact]
        public void DraxTest_GetAllItems()
        {
            var foods = new FoodListResponse()
            {
                Foods = new List<Food>() { new Food() { Amount = 1, Name = "banana", Calorie = 20, Id = 1 } }
            };

            draxServiceMoq.Setup(x => x.GetAllItems()).Returns(foods);

            var actual = draxServiceMoq;

            Assert.IsType<FoodListResponse>(actual);
            //Assert.Equal(foods.Foods, actual.Foods);
        }
    }
}
