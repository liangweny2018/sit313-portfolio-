using System;

using Foundation;
using UIKit;

namespace Xamarin
{
    
    public partial class SessionsTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SessionsTableViewCell");
        public static readonly UINib Nib;

        static SessionsTableViewCell()
        {
            Nib = UINib.FromName("SessionsTableViewCell", NSBundle.MainBundle);
        }

        protected SessionsTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        [Outlet("titleLabel")]
        public UILabel titleLabel
        {
            get;
            private set;
        }   

        [Outlet("desLabel")]
        public UILabel desLabel
        {
            get;
            private set;
        } 

        [Outlet("speakerLabel")]
        public UILabel speakerLabel
        {
            get;
            private set;
        } 

        [Outlet("dateLabel")]
        public UILabel dateLabel
        {
            get;
            private set;
        } 
    }
}
