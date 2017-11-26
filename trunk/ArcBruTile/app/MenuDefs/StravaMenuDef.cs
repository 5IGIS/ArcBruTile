﻿using BrutileArcGIS.commands;
using ESRI.ArcGIS.ADF.BaseClasses;

namespace BrutileArcGIS.MenuDefs
{
    public class StravaMenuDef : BaseMenu
    {
        public StravaMenuDef()
        {
            m_barCaption = "&Strava";
            // AddItem(typeof(AddStravaBothLayerCommand));
            AddItem(typeof(AddStrava2017LayerCommand));
            //AddItem(typeof(AddStravaCyclingLayerCommand));
            //AddItem(typeof(AddStravaRunningLayerCommand));
            //AddItem(typeof(AddStravaRideLayerCommand));
        }
    }
}
