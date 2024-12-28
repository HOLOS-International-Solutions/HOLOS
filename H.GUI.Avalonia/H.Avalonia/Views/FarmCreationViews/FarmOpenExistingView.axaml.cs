using Avalonia.Controls;
using H.Avalonia.ViewModels;
using System;


namespace H.Avalonia.Views.FarmCreationViews;

public partial class FarmOpenExistingView : UserControl
{

    #region Fields

    private FarmOpenExistingViewmodel _farmOpenExistingViewmodel;

    #endregion
    

    #region Constructors
    public FarmOpenExistingView(FarmOpenExistingViewmodel farmOpenExistingViewmodel)
    {
        InitializeComponent();
        if (farmOpenExistingViewmodel != null)
        {
            _farmOpenExistingViewmodel = farmOpenExistingViewmodel;
        }
        else
        {
            throw new ArgumentNullException(nameof(farmOpenExistingViewmodel));
        }
    }
    #endregion
}