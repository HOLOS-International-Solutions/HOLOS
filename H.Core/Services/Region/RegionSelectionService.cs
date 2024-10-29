using H.Core.Enumerations;
using System;
using System.Linq;

namespace H.Core.Services
{
    public static class RegionSelectionService
    {
        public static RegionNames SelectedRegion { get; set; } = Enum.GetValues(typeof(RegionNames)).Cast<RegionNames>().First();
    }
}