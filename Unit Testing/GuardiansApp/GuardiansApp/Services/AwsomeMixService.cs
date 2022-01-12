using GuardiansApp.Database;
using GuardiansApp.Interfaces;
using GuardiansApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace GuardiansApp.Services
{
    public class AwsomeMixService : IAwsomeMixService
    {
        private ApplicationDbContext DbContext { get; set; }

        public AwsomeMixService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public AwsomeMixListResponse GetAllSongs()
        {
            AwsomeMixListResponse mix = new AwsomeMixListResponse()
            {
                Songs = DbContext.Songs.ToList()
            };
            return mix;
        }

        public AwsomeMixListResponse Add(string author, string title, string genre, int year, int rating)
        {
            Song song = new Song();
            song.Author = author;
            song.Title = title;
            song.Genre = genre;
            song.Year = year;
            song.Rating = rating;
            DbContext.Songs.Add(song);
            DbContext.SaveChanges();

            return GetAllSongs();
        }

        public AwsomeMixListResponse Delete(int id)
        {
            DbContext.Songs.Remove(DbContext.Songs.Where(s => s.Id == id).First());
            DbContext.SaveChanges();

            return GetAllSongs();
        }

        public AwsomeMixListResponse EditRating(int id, int rating)
        {
            Song editSong = FindById(id);
            editSong.Rating = rating;

            return GetAllSongs();
        }

        public Song FindById(int id)
        {
            return DbContext.Songs.Where(s => s.Id == id).First();
        }

        public AwsomeMixListResponse GetFavorite(int number)
        {
            var mix = DbContext.Songs.ToList().OrderByDescending(s => s.Rating);
            var fav = mix.Take(number).ToList();

            AwsomeMixListResponse favorite = new AwsomeMixListResponse()
            {
                Songs = fav
            };
            return favorite;
        }

        public AwsomeMixListResponse GetByAuthor(string author)
        {
            var mix = DbContext.Songs.Where(s => s.Author.Contains(author)).ToList();

            AwsomeMixListResponse authorSongs = new AwsomeMixListResponse()
            {
                Songs = mix
            };
            return authorSongs;
        }

        public List<int> GetAllIds()
        {
            return DbContext.Songs.Select(x => x.Id).ToList();
        }

        public List<string> GetAllAuthours()
        {
           return DbContext.Songs.Select(x => x.Author).ToList();
        }
    }
}
