// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Xamarin
{
    [Register ("SessionsTableViewCell")]
    partial class SessionsTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel sessionTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (dateLabel != null) {
                dateLabel.Dispose ();
                dateLabel = null;
            }

            if (desLabel != null) {
                desLabel.Dispose ();
                desLabel = null;
            }

            if (sessionTitle != null) {
                sessionTitle.Dispose ();
                sessionTitle = null;
            }

            if (speakerLabel != null) {
                speakerLabel.Dispose ();
                speakerLabel = null;
            }

            if (titleLabel != null) {
                titleLabel.Dispose ();
                titleLabel = null;
            }
        }
    }
}