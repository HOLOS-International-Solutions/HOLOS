﻿using H.Core.Models;
using H.Core.Providers.Animals;
using H.Core.Providers.Feed;
using System;
using System.Collections.ObjectModel;

namespace H.Core.Services
{
    public class FarmHelper
    {
        #region Fields

        private readonly IDietProvider _dietProvider = new DietProvider();
        private readonly Table_6_Manure_Types_Default_Composition_Provider _defaultManureCompositionProvider = new Table_6_Manure_Types_Default_Composition_Provider();
        private readonly Table_30_Default_Bedding_Material_Composition_Provider _defaultBeddingMaterialCompositionProvider = new Table_30_Default_Bedding_Material_Composition_Provider();

        #endregion

        #region Public Methods

        public Farm Create()
        {
            var farm = new Farm();
            farm.Initialize();

            farm.DateModified = DateTime.Now;
            farm.DateCreated = DateTime.Now;

            farm.Diets.AddRange(_dietProvider.GetDiets());
            farm.DefaultManureCompositionData.AddRange(_defaultManureCompositionProvider.ManureCompositionData);
            farm.DefaultsCompositionOfBeddingMaterials.AddRange(_defaultBeddingMaterialCompositionProvider.Data);

            return farm;
        }

        #endregion
    }
}