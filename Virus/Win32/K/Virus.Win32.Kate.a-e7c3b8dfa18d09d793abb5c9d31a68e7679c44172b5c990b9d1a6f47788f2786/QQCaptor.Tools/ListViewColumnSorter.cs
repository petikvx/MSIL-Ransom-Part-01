using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QQCaptor.Tools;

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
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		ListViewItem val = (ListViewItem)x;
		ListViewItem val2 = (ListViewItem)y;
		string text = val.get_SubItems().get_Item(ColumnToSort).get_Text();
		string text2 = val2.get_SubItems().get_Item(ColumnToSort).get_Text();
		int result;
		int result2;
		int num = ((IsIP(text) && IsIP(text2)) ? CompareIp(text, text2) : ((!int.TryParse(text, out result) || !int.TryParse(text2, out result2)) ? ObjectCompare.Compare(text, text2) : CompareInt(result, result2)));
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

	public bool IsIP(string ip)
	{
		return Regex.Match(ip, "^(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])$").Success;
	}

	private int CompareInt(int x, int y)
	{
		if (x > y)
		{
			return 1;
		}
		if (x < y)
		{
			return -1;
		}
		return 0;
	}

	private int CompareIp(string ipx, string ipy)
	{
		string[] array = ipx.Split(new char[1] { '.' });
		string[] array2 = ipy.Split(new char[1] { '.' });
		int num = 0;
		while (true)
		{
			if (num < 4)
			{
				if (Convert.ToInt32(array[num]) <= Convert.ToInt32(array2[num]))
				{
					if (Convert.ToInt32(array[num]) < Convert.ToInt32(array2[num]))
					{
						break;
					}
					num++;
					continue;
				}
				return 1;
			}
			return 0;
		}
		return -1;
	}
}
