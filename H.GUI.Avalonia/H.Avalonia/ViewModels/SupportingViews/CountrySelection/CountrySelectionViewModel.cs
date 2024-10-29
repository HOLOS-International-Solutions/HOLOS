using H.Avalonia.Views.SupportingViews.MeasurementProvince;
using H.Core.Helpers; 
using H.Core.Services.RegionCountries;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace H.Avalonia.ViewModels.SupportingViews.CountrySelection
{
    public class CountrySelectionViewModel : ViewModelBase
    {
        #region Fields

        private object _selectedCountry;
        private readonly IRegionManager _regionManager;
        private readonly ICountries _countriesService;

        #endregion

        #region Constructors

        public CountrySelectionViewModel(IRegionManager regionManager, ICountries countriesService)
        {
            _regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));
            _countriesService = countriesService ?? throw new ArgumentNullException(nameof(countriesService));

            CountryCollection = new ObservableCollection<object>(_countriesService.GetCountries());

            // Set default selected country to the first one or a default value
            _selectedCountry = CountryCollection.FirstOrDefault() ?? new object();
            SelectedCountry = _selectedCountry;

            NavigateCommand = new DelegateCommand(OnNavigate);
        }

        #endregion

        #region Properties

        public ObservableCollection<object> CountryCollection { get; set; }

        public object SelectedCountry
        {
            get { return _selectedCountry; }
            set { SetProperty(ref _selectedCountry, value); }
        }

        public ICommand NavigateCommand { get; }

        #endregion

        #region Methods

        private void OnNavigate()
        {
            // Update the App.config with the selected country if it's not null
            if (SelectedCountry != null)
            {
                ConfigurationFileHelper.UpdateCountryVersion(SelectedCountry.ToString());
            }

            // Navigate to MeasurementProvinceView
            _regionManager.RequestNavigate(UiRegions.ContentRegion, nameof(MeasurementProvinceView));
        }

        #endregion
    }
}