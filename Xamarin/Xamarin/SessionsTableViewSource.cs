using System;
using Foundation;
using UIKit;
namespace Xamarin

{
    public class SessionsTableViewSource : UITableViewSource
   {
    SessionData[] TableItems;
    string CellIdentifier = "SessionCell";
    public SessionsTableViewSource(SessionData[] sessions)
    {
            TableItems = sessions;
    }

    public override nint RowsInSection(UITableView tableview, nint section)
    {
        return TableItems.Length;
    }

    public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
    {
        UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
        SessionData item = TableItems[indexPath.Row];

        //---- if there are no cells to reuse, create a new one
        if (cell == null)
        { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

        //.TextLabel.Text = item;

        return cell;
    }
  }
}
