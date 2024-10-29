using H.Avalonia.Views;
using H.Avalonia.Views.SupportingViews.CountrySelection;
using H.Core.Enumerations;
using H.Core.Enumerations.LocationEnumerationsCountries;
using H.Core.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace H.Avalonia.ViewModels.SupportingViews.RegionSelection
{
    public class RegionSelectionViewModel : ViewModelBase
    {
        #region Fields

        private RegionNames _selectedRegion;
        private readonly IRegionManager _regionManager;

        #endregion

        #region Constructors

        public RegionSelectionViewModel(IRegionManager regionManager) : base(regionManager)
        {
            _regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));

            RegionCollection = new ObservableCollection<RegionNames>(Enum.GetValues(typeof(RegionNames)).Cast<RegionNames>());

            // Set default selected region to the first one or a default value
            // _selectedRegion = RegionCollection.FirstOrDefault() ?? RegionNames.SelectRegion;
            SelectedRegion = _selectedRegion;

            NavigateCommand = new DelegateCommand(OnNavigate);
        }

        #endregion

        #region Properties

        public ObservableCollection<RegionNames> RegionCollection { get; set; }

        public RegionNames SelectedRegion
        {
            get { return _selectedRegion; }
            set { SetProperty(ref _selectedRegion, value); }
        }

        public ICommand NavigateCommand { get; }

        #endregion

        #region Methods

        private void OnNavigate()
        {
            // Store the selected region in the service
            RegionSelectionService.SelectedRegion = SelectedRegion;

            // Navigate to CountrySelectionView
            _regionManager.RequestNavigate(UiRegions.ContentRegion, nameof(CountrySelectionView));
        }

        #endregion
    }
}