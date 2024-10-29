using Splat;
using System.Configuration;
using H.Core.Enumerations;

namespace H.Core.Helpers
{
    public class ConfigurationFileHelper
    {
        #region Fields

        #endregion

        #region Public Methods

        /// <summary>
        /// Reads application settings file to see if a boolean value has been set
        /// </summary>
        /// <param name="settingName">The name of the setting to check</param>
        /// <returns><c>true</c> if the setting exists and is enabled, <c>false</c> if the setting does not exist or is not enabled</returns>
        public static bool BooleanAppSettingIsEnabled(string settingName)
        {
            var result = false;

            try
            {
                ConfigurationManager.RefreshSection("appSettings");

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings.AllKeys.Contains(settingName))
                {
                    var setting = config.AppSettings.Settings[settingName].Value;
                    result = setting.Equals("true", StringComparison.InvariantCultureIgnoreCase) || setting.Equals("t", StringComparison.InvariantCultureIgnoreCase) || setting.Equals("1", StringComparison.InvariantCultureIgnoreCase);
                }
            }
            catch (Exception e)
            {
            }

            return result;
        }

        /// <summary>
        /// Returns the system version being used. This is not the same as the version number
        /// </summary>
        /// <returns>A value from the <see cref="CountryVersion"/> indicating which system version is enabled</returns>
        public static CountryVersion GetCountryVersion()
        {
            CountryVersion countryVersion = CountryVersion.Canada;
            const string settingName = "CountryVersion";

            try
            {
                ConfigurationManager.RefreshSection("appSettings");

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings.AllKeys.Contains(settingName))
                {
                    var setting = config.AppSettings.Settings[settingName].Value;
                    if (setting.Equals("ireland", StringComparison.InvariantCultureIgnoreCase))
                    {
                        countryVersion = CountryVersion.Ireland;
                    }
                }
            }
            catch (Exception e)
            {
            }

            return countryVersion;
        }

        /// <summary>
        /// Updates the CountryVersion setting in the App.config file.
        /// </summary>
        /// <param name="countryVersion">The country version to set.</param>
        public static void UpdateCountryVersion(string countryVersion)
        {
            try
            {
                ConfigurationManager.RefreshSection("appSettings");

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings.AllKeys.Contains("CountryVersion"))
                {
                    config.AppSettings.Settings["CountryVersion"].Value = countryVersion;
                }
                else
                {
                    config.AppSettings.Settings.Add("CountryVersion", countryVersion);
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception e)
            {
                // Handle exceptions as needed
            }
        }

        #endregion
    }
}