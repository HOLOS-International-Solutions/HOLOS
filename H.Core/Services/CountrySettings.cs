﻿using H.Core.Enumerations;
using H.Core.Helpers;

namespace H.Core.Services;

public class CountrySettings : ICountrySettings
{
    #region Constructors

    public CountrySettings()
    {
        this.Version = ConfigurationFileHelper.GetCountryVersion();
    }

    #endregion

	#region Properties

	public CountryVersion Version { get; set; } 

	#endregion
}