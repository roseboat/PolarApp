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
	[Register ("NewsCollectionViewCell")]
	partial class NewsCollectionViewCell
	{
		[Outlet]
		UIKit.UILabel DateText { get; set; }

		[Outlet]
		UIKit.UILabel HeadlineText { get; set; }

		[Outlet]
		UIKit.UIImageView NewsImage { get; set; }

		[Outlet]
		UIKit.UILabel PreambleText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NewsImage != null) {
				NewsImage.Dispose ();
				NewsImage = null;
			}

			if (DateText != null) {
				DateText.Dispose ();
				DateText = null;
			}

			if (HeadlineText != null) {
				HeadlineText.Dispose ();
				HeadlineText = null;
			}

			if (PreambleText != null) {
				PreambleText.Dispose ();
				PreambleText = null;
			}
		}
	}
}
