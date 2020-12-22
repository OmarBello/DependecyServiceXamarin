using DependencyServiceXamarin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DependencyServiceXamarin.ViewModels
{
    public class OrientationPageViewModel : INotifyPropertyChanged
    {
        public string orientationText { get; set; }
        public OrientationPageViewModel()
        {
            DeviceOrientation orientation = DependencyService.Get<IDeviceOrientation>().GetOrientation();
            if (orientation.ToString() == "Portrait")
            {
                orientationText = "Portrait";
            }
            else if (orientation.ToString() == "Landscape")
            {
                orientationText = "Landscape";
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
