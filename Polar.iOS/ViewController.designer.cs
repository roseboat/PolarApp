// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Polar.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GetNewsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView HomeImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HomeTitle { get; set; }

        [Outlet]
        UIKit.UIPickerView NewsPicker { get; set; }

        [Action ("GetNewsButton_TouchUpInside:")]
        partial void GetNewsButton_TouchUpInside (UIKit.UIButton sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (GetNewsButton != null) {
                GetNewsButton.Dispose ();
                GetNewsButton = null;
            }

            if (HomeImage != null) {
                HomeImage.Dispose ();
                HomeImage = null;
            }

            if (HomeTitle != null) {
                HomeTitle.Dispose ();
                HomeTitle = null;
            }

            if (NewsPicker != null) {
                NewsPicker.Dispose ();
                NewsPicker = null;
            }
        }
    }
}
