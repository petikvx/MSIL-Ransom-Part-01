using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

internal class ListViewItemComparer : IComparer
{
	private int m_ColumnNumber;

	private SortOrder m_SortOrder;

	public ListViewItemComparer(int column_number, SortOrder sort_order)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		m_ColumnNumber = column_number;
		m_SortOrder = sort_order;
	}

	public int Compare(object x, object y)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		ListViewItem val = (ListViewItem)x;
		ListViewItem val2 = (ListViewItem)y;
		string text = ((val.get_SubItems().get_Count() > m_ColumnNumber) ? val.get_SubItems().get_Item(m_ColumnNumber).get_Text() : "");
		string text2 = ((val2.get_SubItems().get_Count() > m_ColumnNumber) ? val2.get_SubItems().get_Item(m_ColumnNumber).get_Text() : "");
		if ((int)m_SortOrder == 1)
		{
			if (Versioned.IsNumeric((object)text) & Versioned.IsNumeric((object)text2))
			{
				return Conversion.Val(text).CompareTo(Conversion.Val(text2));
			}
			if (Information.IsDate((object)text) & Information.IsDate((object)text2))
			{
				return DateTime.Parse(text).CompareTo(DateTime.Parse(text2));
			}
			return string.Compare(text, text2);
		}
		if (Versioned.IsNumeric((object)text) & Versioned.IsNumeric((object)text2))
		{
			return Conversion.Val(text2).CompareTo(Conversion.Val(text));
		}
		if (Information.IsDate((object)text) & Information.IsDate((object)text2))
		{
			return DateTime.Parse(text2).CompareTo(DateTime.Parse(text));
		}
		return string.Compare(text2, text);
	}
}
