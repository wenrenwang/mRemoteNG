﻿namespace mRemoteNG.Themes
{
    using UI.Tabs;
    using WeifenLuo.WinFormsUI.Docking;
    using WeifenLuo.WinFormsUI.ThemeVS2015;


    /// <summary>
    /// Visual Studio 2015 Light theme.
    /// </summary>
    public class MremoteNGThemeBase : VS2015ThemeBase
    {
        public MremoteNGThemeBase(byte[] themeResource)
            : base(themeResource)
        {
            Measures.SplitterSize = 3;
            Measures.AutoHideSplitterSize = 3;
            Measures.DockPadding = 2;
            ShowAutoHideContentOnHover = false;

            Extender.DockPaneStripFactory = new MremoteDockPaneStripFactory();
        }
         
    }

    public  class MremoteDockPaneStripFactory : DockPanelExtender.IDockPaneStripFactory
    {
        public DockPaneStripBase CreateDockPaneStrip(DockPane pane)
        {
            return new DockPaneStripNG(pane);
        }
    }
}