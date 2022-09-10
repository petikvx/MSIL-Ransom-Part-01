using System.Drawing;
using System.Windows.Forms;

namespace ONtsBLOT;

internal class LlV5CN3F
{
	internal static void oGvpzTsl(ColumnHeaderCollection columnHeaderCollection_0, ColumnHeader[] columnHeader_0, int int_0)
	{
		switch (int_0 ^ 0xAC8A)
		{
		}
		columnHeaderCollection_0.AddRange(columnHeader_0);
	}

	internal static TabPageCollection VKCTkT1c(TabControl tabControl_0, int int_0)
	{
		return (TabPageCollection)((int_0 ^ 0x2610) switch
		{
			_ => tabControl_0.get_TabPages(), 
		});
	}

	internal static void MShY1iLg(TabPageCollection tabPageCollection_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x57DD)
		{
		}
		tabPageCollection_0.RemoveAt(int_0);
	}

	internal static ListViewItem k85QrrI2(ListViewItemCollection listViewItemCollection_0, int int_0, int int_1)
	{
		return (ListViewItem)((int_1 ^ 0x9C5A) switch
		{
			_ => listViewItemCollection_0.get_Item(int_0), 
		});
	}

	internal static ListViewSubItemCollection PdMN5nK6(ListViewItem listViewItem_0, int int_0)
	{
		return (ListViewSubItemCollection)((int_0 ^ 0x33A7) switch
		{
			_ => listViewItem_0.get_SubItems(), 
		});
	}

	internal static ListViewSubItem jMz6wqvu(ListViewSubItemCollection listViewSubItemCollection_0, string string_0, int int_0)
	{
		return (ListViewSubItem)((int_0 ^ 0x1D8) switch
		{
			_ => listViewSubItemCollection_0.Add(string_0), 
		});
	}

	internal static ListViewItem smethod_0(ListViewItemCollection listViewItemCollection_0, string string_0, int int_0)
	{
		return (ListViewItem)((int_0 ^ 0xEBF8) switch
		{
			_ => listViewItemCollection_0.Add(string_0), 
		});
	}

	internal static int Ue4rNCTu(ListViewItem listViewItem_0, int int_0)
	{
		return (int_0 ^ 0xAED2) switch
		{
			_ => listViewItem_0.get_Index(), 
		};
	}

	internal static void smethod_1(ListViewItemCollection listViewItemCollection_0, int int_0)
	{
		switch (int_0 ^ 0x8900)
		{
		}
		listViewItemCollection_0.Clear();
	}

	internal static SelectedListViewItemCollection smethod_2(ListView listView_0, int int_0)
	{
		return (SelectedListViewItemCollection)((int_0 ^ 0xC9BD) switch
		{
			_ => listView_0.get_SelectedItems(), 
		});
	}

	internal static int DAJ6sV1d(SelectedListViewItemCollection selectedListViewItemCollection_0, int int_0)
	{
		return (int_0 ^ 0x900D) switch
		{
			_ => selectedListViewItemCollection_0.get_Count(), 
		};
	}

	internal static ListViewItem sFSQijiH(SelectedListViewItemCollection selectedListViewItemCollection_0, int int_0, int int_1)
	{
		return (ListViewItem)((int_1 ^ 0xF7B2) switch
		{
			_ => selectedListViewItemCollection_0.get_Item(int_0), 
		});
	}

	internal static string S54VmonS(ListViewItem listViewItem_0, int int_0)
	{
		return (int_0 ^ 0xFD9B) switch
		{
			_ => listViewItem_0.get_Text(), 
		};
	}

	internal static void ezFPWwog(ToolStripItem toolStripItem_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xEDC1)
		{
		default:
			toolStripItem_0.set_ToolTipText(string_0);
			break;
		case 1:
			toolStripItem_0.set_Name(string_0);
			break;
		case 2:
			toolStripItem_0.set_Text(string_0);
			break;
		}
	}

	internal static void taNdSN16(ToolStripItem toolStripItem_0, Size size_0, int int_0)
	{
		switch (int_0 ^ 0xAED6)
		{
		}
		toolStripItem_0.set_Size(size_0);
	}

	internal static void yQDrlg6O(ToolStripItem toolStripItem_0, Color color_0, int int_0)
	{
		switch (int_0 ^ 0x7B95)
		{
		}
		toolStripItem_0.set_ImageTransparentColor(color_0);
	}

	internal static void SXmCzOxe(DataGridViewColumn dataGridViewColumn_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xC4E3)
		{
		default:
			dataGridViewColumn_0.set_HeaderText(string_0);
			break;
		case 1:
			dataGridViewColumn_0.set_Name(string_0);
			break;
		}
	}

	internal static ImageCollection dRRTgbgW(ImageList imageList_0, int int_0)
	{
		return (ImageCollection)((int_0 ^ 0xC595) switch
		{
			_ => imageList_0.get_Images(), 
		});
	}

	internal static void hCm8v5O5(ImageCollection imageCollection_0, int int_0, string string_0, int int_1)
	{
		switch (int_1 ^ 0x92DF)
		{
		}
		imageCollection_0.SetKeyName(int_0, string_0);
	}

	internal static void smethod_3(Control control_0, DockStyle dockStyle_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0xE725)
		{
		}
		control_0.set_Dock(dockStyle_0);
	}
}
