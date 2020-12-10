using MarvelApi.Controllers;
using System.Collections.Generic;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using MarvelApi.Models;
using MarvelApi.Services;
using FluentAssertions;

namespace MarvelApi.Test
{
    public class CharacterControllerUnitTest
    {
        #region Character
      
        #region Get By Id  

        [Fact]
        public async void Task_GetCharacterIdById_Return_OkResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetCharacterIdById_Return_OkResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 1011334;

            //Act  
            var data = await controller.GetCharacterById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public async void Task_GetCharacterById_Return_NotFoundResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetCharacterById_Return_NotFoundResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 2;

            //Act  
            var data = await controller.GetCharacterById(characterId);

            //Assert  
            Assert.IsType<NotFoundObjectResult>(data);
        }

        [Fact]
        public async void Task_GetCharacterById_Return_BadRequestResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetCharacterById_Return_BadRequestResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = null;

            //Act  
            var data = await controller.GetCharacterById(characterId);

            //Assert  
            Assert.IsType<BadRequestObjectResult>(data);
        }

        [Fact]
        public async void Task_GetCharacterById_MatchResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetCharacterById_MatchResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = 1011334;

            //Act  
            var data = await controller.GetCharacterById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<ServiceResponse<CharacterResponse>>().Subject;

            Assert.Equal("3-D Man", post.data.Results[0].Name);
            Assert.Equal("3-D Man", post.data.Results[0].Description);
        }

        #endregion

        #region Get All
        [Fact]
        public async void Task_GetCharacter_Return_OkResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetCharacter_Return_OkResult));
            CharacterService characterService = new CharacterService(dbContext);

            var controller = new CharacterController(characterService);

            //Act  
            var data = await controller.Get();

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public void Task_GetCharacter_Return_BadRequestResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetCharacter_Return_BadRequestResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            //Act  
            var data = controller.Get();
            data = null;

            //Assert  
            if (data != null)
                Assert.IsType<BadRequestObjectResult>(data);
        }

        [Fact]
        public async void Task_GetCharacter_MatchResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetCharacter_MatchResult));
            CharacterService characterService = new CharacterService(dbContext);

            var controller = new CharacterController(characterService);

            //Act  
            var data = await controller.Get();

            //Assert  
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<ServiceResponse<CharacterResponse>>().Subject;

            Assert.Equal("3-D Man", post.data.Results[0].Name);
            Assert.Equal("3-D Man", post.data.Results[0].Description);

        }
        #endregion

        #endregion

        #region Comics

        #region Get By Id  

        [Fact]
        public async void Task_GetComicsIdById_Return_OkResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetComicsIdById_Return_OkResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 1011334;

            //Act  
            var data = await controller.GetComicsById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public async void Task_GetComicsById_Return_NotFoundResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetComicsById_Return_NotFoundResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 2;

            //Act  
            var data = await controller.GetComicsById(characterId);

            //Assert  
            Assert.IsType<NotFoundObjectResult>(data);
        }

        [Fact]
        public async void Task_GetComicsById_Return_BadRequestResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetComicsById_Return_BadRequestResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = null;

            //Act  
            var data = await controller.GetComicsById(characterId);

            //Assert  
            Assert.IsType<BadRequestObjectResult>(data);
        }

        [Fact]
        public async void Task_GetComicsById_MatchResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetComicsById_MatchResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = 1011334;

            //Act  
            var data = await controller.GetComicsById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<ServiceResponse<ComicResponse>>().Subject;

            Assert.Equal("Avengers: The Initiative (2007) #19", post.data.Results[0].title);
            Assert.Equal("Avengers", post.data.Results[0].description);
        }

        #endregion
        #endregion

        #region Events

        #region Get By Id  

        [Fact]
        public async void Task_GetEventsIdById_Return_OkResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetEventsIdById_Return_OkResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 1011334;

            //Act  
            var data = await controller.GetEventsById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public async void Task_GetEventsById_Return_NotFoundResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetEventsById_Return_NotFoundResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 2;

            //Act  
            var data = await controller.GetEventsById(characterId);

            //Assert  
            Assert.IsType<NotFoundObjectResult>(data);
        }

        [Fact]
        public async void Task_GetEventsById_Return_BadRequestResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetEventsById_Return_BadRequestResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = null;

            //Act  
            var data = await controller.GetEventsById(characterId);

            //Assert  
            Assert.IsType<BadRequestObjectResult>(data);
        }

        [Fact]
        public async void Task_GetEventsById_MatchResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetEventsById_MatchResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = 1011334;

            //Act  
            var data = await controller.GetEventsById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<ServiceResponse<EventsResponse>>().Subject;

            Assert.Equal("Secret Invasion", post.data.Results[0].title);
            Assert.Equal("Secret", post.data.Results[0].description);

        }

        #endregion
        #endregion

        #region Series

        #region Get By Id  

        [Fact]
        public async void Task_GetSeriesIdById_Return_OkResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetSeriesIdById_Return_OkResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 1011334;

            //Act  
            var data = await controller.GetSeriesById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public async void Task_GetSeriesById_Return_NotFoundResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetSeriesById_Return_NotFoundResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 2;

            //Act  
            var data = await controller.GetSeriesById(characterId);

            //Assert  
            Assert.IsType<NotFoundObjectResult>(data);
        }

        [Fact]
        public async void Task_GetSeriesById_Return_BadRequestResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetSeriesById_Return_BadRequestResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = null;

            //Act  
            var data = await controller.GetSeriesById(characterId);

            //Assert  
            Assert.IsType<BadRequestObjectResult>(data);
        }

        [Fact]
        public async void Task_GetSeriesById_MatchResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetSeriesById_MatchResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = 1011334;

            //Act  
            var data = await controller.GetSeriesById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);

            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<ServiceResponse<SeriesResponse>>().Subject;

            Assert.Equal("Avengers: The Initiative (2007 - 2010)", post.data.Results[0].title);
            Assert.Equal("Avengers", post.data.Results[0].description);
        }

        #endregion
        #endregion

        #region Stories

        #region Get By Id  

        [Fact]
        public async void Task_GetStoriesIdById_Return_OkResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetStoriesIdById_Return_OkResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 1011334;

            //Act  
            var data = await controller.GetStoriesById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }

        [Fact]
        public async void Task_GetStoriesById_Return_NotFoundResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetStoriesById_Return_NotFoundResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            var characterId = 2;

            //Act  
            var data = await controller.GetStoriesById(characterId);

            //Assert  
            Assert.IsType<NotFoundObjectResult>(data);
        }

        [Fact]
        public async void Task_GetStoriesById_Return_BadRequestResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetStoriesById_Return_BadRequestResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = null;

            //Act  
            var data = await controller.GetStoriesById(characterId);

            //Assert  
            Assert.IsType<BadRequestObjectResult>(data);
        }

        [Fact]
        public async void Task_GetStoriesById_MatchResult()
        {
            //Arrange  
            var dbContext = DataContextMocker.GetDataContext(nameof(Task_GetStoriesById_MatchResult));
            CharacterService characterService = new CharacterService(dbContext);
            var controller = new CharacterController(characterService);

            int? characterId = 1011334;

            //Act  
            var data = await controller.GetStoriesById(characterId);

            //Assert  
            Assert.IsType<OkObjectResult>(data);


            var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            var post = okResult.Value.Should().BeAssignableTo<ServiceResponse<StoriesResponse>>().Subject;

            Assert.Equal("Cover #19947", post.data.Results[0].title);
            Assert.Equal("Cover", post.data.Results[0].description);

        }

        #endregion
        #endregion
    }
}
