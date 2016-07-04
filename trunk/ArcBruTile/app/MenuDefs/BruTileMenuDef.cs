﻿using ESRI.ArcGIS.SystemUI;

namespace BrutileArcGIS.MenuDefs
{
    public class BruTileMenuDef : IMenuDef
    {
        public string Caption
        {
            get { return "&ArcBruTile 0.8"; }
        }

        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "AddServicesCommand";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "AddTileLayerCommand";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "AddGisCloudMapCommand";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "VectorTileLayerCommand";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "AboutBruTileCommand";
                    itemDef.Group = true;
                    break;

            }
        }

        public int ItemCount
        {
            get { return 5; }
        }

        public string Name
        {
            get { return "BruTile"; }
        }
    }
}
