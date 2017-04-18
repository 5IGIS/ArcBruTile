﻿using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using BrutileArcGIS.Lib;
using BrutileArcGIS.MenuDefs;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using log4net;
using log4net.Config;

namespace BrutileArcGIS.Toolbars
{
    [Guid("E74018F6-E70C-44B6-8227-1BCDEF152839")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("BrutileArcGIS.Toolbars.ArcBruTiletoolbar")]
    public sealed class ArcBruTileToolbar : BaseToolbar
    {
        private static readonly ILog Logger = LogManager.GetLogger("ArcBruTileSystemLogger");

        public ArcBruTileToolbar()
        {
            XmlConfigurator.Configure(new FileInfo(Assembly.GetExecutingAssembly().Location + ".config"));

            Logger.Info("Startup ArcBruTile");
            AddItem(typeof(BruTileMenuDef));
            //Status sectie
            BeginGroup();
            BeginGroup();
            AddItem(typeof(OsmMenuDef));
            AddItem(typeof(BingMenuDef));
            AddItem(typeof(StamenMenuDef));
            AddItem(typeof(MapBoxMenuDef));
            AddItem(typeof(CartoDBMenuDef));
            AddItem(typeof(NokiaMenuDef));
            AddItem(typeof(StravaMenuDef));
            AddItem(typeof(TomTomMenuDef));
            AddItem(typeof(YandexMenuDef));
        }

        public override string Caption
        {
            get
            {
                return "ArcBruTile";
            }
        }

        public override string Name
        {
            get
            {
                return "ArcBruTile toolbar";
            }
        }

        #region COM Registration Function(s)
        [ComRegisterFunction()]
        [ComVisible(false)]
        static void RegisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryRegistration(registerType);

            //
            // TODO: Add any COM registration code here
            //
        }

        [ComUnregisterFunction()]
        [ComVisible(false)]
        static void UnregisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryUnregistration(registerType);

            //
            // TODO: Add any COM unregistration code here
            //
        }

        #region ArcGIS Component Category Registrar generated code
        /// <summary>
        /// Required method for ArcGIS Component Category registration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryRegistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            MxCommandBars.Register(regKey);
        }
        /// <summary>
        /// Required method for ArcGIS Component Category unregistration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryUnregistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            MxCommandBars.Unregister(regKey);
        }

        #endregion
        #endregion
    }
}
