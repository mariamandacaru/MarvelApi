using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MarvelApi.Models;
using MarvelApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarvelApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterservice;
        public CharacterController(ICharacterService characterservice)
        {
            _characterservice = characterservice;
        }

        /// <summary>
        /// Fetches lists of characters
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            ServiceResponse<CharacterResponse> response = new ServiceResponse<CharacterResponse>();
            try
            {
                if (!ModelState.IsValid)
                {
                    return Conflict(ModelState);
                }
                else
                {
                    response = await _characterservice.GetAllCharacter();
                    if (response.data.Results.Count == 0)
                        return NotFound(response);
                    else
                        return Ok(response);
                }
            }
            catch (Exception)
            {
                response.code = HttpStatusCode.BadRequest.GetHashCode();
                response.status = HttpStatusCode.BadRequest.ToString();
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Fetches a single character by id.
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        [HttpGet("{characterId}")]
        public async Task<IActionResult> GetCharacterById(int? characterId)
        {
            ServiceResponse<CharacterResponse> response = new ServiceResponse<CharacterResponse>();
            try
            {
                if (!ModelState.IsValid)
                {
                    return Conflict(ModelState);
                }
                else
                {
                    if (characterId == null)
                        return BadRequest(response);
                    response = await _characterservice.GetCharacterById(characterId);
                    if (response.data.Results.Count == 0)
                        return NotFound(response);
                    else
                        return Ok(response);
                }              
            }
            catch (Exception)
            {
                response.code = HttpStatusCode.BadRequest.GetHashCode();
                response.status = HttpStatusCode.BadRequest.ToString();
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Fetches lists of comics filtered by a character id.
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        [HttpGet("{characterId}/comics")]
        public async Task<IActionResult> GetComicsById(int? characterId)
        {
            ServiceResponse<ComicResponse> response = new ServiceResponse<ComicResponse>();
            try
            {
                if (!ModelState.IsValid)
                {
                    return Conflict(ModelState);
                }
                else
                {
                    if (characterId == null)
                        return BadRequest(response);
                    response = await _characterservice.GetComicsById(characterId);
                    if (response.data.Results.Count == 0)
                        return NotFound(response);
                    else
                        return Ok(response);
                }
            }
            catch (Exception)
            {
                response.code = HttpStatusCode.BadRequest.GetHashCode();
                response.status = HttpStatusCode.BadRequest.ToString();
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Fetches lists of events filtered by a character id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        [HttpGet("{characterId}/events")]
        public async Task<IActionResult> GetEventsById(int? characterId)
        {
            ServiceResponse<EventsResponse> response = new ServiceResponse<EventsResponse>();
            try
            {
                if (!ModelState.IsValid)
                {
                    return Conflict(ModelState);
                }
                else
                {
                    if (characterId == null)
                        return BadRequest(response);
                    response = await _characterservice.GetEventsById(characterId);
                    if (response.data.Results.Count == 0)
                        return NotFound(response);
                    else
                        return Ok(response);
                }
            }
            catch (Exception)
            {
                response.code = HttpStatusCode.BadRequest.GetHashCode();
                response.status = HttpStatusCode.BadRequest.ToString();
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Fetches lists of series filtered by a character id
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        [HttpGet("{characterId}/series")]
        public async Task<IActionResult> GetSeriesById(int? characterId)
        {
            ServiceResponse<SeriesResponse> response = new ServiceResponse<SeriesResponse>();
            try
            {
                if (!ModelState.IsValid)
                {
                    return Conflict(ModelState);
                }
                else
                {
                    if (characterId == null)
                        return BadRequest(response);
                    response = await _characterservice.GetSeriesById(characterId);
                    if (response.data.Results.Count == 0)
                        return NotFound(response);
                    else
                        return Ok(response);
                }
            }
            catch (Exception)
            {
                response.code = HttpStatusCode.Conflict.GetHashCode();
                response.status = HttpStatusCode.BadRequest.ToString();
                return BadRequest(response);
            }
        }

        /// <summary>
        /// Fetches lists of stories filtered by a character id.
        /// </summary>
        /// <param name="characterId"></param>
        /// <returns></returns>
        [HttpGet("{characterId}/stories")]
        public async Task<IActionResult> GetStoriesById(int? characterId)
        {
            ServiceResponse<StoriesResponse> response = new ServiceResponse<StoriesResponse>();
            try
            {
                if (!ModelState.IsValid)
                {
                    return Conflict(ModelState);
                }
                else
                {
                    if (characterId == null)
                        return BadRequest(response);
                    response = await _characterservice.GetStoriesById(characterId);
                    if (response.data.Results.Count == 0)
                        return NotFound(response);
                    else
                        return Ok(response);
                }
            }
            catch (Exception)
            {
                response.code = HttpStatusCode.BadRequest.GetHashCode();
                response.status = HttpStatusCode.BadRequest.ToString();
                return BadRequest(response);
            }
        }
    }
}
