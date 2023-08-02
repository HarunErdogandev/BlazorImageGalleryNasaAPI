using İmageGallery.Models;


namespace İmageGallery.Services
{
    public interface INasaService
    {
        Task<NasaApodModel[]> GetNasaApods();
        Task<NasaApodModel> GetNasaApod();

       Task<Collection> GetNASAData();

    }
}
