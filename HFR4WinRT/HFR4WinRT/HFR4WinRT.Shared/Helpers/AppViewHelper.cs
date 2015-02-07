﻿using System.Linq;
using System.Reflection;
using Windows.UI;

namespace HFR4WinRT.Helpers
{
    public static class AppViewHelper
    {
        private static dynamic titleBar;

        public static void SetAppView()
        {
            var v = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            var allProperties = v.GetType().GetRuntimeProperties();
            titleBar = allProperties.FirstOrDefault(x => x.Name == "TitleBar");
            if (titleBar == null) return;
            dynamic bb = titleBar.GetMethod.Invoke(v, null);
            bb.ExtendViewIntoTitleBar = true;
        }

        public static void SetBackgroundButtonColor()
        {
            var v = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            var allProperties = v.GetType().GetRuntimeProperties();
            titleBar = allProperties.FirstOrDefault(x => x.Name == "TitleBar");
            if (titleBar == null) return;
            dynamic bb = titleBar.GetMethod.Invoke(v, null);
            bb.ButtonBackgroundColor = Colors.White;

        }
    }
}