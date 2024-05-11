using Microsoft.AspNetCore.Mvc;
using Moq;
using MyApp.Models;
using PokemonAPI.Controllers;
namespace PockemonAPI.IntegrationsTests
{
    [TestClass]
    public class PockemonControllerTests
    {
        private PokemonController _controller;
        private Mock<IPokemonApi> _serviceApiMock;

        [TestInitialize]
        public void Setup()
        {
            _serviceApiMock = new Mock<IPokemonApi>();
            _controller = new PokemonController(_serviceApiMock.Object);
        }

        [TestMethod]
        public void GetByIdOrName_WhenIdIsProvided_ReturnsPokemon()
        {
            // Arrange
            int pokemonId = 5;
            PokemonDto expectedPokemon = new PokemonDto { Id = pokemonId, Name = "charmeleon"};
            _serviceApiMock.Setup(api => api.GetByIdOrName(pokemonId.ToString())).Returns(expectedPokemon);
            // Act
            var result = _controller.GetByIdOrName(pokemonId.ToString());
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedPokemon.Name, result.Name);
        }

        [TestMethod]
        public void GetByIdOrName_WhenNameIsProvided_ReturnsPokemon()
        {
            // Arrange
            string pokemonName = "bulbasaur";
            PokemonDto expectedPokemonDto = new PokemonDto { Id = 1, Name = pokemonName };
            _serviceApiMock.Setup(api => api.GetByIdOrName(pokemonName)).Returns(expectedPokemonDto);

            //Act
            var result = _controller.GetByIdOrName(pokemonName);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedPokemonDto.Name, result.Name);
        }
        
        [TestMethod]
        public void GetAll_WhenNoPageAndCount_ReturnsStatusCode200()
        {
            // Arrange
          

            // Act
            var result = _controller.GetAll(null, null) as OkObjectResult;
            
            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }
        
        [TestMethod]
        public void GetByFilter_WhenNoPageAndCount_ReturnsStatusCode200()
        {
            // Arrange
          

            // Act
            var result = _controller.GetByFilter("Bulbasaur", null, null) as OkObjectResult;
            
            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }
    }
}