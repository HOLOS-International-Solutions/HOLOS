using System;
using Avalonia.Controls;
using H.Avalonia.ViewModels.SupportingViews.MeasurementProvince;

namespace H.Avalonia.Views.SupportingViews.MeasurementProvince
{
    public partial class MeasurementProvinceView : UserControl
    {
        #region Fields

        private MeasurementProvinceViewModel _measurementProvinceViewModel;

        #endregion

        #region Constructors

        public MeasurementProvinceView(MeasurementProvinceViewModel measurementProvinceViewModel)
        {
            InitializeComponent();

            if (measurementProvinceViewModel != null)
            {
                _measurementProvinceViewModel = measurementProvinceViewModel;
            }
            else
            {
                throw new ArgumentNullException(nameof(measurementProvinceViewModel));
            }
        }

        #endregion
    }
}