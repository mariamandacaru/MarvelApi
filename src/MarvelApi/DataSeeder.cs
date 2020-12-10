using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public static class DataSeeder
    {
        public static void SeedData(DataContext context)
        {
            Character character1 = new Character() { Id = 1011334, Name = "3-D Man", Description = "3-D Man", Modified = new DateTime(2014, 4, 29), ResourceUri = "", Idthumbnail = null };
            Character character2 = new Character() { Id = 1017100, Name = "A-Bomb (HAS)", Description = "Hulk's best bud", Modified = new DateTime(2013, 4, 29), ResourceUri = "", Idthumbnail = null };
            List<Character> characters = new List<Character>() {character1, character2 };

            Comic comic1 = new Comic() { Id = 22506, DigitalId = 10949, Title = "Avengers: The Initiative (2007) #19", ResourceUri = "", Description = "Avengers" };
            Comic comic2 = new Comic() { Id = 40628, DigitalId = 27099, Title = "Hulk (2008) #55", ResourceUri = "",Description = "Hulk" };

            List<Comic> comics = new List<Comic>() {comic1, comic2 };

            List<CharacterComic> characterComics  = new List<CharacterComic>() {
                new CharacterComic() {IdCharacter = 1011334, IdComics = 22506, IdCharacterNavigation = character1, IdComicsNavigation = comic1},
                new CharacterComic() {IdCharacter = 1017100, IdComics = 40628, IdCharacterNavigation = character2, IdComicsNavigation = comic2}
            };

            Series series1 = new Series() { Id = 1945, Title = "Avengers: The Initiative (2007 - 2010)", ResourceUri = "", Description = "Avengers" };
            Series series2 = new Series() { Id = 17765, Title = "FREE COMIC BOOK DAY 2013 1 (2013)", ResourceUri = "",Description= "FREE" };

            List<Series> series = new List<Series>() { series1,series2 };

            List<CharacterSeries> characterSeries = new List<CharacterSeries>() {
                new CharacterSeries() {IdCharacter = 1011334, IdSeries = 1945,IdCharacterNavigation =character1,IdSeriesNavigation =series1},
                new CharacterSeries() {IdCharacter = 1017100, IdSeries = 17765,IdCharacterNavigation =character2,IdSeriesNavigation =series2}
            };

            Story story1 = new Story() { Id = 1945, Title = "Cover #19947", ResourceUri = "", Description = "Cover" };
            Story story2 = new Story() { Id = 92078, Title = "Hulk (2008) #55", ResourceUri = "",Description = "Hulk" };

            List<Story> stories = new List<Story>() {story1,story2};

            List<CharacterStory> characterStories = new List<CharacterStory>() {
                new CharacterStory() {IdCharacter = 1011334, IdStories = 1945,IdCharacterNavigation = character1,IdStoriesNavigation = story1 },
                new CharacterStory() {IdCharacter = 1017100, IdStories = 92078,IdCharacterNavigation = character2,IdStoriesNavigation = story2 }
            };

            Event event1 = new Event() { Id = 269, Title = "Secret Invasion", ResourceUri = "", Description = "Secret" };
            Event event2 = new Event() { Id = 1009146, Title = "Abomination (Emil Blonsky)", ResourceUri = "",Description = "Abomination" };

            List<Event> events = new List<Event>() {event1,event2 };

            List<CharacterEvent> characterEvents = new List<CharacterEvent>() {
                new CharacterEvent() {IdCharacter = 1011334, IdEvents = 269,IdCharacterNavigation = character1, IdEventsNavigation = event1 },
                new CharacterEvent() {IdCharacter = 1017100, IdEvents = 1009146,IdCharacterNavigation = character2, IdEventsNavigation = event2 }
            };

            context.Characters.AddRange(characters);
            context.Comics.AddRange(comics);
            context.CharacterComics.AddRange(characterComics);
            context.Series.AddRange(series);
            context.CharacterSeries.AddRange(characterSeries);
            context.Stories.AddRange(stories);
            context.CharacterStories.AddRange(characterStories);
            context.Events.AddRange(events);
            context.CharacterEvents.AddRange(characterEvents);

            context.SaveChanges();
        }
    }
}
