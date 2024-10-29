using System;
using Avalonia.Controls;
using H.Avalonia.ViewModels.SupportingViews.CountrySelection;

namespace H.Avalonia.Views.SupportingViews.CountrySelection
{
    public partial class CountrySelectionView : UserControl
    {
        #region Fields

        private CountrySelectionViewModel _countrySelectionViewModel;

        #endregion

        #region Constructors

        public CountrySelectionView(CountrySelectionViewModel countrySelectionViewModel)
        {
            InitializeComponent();

            if (countrySelectionViewModel != null)
            {
                _countrySelectionViewModel = countrySelectionViewModel;
            }
            else
            {
                throw new ArgumentNullException(nameof(countrySelectionViewModel));
            }
        }

        #endregion
    }
}