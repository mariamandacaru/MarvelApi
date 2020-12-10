using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MarvelApi.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<CharacterComic> CharacterComics { get; set; }
        public virtual DbSet<CharacterEvent> CharacterEvents { get; set; }
        public virtual DbSet<CharacterSeries> CharacterSeries { get; set; }
        public virtual DbSet<CharacterStory> CharacterStories { get; set; }
        public virtual DbSet<CharacterUrl> CharacterUrls { get; set; }
        public virtual DbSet<CollectedIssue> CollectedIssues { get; set; }
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Comic> Comics { get; set; }
        public virtual DbSet<ComicsCharacter> ComicsCharacters { get; set; }
        public virtual DbSet<ComicsCollectedIssue> ComicsCollectedIssues { get; set; }
        public virtual DbSet<ComicsCollection> ComicsCollections { get; set; }
        public virtual DbSet<ComicsCreator> ComicsCreators { get; set; }
        public virtual DbSet<ComicsDate> ComicsDates { get; set; }
        public virtual DbSet<ComicsEvent> ComicsEvents { get; set; }
        public virtual DbSet<ComicsImage> ComicsImages { get; set; }
        public virtual DbSet<ComicsPrice> ComicsPrices { get; set; }
        public virtual DbSet<ComicsSeries> ComicsSeries { get; set; }
        public virtual DbSet<ComicsStory> ComicsStories { get; set; }
        public virtual DbSet<ComicsTextObject> ComicsTextObjects { get; set; }
        public virtual DbSet<ComicsUrl> ComicsUrls { get; set; }
        public virtual DbSet<ComicsVariant> ComicsVariants { get; set; }
        public virtual DbSet<Creator> Creators { get; set; }
        public virtual DbSet<Date> Dates { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventsCharacter> EventsCharacters { get; set; }
        public virtual DbSet<EventsComic> EventsComics { get; set; }
        public virtual DbSet<EventsCreator> EventsCreators { get; set; }
        public virtual DbSet<EventsSeries> EventsSeries { get; set; }
        public virtual DbSet<EventsStory> EventsStories { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<SeriesCharacter> SeriesCharacters { get; set; }
        public virtual DbSet<SeriesComic> SeriesComics { get; set; }
        public virtual DbSet<SeriesCreator> SeriesCreators { get; set; }
        public virtual DbSet<SeriesEvent> SeriesEvents { get; set; }
        public virtual DbSet<SeriesStory> SeriesStories { get; set; }
        public virtual DbSet<SeriesUrl> SeriesUrls { get; set; }
        public virtual DbSet<StoriesCharacter> StoriesCharacters { get; set; }
        public virtual DbSet<StoriesComic> StoriesComics { get; set; }
        public virtual DbSet<StoriesCreator> StoriesCreators { get; set; }
        public virtual DbSet<StoriesEvent> StoriesEvents { get; set; }
        public virtual DbSet<StoriesSeries> StoriesSeries { get; set; }
        public virtual DbSet<Story> Stories { get; set; }
        public virtual DbSet<TextObject> TextObjects { get; set; }
        public virtual DbSet<Thumbnail> Thumbnails { get; set; }
        public virtual DbSet<Url> Urls { get; set; }
        public virtual DbSet<Variant> Variants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>(entity =>
            {
                entity.ToTable("Character");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Idthumbnail).HasColumnName("idthumbnail");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");

                entity.HasOne(d => d.IdthumbnailNavigation)
                    .WithMany(p => p.Characters)
                    .HasForeignKey(d => d.Idthumbnail)
                    .HasConstraintName("fk_character_thumbnail");
            });

            modelBuilder.Entity<CharacterComic>(entity =>
            {

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdComics).HasColumnName("idComics");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_CharacterComicscharacter");

                entity.HasOne(d => d.IdComicsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComics)
                    .HasConstraintName("fk_CharacterComics");
            });

            modelBuilder.Entity<CharacterEvent>(entity =>
            {

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_CharacterEventscharacter");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_CharacterEvents");
            });

            modelBuilder.Entity<CharacterSeries>(entity =>
            {

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_CharacterSeriescharacter");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_CharacterSeries");
            });

            modelBuilder.Entity<CharacterStory>(entity =>
            {

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_CharacterStoriescharacter");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_CharacterStories");
            });

            modelBuilder.Entity<CharacterUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CharacterUrl");

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdUrl).HasColumnName("idURL");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_CharacterUrlcharacter");

                entity.HasOne(d => d.IdUrlNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUrl)
                    .HasConstraintName("fk_CharacterUrl");
            });

            modelBuilder.Entity<CollectedIssue>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");
            });

            modelBuilder.Entity<Collection>(entity =>
            {
                entity.ToTable("Collection");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");
            });

            modelBuilder.Entity<Comic>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.DiamondCode)
                    .IsUnicode(false)
                    .HasColumnName("diamondCode");

                entity.Property(e => e.DigitalId).HasColumnName("digitalId");

                entity.Property(e => e.Ean)
                    .IsUnicode(false)
                    .HasColumnName("ean");

                entity.Property(e => e.Format)
                    .IsUnicode(false)
                    .HasColumnName("format");

                entity.Property(e => e.Idthumbnail).HasColumnName("idthumbnail");

                entity.Property(e => e.Isbn)
                    .IsUnicode(false)
                    .HasColumnName("isbn");

                entity.Property(e => e.Issn)
                    .IsUnicode(false)
                    .HasColumnName("issn");

                entity.Property(e => e.IssueNumber)
                    .IsUnicode(false)
                    .HasColumnName("issueNumber");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.PageCount)
                    .IsUnicode(false)
                    .HasColumnName("pageCount");

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");

                entity.Property(e => e.Title)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Upc)
                    .IsUnicode(false)
                    .HasColumnName("upc");

                entity.Property(e => e.VariantDescription)
                    .IsUnicode(false)
                    .HasColumnName("variantDescription");

                entity.HasOne(d => d.IdthumbnailNavigation)
                    .WithMany(p => p.Comics)
                    .HasForeignKey(d => d.Idthumbnail)
                    .HasConstraintName("fk_Comics_Thumbnail");
            });

            modelBuilder.Entity<ComicsCharacter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComicsCharacter");

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_ComicsCharacter");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsCharacterComics");
            });

            modelBuilder.Entity<ComicsCollectedIssue>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdCollectedIssues).HasColumnName("idCollectedIssues");

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.HasOne(d => d.IdCollectedIssuesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCollectedIssues)
                    .HasConstraintName("fk_ComicsCollectedIssues");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsCollectedIssuesComics");
            });

            modelBuilder.Entity<ComicsCollection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComicsCollection");

                entity.Property(e => e.IdCollection).HasColumnName("idCollection");

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.HasOne(d => d.IdCollectionNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCollection)
                    .HasConstraintName("fk_ComicsCollection");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsCollectionComics");
            });

            modelBuilder.Entity<ComicsCreator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComicsCreator");

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdCreator).HasColumnName("idCreator");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsCreatorComics");

                entity.HasOne(d => d.IdCreatorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCreator)
                    .HasConstraintName("fk_ComicsCreator");
            });

            modelBuilder.Entity<ComicsDate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdDates).HasColumnName("idDates");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsDatesComics");

                entity.HasOne(d => d.IdDatesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdDates)
                    .HasConstraintName("fk_ComicsDates");
            });

            modelBuilder.Entity<ComicsEvent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsEventsComics");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_ComicsEvents");
            });

            modelBuilder.Entity<ComicsImage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdImages).HasColumnName("idImages");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsImagesComics");

                entity.HasOne(d => d.IdImagesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdImages)
                    .HasConstraintName("fk_ComicsImages");
            });

            modelBuilder.Entity<ComicsPrice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdPrices).HasColumnName("idPrices");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsPricesComics");

                entity.HasOne(d => d.IdPricesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPrices)
                    .HasConstraintName("fk_ComicsPrices");
            });

            modelBuilder.Entity<ComicsSeries>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsSeriesComics");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_ComicsSeries");
            });

            modelBuilder.Entity<ComicsStory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsStoriesComics");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_ComicsStories");
            });

            modelBuilder.Entity<ComicsTextObject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComicsTextObject");

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdTextObject).HasColumnName("idTextObject");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsTextObjectComics");

                entity.HasOne(d => d.IdTextObjectNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTextObject)
                    .HasConstraintName("fk_ComicsTextObject");
            });

            modelBuilder.Entity<ComicsUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComicsUrl");

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdUrl).HasColumnName("idURL");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsUrlComics");

                entity.HasOne(d => d.IdUrlNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUrl)
                    .HasConstraintName("fk_ComicsUrl");
            });

            modelBuilder.Entity<ComicsVariant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComicsVariant");

                entity.Property(e => e.IdComic).HasColumnName("idComic");

                entity.Property(e => e.IdVariant).HasColumnName("idVariant");

                entity.HasOne(d => d.IdComicNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComic)
                    .HasConstraintName("fk_ComicsVariantComics");

                entity.HasOne(d => d.IdVariantNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVariant)
                    .HasConstraintName("fk_ComicsVariant");
            });

            modelBuilder.Entity<Creator>(entity =>
            {
                entity.ToTable("Creator");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");

                entity.Property(e => e.Role)
                    .IsUnicode(false)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Date>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date1)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.Idthumbnail).HasColumnName("idthumbnail");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("startDate");

                entity.Property(e => e.Title)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.HasOne(d => d.IdthumbnailNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.Idthumbnail)
                    .HasConstraintName("fk_Events_Thumbnail");
            });

            modelBuilder.Entity<EventsCharacter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EventsCharacter");

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_EventsCharacter");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_EventsCharacterEvents");
            });

            modelBuilder.Entity<EventsComic>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComics).HasColumnName("idComics");

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.HasOne(d => d.IdComicsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComics)
                    .HasConstraintName("fk_EventsComics");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_EventsComicsEvents");
            });

            modelBuilder.Entity<EventsCreator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EventsCreator");

                entity.Property(e => e.IdCreator).HasColumnName("idCreator");

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.HasOne(d => d.IdCreatorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCreator)
                    .HasConstraintName("fk_EventsCreator");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_EventsCreatorEvents");
            });

            modelBuilder.Entity<EventsSeries>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_EventsSeriesEvents");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_EventsSeries");
            });

            modelBuilder.Entity<EventsStory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_EventsStoriesEvents");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_EventsStories");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsUnicode(false)
                    .HasColumnName("extension");

                entity.Property(e => e.Path)
                    .IsUnicode(false)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.EndYear).HasColumnName("endYear");

                entity.Property(e => e.Idthumbnail).HasColumnName("idthumbnail");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.Rating)
                    .IsUnicode(false)
                    .HasColumnName("rating");

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");

                entity.Property(e => e.StartYear).HasColumnName("startYear");

                entity.Property(e => e.Title)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.IdthumbnailNavigation)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.Idthumbnail)
                    .HasConstraintName("fk_Series_Thumbnail");
            });

            modelBuilder.Entity<SeriesCharacter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SeriesCharacter");

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_SeriesCharacter");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_SeriesCharacterSeries");
            });

            modelBuilder.Entity<SeriesComic>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComics).HasColumnName("idComics");

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.HasOne(d => d.IdComicsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComics)
                    .HasConstraintName("fk_SeriesComics");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_SeriesComicsSeries");
            });

            modelBuilder.Entity<SeriesCreator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SeriesCreator");

                entity.Property(e => e.IdCreator).HasColumnName("idCreator");

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.HasOne(d => d.IdCreatorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCreator)
                    .HasConstraintName("fk_SeriesCreator");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_SeriesCreatorSeries");
            });

            modelBuilder.Entity<SeriesEvent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_SeriesEvents");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_SeriesEventsSeries");
            });

            modelBuilder.Entity<SeriesStory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_SeriesStoriesSeries");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_SeriesStories");
            });

            modelBuilder.Entity<SeriesUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SeriesUrl");

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.Property(e => e.IdUrl).HasColumnName("idURL");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_SeriesUrlSeries");

                entity.HasOne(d => d.IdUrlNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUrl)
                    .HasConstraintName("fk_SeriesUrl");
            });

            modelBuilder.Entity<StoriesCharacter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StoriesCharacter");

                entity.Property(e => e.IdCharacter).HasColumnName("idCharacter");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdCharacterNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCharacter)
                    .HasConstraintName("fk_StoriesCharacter");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_StoriesCharacterStories");
            });

            modelBuilder.Entity<StoriesComic>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdComics).HasColumnName("idComics");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdComicsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComics)
                    .HasConstraintName("fk_StoriesComics");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_StoriesComicsStories");
            });

            modelBuilder.Entity<StoriesCreator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StoriesCreator");

                entity.Property(e => e.IdCreator).HasColumnName("idCreator");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdCreatorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCreator)
                    .HasConstraintName("fk_StoriesCreator");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_StoriesCreatorStories");
            });

            modelBuilder.Entity<StoriesEvent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdEvents).HasColumnName("idEvents");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdEventsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEvents)
                    .HasConstraintName("fk_StoriesEvents");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_StoriesEventsStories");
            });

            modelBuilder.Entity<StoriesSeries>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdSeries).HasColumnName("idSeries");

                entity.Property(e => e.IdStories).HasColumnName("idStories");

                entity.HasOne(d => d.IdSeriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSeries)
                    .HasConstraintName("fk_StoriesSeries");

                entity.HasOne(d => d.IdStoriesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStories)
                    .HasConstraintName("fk_StoriesSeriesStories");
            });

            modelBuilder.Entity<Story>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Idthumbnail).HasColumnName("idthumbnail");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");

                entity.Property(e => e.Title)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.HasOne(d => d.IdthumbnailNavigation)
                    .WithMany(p => p.Stories)
                    .HasForeignKey(d => d.Idthumbnail)
                    .HasConstraintName("fk_Stories_Thumbnail");
            });

            modelBuilder.Entity<TextObject>(entity =>
            {
                entity.ToTable("TextObject");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Language)
                    .IsUnicode(false)
                    .HasColumnName("language");

                entity.Property(e => e.Text)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Thumbnail>(entity =>
            {
                entity.ToTable("Thumbnail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsUnicode(false)
                    .HasColumnName("extension");

                entity.Property(e => e.Path)
                    .IsUnicode(false)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<Url>(entity =>
            {
                entity.ToTable("Url");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.Url1)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<Variant>(entity =>
            {
                entity.ToTable("Variant");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ResourceUri)
                    .IsUnicode(false)
                    .HasColumnName("resourceURI");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
