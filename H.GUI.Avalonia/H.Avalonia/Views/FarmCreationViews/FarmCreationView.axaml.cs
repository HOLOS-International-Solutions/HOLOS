using Avalonia.Controls;
using H.Avalonia.ViewModels;
using System;

namespace H.Avalonia.Views.FarmCreationViews
{
    public partial class FarmCreationView : UserControl
    {

        #region Fields

        private FarmCreationViewModel _farmCreationViewModel;

        #endregion

        #region Constructors


        public FarmCreationView(FarmCreationViewModel farmCreationViewModel)
        {
            InitializeComponent();
            if (farmCreationViewModel != null)
            {
                _farmCreationViewModel = farmCreationViewModel;
            }
            else
            {
                throw new ArgumentNullException(nameof(farmCreationViewModel));
            }

        }
        #endregion
    }
}