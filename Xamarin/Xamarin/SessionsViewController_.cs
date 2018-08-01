using Foundation;
using System;
using UIKit;
using System.Collections;

namespace Xamarin
{
    public partial class SessionsViewController : UITableViewController
    {
        
        private UITableView tableView;
        private SessionData[] sessions;

        public SessionsViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            uiconfig();
        }

        public void uiconfig()
        {
            SessionData[] sessions = new SessionData[5]{
                new SessionData("1","Session Title1","speaker1","desc 1",DateTime.Today,true),
                new SessionData("2","Session Title2","speaker2","desc 2",DateTime.Today,true),
                new SessionData("3","Session Title3","speaker3","desc 3",DateTime.Today,true),
                new SessionData("4","Session Title4","speaker4","desc 4",DateTime.Today,true),
                new SessionData("5","Session Title5","speaker5","desc 5",DateTime.Today,true)
            };
            this.sessions = sessions;
            tableView = new UITableView();

            tableView.Frame = this.View.Bounds;
            tableView.Source = new SessionsTableViewSource(sessions,this);
            tableView.RegisterNibForCellReuse(SessionsTableViewCell.Nib, "SessionsTableViewCell");
            this.View.AddSubview(tableView);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier.Equals("sessionDetailsSegue"))
            {
                var viewController = segue.DestinationViewController as SessionDetailsViewController;
                if (viewController != null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var session = sessions[rowPath.Row];
                    viewController.Session = session;
                }
            };

        }


        private class SessionsTableViewSource : UITableViewSource
        {
            private SessionData[] sessions;
            SessionsViewController owner;

            public SessionsTableViewSource(SessionData[] sessions, SessionsViewController owner)
            {
                this.sessions = sessions;
                this.owner = owner;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                SessionsTableViewCell cell = (SessionsTableViewCell)tableView.DequeueReusableCell(SessionsTableViewCell.Key);
                cell.titleLabel.Text = sessions[indexPath.Row].session_Title;
                cell.desLabel.Text = sessions[indexPath.Row].session_Description;
                cell.speakerLabel.Text = sessions[indexPath.Row].session_Speaker;
                cell.dateLabel.Text = sessions[indexPath.Row].session_Date.ToShortDateString();

                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return sessions.Length;
            }

           

        }


       
    }

 
}

