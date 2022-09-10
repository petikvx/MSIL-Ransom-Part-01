using System.Windows.Forms;

namespace QQCaptor.Tools;

public class ListViewHelper
{
	public static void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		ListView val = (ListView)((sender is ListView) ? sender : null);
		if (e.get_Column() == (val.get_ListViewItemSorter() as ListViewColumnSorter).SortColumn)
		{
			if ((int)(val.get_ListViewItemSorter() as ListViewColumnSorter).Order == 1)
			{
				(val.get_ListViewItemSorter() as ListViewColumnSorter).Order = (SortOrder)2;
			}
			else
			{
				(val.get_ListViewItemSorter() as ListViewColumnSorter).Order = (SortOrder)1;
			}
		}
		else
		{
			(val.get_ListViewItemSorter() as ListViewColumnSorter).SortColumn = e.get_Column();
			(val.get_ListViewItemSorter() as ListViewColumnSorter).Order = (SortOrder)1;
		}
		((ListView)sender).Sort();
	}
}
