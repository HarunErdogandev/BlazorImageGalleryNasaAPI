using İmageGallery.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace İmageGallery.Services
{
    public class NasaManager : INasaService
    {

        private HttpClient _httpClient;

        public NasaManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<NasaApodModel> GetNasaApod()
        {
            if (true)
            {

            }
            return _httpClient.GetFromJsonAsync<NasaApodModel>
                ("https://api.nasa.gov/planetary/apod?api_key=eeEM1odASI77SG1NqBabojaxzarihRddSctaUcFg");
            
        }

        public Task<NasaApodModel[]> GetNasaApods()
        {
           
            
            return _httpClient.GetFromJsonAsync<NasaApodModel[]>
                ("https://api.nasa.gov/planetary/apod?api_key=eeEM1odASI77SG1NqBabojaxzarihRddSctaUcFg");
        }

        public Task<Collection> GetNASAData()
        {
            try
            {
                
                var Result= _httpClient.GetFromJsonAsync<Collection>("https://images-api.nasa.gov/search?media_type=image");
                if (Result is not null)
                {
                    //buraya giricek
                }
                return Result;
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
