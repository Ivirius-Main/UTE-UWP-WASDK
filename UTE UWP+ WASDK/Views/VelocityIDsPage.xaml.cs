﻿//using MicaForUWP.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UTE_UWP_.Helpers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UTE_UWP_.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VelocityIDsPage : Page
    {
        public VelocityIDsPage()
        {
            this.InitializeComponent();

            //if (BuildInfo.BeforeWin11)
            //{
            //    if (App.Window.RequestedTheme == ApplicationTheme.Light)
            //    {
            //        Application.Current.Resources["AppTitleBarBrush"] = new BackdropMicaBrush()
            //        {
            //            LuminosityOpacity = 0.8F,
            //            TintOpacity = 0F,
            //            BackgroundSource = BackgroundSource.WallpaperBackdrop,
            //            Opacity = 1,
            //            TintColor = Windows.UI.Color.FromArgb(255, 230, 230, 230),
            //            FallbackColor = Windows.UI.Color.FromArgb(255, 230, 230, 230)
            //        };
            //        this.Background = (Brush)Application.Current.Resources["AppTitleBarBrush"];
            //    }
            //    else
            //    {
            //        Application.Current.Resources["AppTitleBarBrush"] = new BackdropMicaBrush()
            //        {
            //            LuminosityOpacity = 0.8F,
            //            TintOpacity = 0F,
            //            BackgroundSource = BackgroundSource.WallpaperBackdrop,
            //            Opacity = 1,
            //            TintColor = Windows.UI.Color.FromArgb(255, 25, 25, 25),
            //            FallbackColor = Windows.UI.Color.FromArgb(25, 25, 25, 25)
            //        };
            //        this.Background = (Brush)Application.Current.Resources["AppTitleBarBrush"];
            //    }

            //}
            //else
            //{

            //}

            var LocalSettings = ApplicationData.Current.LocalSettings;
            if (LocalSettings.Values["TabbedHideVID"] != null)
            {
                if ((string)LocalSettings.Values["TabbedHideVID"] == "On")
                {
                    tabbedhidevidToggle.IsOn = true;

                }
                if ((string)LocalSettings.Values["TabbedHideVID"] == "Off")
                {
                    tabbedhidevidToggle.IsOn = false;
                }
            }
            else
            {
                LocalSettings.Values["TabbedHideVID"] = "On";
                tabbedhidevidToggle.IsOn = false;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var mainframe = this.Parent as Frame;
            if (mainframe.CanGoBack)
            {
                mainframe.GoBack();
            }
        }

        private void tabbedhidevidToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (tabbedhidevidToggle.IsOn == true)
            {
                var LocalSettings = ApplicationData.Current.LocalSettings;
                if (LocalSettings.Values["TabbedHideVID"] != null)
                {
                    LocalSettings.Values["TabbedHideVID"] = "On";
                }
            }
            else
            {
                var LocalSettings = ApplicationData.Current.LocalSettings;
                if (LocalSettings.Values["TabbedHideVID"] != null)
                {
                    LocalSettings.Values["TabbedHideVID"] = "Off";
                }
            }
        }
    }
}
