using MarvelApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MarvelApi.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly DataContext _context;
       
        List<Character> characters = new List<Character>();
        List<Comic> comics = new List<Comic>();
        List<Series> series = new List<Series>();
        List<Story> stories = new List<Story>();
        List<Event> events = new List<Event>();

        public CharacterService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<CharacterResponse>> GetAllCharacter()
        {
            ServiceResponse<CharacterResponse> serviceResponse = new ServiceResponse<CharacterResponse>();
            DataResponse<CharacterResponse> dataResponse = new DataResponse<CharacterResponse>();
            try
            {
                this.QueryData();

                List<CharacterResponse> lCharacters = new List<CharacterResponse>();

                foreach (var itemCharacter in characters)
                {
                    CharacterResponse characterResponse = new CharacterResponse();
                    characterResponse.Id = itemCharacter.Id;
                    characterResponse.Name = itemCharacter.Name;
                    characterResponse.Description = itemCharacter.Description;
                    characterResponse.ResourceURI = itemCharacter.ResourceUri;
                    characterResponse.Comics = AddComics(comics.Where(item => item.Equals(itemCharacter.Id)));
                    characterResponse.Series = AddSeries(series.Where(item => item.Equals(itemCharacter.Id)));
                    characterResponse.Stories = AddStories(stories.Where(item => item.Equals(itemCharacter.Id)));
                    characterResponse.Events = AddEvents(events.Where(item => item.Equals(itemCharacter.Id)));
                    lCharacters.Add(characterResponse);
                }

                dataResponse.Results = lCharacters;
                serviceResponse.data = dataResponse;

                return serviceResponse;
            }
            catch (Exception)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<CharacterResponse>> GetCharacterById(int? characterId)
        {
            ServiceResponse<CharacterResponse> serviceResponse = new ServiceResponse<CharacterResponse>();
            DataResponse<CharacterResponse> dataResponse = new DataResponse<CharacterResponse>();
            try
            {
                this.QueryDataId(Convert.ToInt32(characterId));

                List<CharacterResponse> lCharacters = new List<CharacterResponse>();

                foreach (var itemCharacter in characters)
                {
                    CharacterResponse characterResponse = new CharacterResponse();
                    characterResponse.Id = itemCharacter.Id;
                    characterResponse.Name = itemCharacter.Name;
                    characterResponse.Description = itemCharacter.Description;
                    characterResponse.Modified = Convert.ToDateTime(itemCharacter.Modified);
                    characterResponse.ResourceURI = itemCharacter.ResourceUri;
                    characterResponse.Comics = AddComics(comics.Where(item => item.Equals(itemCharacter.Id)));
                    characterResponse.Series = AddSeries(series.Where(item => item.Equals(itemCharacter.Id)));
                    characterResponse.Stories = AddStories(stories.Where(item => item.Equals(itemCharacter.Id)));
                    characterResponse.Events = AddEvents(events.Where(item => item.Equals(itemCharacter.Id)));
                    lCharacters.Add(characterResponse);
                }

                dataResponse.Results = lCharacters;
                serviceResponse.data = dataResponse;

                return serviceResponse;
            }
            catch (Exception)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<ComicResponse>> GetComicsById(int? characterId)
        {
            ServiceResponse<ComicResponse> serviceResponse = new ServiceResponse<ComicResponse>();
            DataResponse<ComicResponse> dataResponse = new DataResponse<ComicResponse>();

            try
            {
                this.QueryDataId(Convert.ToInt32(characterId));

                List<ComicResponse> comicResponses = new List<ComicResponse>();

                foreach (var itemComic in comics)
                {
                    ComicResponse comicResponse = new ComicResponse();
                    comicResponse.id = itemComic.Id;
                    comicResponse.digitalId = Convert.ToInt32(itemComic.DigitalId);
                    comicResponse.title = itemComic.Title;
                    comicResponse.issueNumber = Convert.ToDecimal(itemComic.IssueNumber);
                    comicResponse.variantDescription = itemComic.VariantDescription;
                    comicResponse.description = itemComic.Description;
                    comicResponse.modified = Convert.ToDateTime(itemComic.Modified);
                    comicResponse.isbn = itemComic.Isbn;
                    comicResponse.upc = itemComic.Upc;
                    comicResponse.diamondCode = itemComic.DiamondCode;
                    comicResponse.ean = itemComic.Ean;
                    comicResponse.issn = itemComic.Issn;
                    comicResponse.format = itemComic.Format;
                    comicResponse.pageCount = itemComic.PageCount;
                    comicResponse.resourceURI = itemComic.ResourceUri;
                    comicResponses.Add(comicResponse);
                }

                dataResponse.Results = comicResponses;
                serviceResponse.data = dataResponse;

                return serviceResponse;
            }
            catch (Exception)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<EventsResponse>> GetEventsById(int? characterId)
        {
            ServiceResponse<EventsResponse> serviceResponse = new ServiceResponse<EventsResponse>();
            DataResponse<EventsResponse> dataResponse = new DataResponse<EventsResponse>();
            try
            {
                this.QueryDataId(Convert.ToInt32(characterId));

                List<EventsResponse> eventResponses = new List<EventsResponse>();

                foreach (var itemEvent in this.events)
                {
                    EventsResponse eventResponse = new EventsResponse();
                    eventResponse.id = itemEvent.Id;
                    eventResponse.title = itemEvent.Title;
                    eventResponse.description = itemEvent.Description;
                    eventResponse.resourceURI = itemEvent.ResourceUri;
                    eventResponse.modified = Convert.ToString(itemEvent.Modified);
                    eventResponse.start = Convert.ToString(itemEvent.StartDate);
                    eventResponse.end = Convert.ToString(itemEvent.EndDate);
                    eventResponses.Add(eventResponse);
                }

                dataResponse.Results = eventResponses;
                serviceResponse.data = dataResponse;

                return serviceResponse;
            }
            catch (Exception)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<SeriesResponse>> GetSeriesById(int? characterId)
        {
            ServiceResponse<SeriesResponse> serviceResponse = new ServiceResponse<SeriesResponse>();
            DataResponse<SeriesResponse> dataResponse = new DataResponse<SeriesResponse>();

            try
            {
                this.QueryDataId(Convert.ToInt32(characterId));

                List<SeriesResponse> seriesResponses = new List<SeriesResponse>();

                foreach (var itemSerie in this.series)
                {
                    SeriesResponse serieResponse = new SeriesResponse();
                    serieResponse.id = itemSerie.Id;
                    serieResponse.title = itemSerie.Title;
                    serieResponse.description = itemSerie.Description;
                    serieResponse.resourceURI = itemSerie.ResourceUri;
                    serieResponse.modified = Convert.ToString(itemSerie.Modified);
                    serieResponse.startYear = Convert.ToString(itemSerie.StartYear);
                    serieResponse.endYear = Convert.ToString(itemSerie.EndYear);
                    serieResponse.rating = Convert.ToString(itemSerie.Rating);
                    serieResponse.modified = Convert.ToString(itemSerie.Modified);
                    seriesResponses.Add(serieResponse);
                }

                dataResponse.Results = seriesResponses;
                serviceResponse.data = dataResponse;

                return serviceResponse;
            }
            catch (Exception)
            {
                return serviceResponse;
            }
        }

        public async Task<ServiceResponse<StoriesResponse>> GetStoriesById(int? characterId)
        {
            ServiceResponse<StoriesResponse> serviceResponse = new ServiceResponse<StoriesResponse>();
            DataResponse<StoriesResponse> dataResponse = new DataResponse<StoriesResponse>();

            try
            {
                this.QueryDataId(Convert.ToInt32(characterId));

                List<StoriesResponse> storiesResponses = new List<StoriesResponse>();

                foreach (var itemStories in this.stories)
                {
                    StoriesResponse storieResponse = new StoriesResponse();
                    storieResponse.id = itemStories.Id;
                    storieResponse.title = itemStories.Title;
                    storieResponse.description = itemStories.Description;
                    storieResponse.resourceURI = itemStories.ResourceUri;
                    storieResponse.modified = Convert.ToString(itemStories.Modified);
                    storieResponse.modified = Convert.ToString(itemStories.Modified);
                    storiesResponses.Add(storieResponse);
                }

                dataResponse.Results = storiesResponses;
                serviceResponse.data = dataResponse;

                return serviceResponse;
            }
            catch (Exception)
            {
                return serviceResponse;
            }
        }

        public object QueryData()
        {
            var query = (from character in _context.Characters
                          join charactercomic in _context.CharacterComics on character.Id equals charactercomic.IdCharacter
                          join comic in _context.Comics on charactercomic.IdComics equals comic.Id
                          join characterserie in _context.CharacterSeries on character.Id equals characterserie.IdCharacter
                          join serie in _context.Series on characterserie.IdSeries equals serie.Id
                          join characterstory in _context.CharacterStories on character.Id equals characterstory.IdCharacter
                          join story in _context.Stories on characterstory.IdStories equals story.Id
                          join characterevent in _context.CharacterEvents on character.Id equals characterevent.IdCharacter
                          join events in _context.Events on characterevent.IdEvents equals events.Id
                          select new { character ,comic,serie, story, events}).ToList();

            characters = new List<Character>();
            comics = new List<Comic>();
            series = new List<Series>();
            stories = new List<Story>();
            events = new List<Event>();

            foreach (var itemQuery in query)
            {
                characters.Add(itemQuery.character);
                comics.Add(itemQuery.comic);
                series.Add(itemQuery.serie);
                stories.Add(itemQuery.story);
                events.Add(itemQuery.events);
            }

            return query;
        }

        public object QueryDataId(int characterID)
        {

            var query = (from character in _context.Characters
                         join charactercomic in _context.CharacterComics on character.Id equals charactercomic.IdCharacter
                         join comic in _context.Comics on charactercomic.IdComics equals comic.Id
                         join characterserie in _context.CharacterSeries on character.Id equals characterserie.IdCharacter
                         join serie in _context.Series on characterserie.IdSeries equals serie.Id
                         join characterstory in _context.CharacterStories on character.Id equals characterstory.IdCharacter
                         join story in _context.Stories on characterstory.IdStories equals story.Id
                         join characterevent in _context.CharacterEvents on character.Id equals characterevent.IdCharacter
                         join events in _context.Events on characterevent.IdEvents equals events.Id
                         where character.Id == characterID
                         select new { character, comic, serie, story, events }).ToList();

            characters = new List<Character>();
            comics = new List<Comic>();
            series = new List<Series>();
            stories = new List<Story>();
            events = new List<Event>();

            foreach (var itemQuery in query)
            {
                characters.Add(itemQuery.character);
                comics.Add(itemQuery.comic);
                series.Add(itemQuery.serie);
                stories.Add(itemQuery.story);
                events.Add(itemQuery.events);
            }

            return query;
        }

        private ComicList AddComics(IEnumerable<Comic> comics)
        {
            ComicList comicList = new ComicList();
            List<ComicSummary> comicSummaries = new List<ComicSummary>();

            comicList.available = comics.Count();
            comicList.returned = comics.Count();
            comicList.collectionURI = string.Empty;
            foreach (var item in comics)
            {
                comicSummaries.Add(new ComicSummary() { resourceURI = item.ResourceUri, name = item.Title });
            }

            return comicList;
        }

        private SeriesList AddSeries(IEnumerable<Series> series)
        {
            SeriesList seriesList = new SeriesList();
            List<SeriesSummary> seriesSummaries = new List<SeriesSummary>();

            seriesList.available = series.Count();
            seriesList.returned = series.Count();
            seriesList.collectionURI = string.Empty;
            foreach (var item in series)
            {
                seriesSummaries.Add(new SeriesSummary() { resourceURI = item.ResourceUri, name = item.Title });
            }

            return seriesList;
        }

        private StoriesList AddStories(IEnumerable<Story> stories)
        {
            StoriesList storiesList = new StoriesList();
            List<StoriesSummary> storySummaries = new List<StoriesSummary>();

            storiesList.available = stories.Count();
            storiesList.returned = stories.Count();
            storiesList.collectionURI = string.Empty;
            foreach (var item in stories)
            {
                storySummaries.Add(new StoriesSummary() { resourceURI = item.ResourceUri, name = item.Title, type = item.Type });
            }

            return storiesList;
        }

        private EventsList AddEvents(IEnumerable<Event> events)
        {
            EventsList eventsList = new EventsList();
            List<EventsSummary> eventsSummaries = new List<EventsSummary>();

            eventsList.available = events.Count();
            eventsList.returned = events.Count();
            eventsList.collectionURI = string.Empty;
            foreach (var item in events)
            {
                eventsSummaries.Add(new EventsSummary() { resourceURI = item.ResourceUri, name = item.Title });
            }

            return eventsList;
        }


    }
}
