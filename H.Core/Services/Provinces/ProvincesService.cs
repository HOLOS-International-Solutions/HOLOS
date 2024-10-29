using H.Core.Enumerations;
using H.Core.Enumerations.LocationEnumerationsProvinces;
using H.Core.Helpers;
using H.Core.Services.Provinces;


namespace H.Core.Services
{
    public class ProvincesService : IProvinces
    {
        public IEnumerable<object> GetProvinces()
        {
            var countryVersion = ConfigurationFileHelper.GetCountryVersion();

            if (countryVersion == CountryVersion.Ireland)
            {
                return Enum.GetValues(typeof(ProvinceIreland)).Cast<object>();
            }
            else if (countryVersion == CountryVersion.Canada)
            {
                return Enum.GetValues(typeof(ProvinceCanada)).Cast<object>();
            }

            return Enumerable.Empty<object>();
        }
    }
}