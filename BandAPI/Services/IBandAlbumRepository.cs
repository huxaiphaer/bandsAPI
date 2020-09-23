using System;
using System.Collections.Generic;
using BandAPI.Entities;
using BandAPI.Helpers;

namespace BandAPI.Services
{
    public interface IBandAlbumRepository
    {
        IEnumerable<Album> GetAlbums(Guid bandId);
        Album GetAlbum(Guid bandId, Guid albumId);
        void AddAlbum(Guid BandId, Album album);
        void UpdatedAlbum(Album album);
        void DeleteAlbum(Album album);


        IEnumerable<Band> GetBands();
        Band GetBand(Guid band);
        IEnumerable<Band> GetBands(IEnumerable<Guid> bandIds);
        IEnumerable<Band> GetBands(BandsResourceParameters bandsResourceParameters)
            ;
        void AddBand(Band band);
        void UpdatedBand(Band band);
        void DeleteBand(Band band);

        bool BandExists(Guid bandId);
        bool AlbumExists(Guid albumId);
        bool Save();
        

    }
}
