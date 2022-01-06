using GuardiansApp;
using GuardiansApp.Controllers;
using GuardiansApp.Models;
using GuardiansApp.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
            var response = HttpClient.GetAsync($"/groot?message={expectedReceived}").Result;
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
            var response = HttpClient.GetAsync($"/groot").Result;
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
            var response = HttpClient.GetAsync($"/yondu?distance={expectedDistance}&time={expectedTime}").Result;
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
            var response = HttpClient.GetAsync($"/yondu").Result;
            string responseBodyContent = response.Content.ReadAsStringAsync().Result;
            ErrorResponse responseData = JsonConvert.DeserializeObject<ErrorResponse>(responseBodyContent);

            //assert
            Assert.Equal(expectedStatusCode, response.StatusCode);
            Assert.Equal(expectedError, responseData.Error);
        }        
    }
}
