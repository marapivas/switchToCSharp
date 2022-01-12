using GuardiansApp;
using GuardiansApp.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Xunit;

namespace GuardiansAppTests
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<Startup>>
    {

        private HttpClient HttpClient { get; set; }

        public UnitTest1(WebApplicationFactory<Startup> factory)
        {
            HttpClient = factory.CreateClient();
        }

        [Fact]
        public void GrootTest_OK()
        {
            //[arrange]
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            string expectedReceived = "somemessage";
            string expectedTranslated = "I am Groot!";

            //act
            var response = HttpClient.GetAsync($"/api/groot?message={expectedReceived}").Result;
            string responseBodyContent = response.Content.ReadAsStringAsync().Result;
            Groot responseData = JsonConvert.DeserializeObject<Groot>(responseBodyContent);

            //assert
            Assert.Equal(expectedStatusCode, response.StatusCode);
            Assert.Equal(expectedReceived, responseData.received);
            Assert.Equal(expectedTranslated, responseData.translated);
        }

        [Fact]
        public void GrootTest_BadRequest()
        {
            //[arrange]
            HttpStatusCode expectedStatusCode = HttpStatusCode.BadRequest;
            string expectedError = "I am Groot!";

            //act
            var response = HttpClient.GetAsync($"/api/groot").Result;
            string responseBodyContent = response.Content.ReadAsStringAsync().Result;
            ErrorResponse responseData = JsonConvert.DeserializeObject<ErrorResponse>(responseBodyContent);          

            //assert
            Assert.Equal(expectedStatusCode, response.StatusCode);       
            Assert.Equal(expectedError, responseData.Error);
        }

        [Fact]
        public void YonduTest_OK()
        {
            //[arrange]
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;
            double expectedDistance = 100.0;
            double expectedTime = 10.0;
            double expectedSpeed = 10.0;

            //act
            var response = HttpClient.GetAsync($"/api/yondu?distance={expectedDistance}&time={expectedTime}").Result;
            string responseBodyContent = response.Content.ReadAsStringAsync().Result;
            Yondu responseData = JsonConvert.DeserializeObject<Yondu>(responseBodyContent);

            //assert
            Assert.Equal(expectedStatusCode, response.StatusCode);
            Assert.Equal(expectedDistance, responseData.distance);
            Assert.Equal(expectedTime, responseData.time);
            Assert.Equal(expectedSpeed, responseData.speed);
        }

        [Fact]
        public void YonduTest_BadRequest()
        {
            //[arrange]
            HttpStatusCode expectedStatusCode = HttpStatusCode.BadRequest;
            string expectedError = "You have to fill time";

            //act
            var response = HttpClient.GetAsync($"/api/yondu").Result;
            string responseBodyContent = response.Content.ReadAsStringAsync().Result;
            ErrorResponse responseData = JsonConvert.DeserializeObject<ErrorResponse>(responseBodyContent);

            //assert
            Assert.Equal(expectedStatusCode, response.StatusCode);
            Assert.Equal(expectedError, responseData.Error);
        }

        [Fact]
        public void DraxTest_AddNewFood()
        {
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK;

            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://localhost:44347/api/drax/add?name=banana&amount=1&calorie=20");
            request.Method = HttpMethod.Post;

            var expected = new FoodListResponse()
            {
                Foods = new List<Food>() { new Food() { Amount = 1, Name = "banana", Calorie = 20, Id = 1 } }
            };

            HttpResponseMessage response = HttpClient.SendAsync(request).Result;
            string responseBodyContent = response.Content.ReadAsStringAsync().Result;
            FoodListResponse responseData = JsonConvert.DeserializeObject<FoodListResponse>(responseBodyContent);

            Assert.Equal(expectedStatusCode, response.StatusCode);
            Assert.Equal(expected.Foods[0].Name, responseData.Foods[0].Name);
            Assert.Equal(expected.Foods[0].Amount, responseData.Foods[0].Amount);
            Assert.Equal(expected.Foods[0].Calorie, responseData.Foods[0].Calorie);
        }
    }
}
