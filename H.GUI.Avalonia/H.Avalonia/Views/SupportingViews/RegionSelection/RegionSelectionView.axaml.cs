using System;
using Avalonia.Controls;
using H.Avalonia.ViewModels.SupportingViews.RegionSelection;

namespace H.Avalonia.Views.SupportingViews.RegionSelection
{
    public partial class RegionSelectionView : UserControl
    {
        #region Fields

        private RegionSelectionViewModel _regionSelectionViewModel;

        #endregion

        #region Constructors

        public RegionSelectionView(RegionSelectionViewModel regionSelectionViewModel)
        {
            InitializeComponent();

            if (regionSelectionViewModel != null)
            {
                _regionSelectionViewModel = regionSelectionViewModel;
                DataContext = _regionSelectionViewModel;
            }
            else
            {
                throw new ArgumentNullException(nameof(regionSelectionViewModel));
            }
        }

        #endregion
    }
}