using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DependencyServiceXamarin.Services;
using Foundation;
using UIKit;
using Xamarin.Forms.Internals;

[assembly: Xamarin.Forms.Dependency(typeof(DependencyServiceXamarin.iOS.Services.DeviceOrientationServiceIOS))]
namespace DependencyServiceXamarin.iOS.Services
{
    public class DeviceOrientationServiceIOS : IDeviceOrientation
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}