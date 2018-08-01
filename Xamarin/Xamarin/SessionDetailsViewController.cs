using Foundation;
using System;
using UIKit;

namespace Xamarin
{
    public partial class SessionDetailsViewController : UITableViewController
    {
        public SessionData Session {get; set;} 

        public SessionDetailsViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            titleLabel.Text = Session.session_Title;
            sessionSwitch.Selected = Session.isTechnical;
        }
    }
}