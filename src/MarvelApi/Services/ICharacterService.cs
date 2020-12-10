using MarvelApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarvelApi.Services
{
    public interface ICharacterService
    {
        Task<ServiceResponse<CharacterResponse>> GetAllCharacter();
        Task<ServiceResponse<CharacterResponse>> GetCharacterById(int? characterId);
        Task<ServiceResponse<ComicResponse>> GetComicsById(int? characterId);
        Task<ServiceResponse<EventsResponse>> GetEventsById(int? characterId);
        Task<ServiceResponse<SeriesResponse>> GetSeriesById(int? characterId);
        Task<ServiceResponse<StoriesResponse>> GetStoriesById(int? characterId);
    }
}
