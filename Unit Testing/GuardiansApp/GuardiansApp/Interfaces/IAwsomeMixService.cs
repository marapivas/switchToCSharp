using GuardiansApp.Models;
using System.Collections.Generic;

namespace GuardiansApp.Interfaces
{
    public interface IAwsomeMixService
    {
        AwsomeMixListResponse GetAllSongs();
        AwsomeMixListResponse Add(string author, string title, string genre, int year, int rating);
        AwsomeMixListResponse Delete(int id);
        Song FindById(int id);
        AwsomeMixListResponse GetFavorite(int number);
        AwsomeMixListResponse GetByAuthor(string author);
        List<int> GetAllIds();
        List<string> GetAllAuthours();
        AwsomeMixListResponse EditRating(int id, int rating);
    }
}
