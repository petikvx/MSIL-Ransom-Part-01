using System.Collections;
using System.Windows.Forms;

namespace Server.Helper;

public class ListViewColumnSorter : IComparer
{
	private int ColumnToSort;

	private SortOrder OrderOfSort;

	private CaseInsensitiveComparer ObjectCompare;

	public int SortColumn
	{
		get
		{
			return ColumnToSort;
		}
		set
		{
			ColumnToSort = value;
		}
	}

	public SortOrder Order
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return OrderOfSort;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			OrderOfSort = value;
		}
	}

	public ListViewColumnSorter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		ColumnToSort = 0;
		OrderOfSort = (SortOrder)0;
		ObjectCompare = new CaseInsensitiveComparer();
	}

	public int Compare(object x, object y)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		ListViewItem val = (ListViewItem)x;
		ListViewItem val2 = (ListViewItem)y;
		int num = ObjectCompare.Compare(val.get_SubItems().get_Item(ColumnToSort).get_Text(), val2.get_SubItems().get_Item(ColumnToSort).get_Text());
		if ((int)OrderOfSort == 1)
		{
			return num;
		}
		if ((int)OrderOfSort == 2)
		{
			return -num;
		}
		return 0;
	}
}
