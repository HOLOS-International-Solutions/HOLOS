using H.Core.Models;

namespace H.Avalonia.ViewModels.ComponentViews;

public class ComponentTypeToViewTypeMapper
{
    public static string GetViewName(ComponentBase component)
    {
        /*
         * Land Management
         */

        if (component.ComponentType == ComponentType.Field)
        {
            return nameof(FieldComponentView);
        }

        if (component.ComponentType == ComponentType.Rotation)
        {
            return nameof(RotationComponentView);
        }
        if (component.ComponentType == ComponentType.Shelterbelt)
        {
            return nameof(ShelterbeltComponentView);
        }
        
        /*
         * Beef Production
         */

        if (component.ComponentType == ComponentType.CowCalf)
        {
            return nameof(CowCalfComponentView);
        }
        if (component.ComponentType == ComponentType.Backgrounding)
        {
            return nameof(BackgroundingComponentView);
        }
        if (component.ComponentType == ComponentType.Finishing)
        {
            return nameof(FinishingComponentView);
        }

        /*
         * Dairy
         */

         if (component.ComponentType == ComponentType.Dairy) {
            return nameof(DairyComponentView);
         }

        /*
         * Sheep
         */

        if (component.ComponentType == ComponentType.Sheep)
        {
            return nameof(SheepComponentView);
        }

        if (component.ComponentType == ComponentType.SheepFeedlot)
        {
            return nameof(SheepFeedlotComponentView);
        }

        if(component.ComponentType == ComponentType.Rams)
        {
            return nameof(RamsComponentView);
        }
        
        if(component.ComponentType == ComponentType.LambsAndEwes)
        {
            return nameof(LambsAndEwesComponentView);
        }

        /*
         * Other Animals
         */

        if(component.ComponentType == ComponentType.Goats)
        {
            return nameof(GoatsComponentView);
        }

        if (component.ComponentType == ComponentType.Deer)
        {
            return nameof(DeerComponentView);
        }
        
        if (component.ComponentType == ComponentType.Horses)
        {
            return nameof(HorsesComponentView);
        }
        
        if (component.ComponentType == ComponentType.Mules)
        {
            return nameof(MulesComponentView);
        }
        
        if (component.ComponentType == ComponentType.Bison)
        {
            return nameof(BisonComponentView);
        }

        if (component.ComponentType == ComponentType.Llamas)
        {
            return nameof(LlamaComponentView);
        }

        /*
         * Infrastructure
         */

        if (component.ComponentType == ComponentType.AnaerobicDigestion)
        {
            return nameof(AnaerobicDigestionComponentView);
        }

        /*
         * Swine
         */

        if (component.ComponentType == ComponentType.SwineGrowers)
        {
            return nameof(GrowerToFinishComponentView);
        }

        if (component.ComponentType == ComponentType.FarrowToWean)
        {
            return nameof(FarrowToWeanComponentView);
        }

        if (component.ComponentType == ComponentType.IsoWean)
        {
            return nameof(IsoWeanComponentView);
        }

        if (component.ComponentType == ComponentType.FarrowToFinish)
        {
            return nameof(FarrowToFinishComponentView);
        }
        
        return string.Empty;
    }
}