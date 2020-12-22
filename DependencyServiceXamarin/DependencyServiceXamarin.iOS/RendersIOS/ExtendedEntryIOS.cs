using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DependencyServiceXamarin.iOS.RendersIOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryRenderer), typeof(ExtendedEntryIOS))]
namespace DependencyServiceXamarin.iOS.RendersIOS
{
    public class ExtendedEntryIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(0, 122, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
        public ExtendedEntryIOS()
        {

        }
    }
}