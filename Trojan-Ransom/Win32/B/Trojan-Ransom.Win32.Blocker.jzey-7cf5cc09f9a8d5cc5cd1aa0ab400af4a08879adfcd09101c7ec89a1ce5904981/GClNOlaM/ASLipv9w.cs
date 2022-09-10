using System.Drawing;
using System.Windows.Forms;

namespace GClNOlaM;

internal class ASLipv9w
{
	internal static void smethod_0(CheckBox checkBox_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xF81B)
		{
		}
		checkBox_0.set_Checked(bool_0);
	}

	internal static bool w5eBDkdN(CheckBox checkBox_0, int int_0)
	{
		return (int_0 ^ 0xDA7C) switch
		{
			_ => checkBox_0.get_Checked(), 
		};
	}

	internal static void L5vXBQzX(Control control_0, MouseEventHandler mouseEventHandler_0, int int_0)
	{
		switch (int_0 ^ 0xF7E9)
		{
		default:
			control_0.add_MouseDoubleClick(mouseEventHandler_0);
			break;
		case 1:
			control_0.remove_MouseDoubleClick(mouseEventHandler_0);
			break;
		case 2:
			control_0.remove_MouseDown(mouseEventHandler_0);
			break;
		case 3:
			control_0.add_MouseMove(mouseEventHandler_0);
			break;
		case 4:
			control_0.add_MouseDown(mouseEventHandler_0);
			break;
		case 5:
			control_0.remove_MouseMove(mouseEventHandler_0);
			break;
		case 6:
			control_0.remove_MouseUp(mouseEventHandler_0);
			break;
		case 7:
			control_0.add_MouseUp(mouseEventHandler_0);
			break;
		}
	}

	internal static void eeb3x4LW(Form form_0, Form form_1, int int_0)
	{
		switch (int_0 ^ 0x1033)
		{
		}
		form_0.set_MdiParent(form_1);
	}

	internal static Form[] cyFf9jrZ(Form form_0, int int_0)
	{
		return (int_0 ^ 0xB32B) switch
		{
			_ => form_0.get_MdiChildren(), 
		};
	}

	internal static void FtUXCIXf(ListView listView_0, SortOrder sortOrder_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0xDCEA)
		{
		}
		listView_0.set_Sorting(sortOrder_0);
	}

	internal static void jAFYqlFi(ListView listView_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x3DF1)
		{
		default:
			listView_0.set_MultiSelect(bool_0);
			break;
		case 1:
			listView_0.set_UseCompatibleStateImageBehavior(bool_0);
			break;
		}
	}

	internal static void smethod_1(Control control_0, AnchorStyles anchorStyles_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0x8CF2)
		{
		}
		control_0.set_Anchor(anchorStyles_0);
	}

	internal static void jip5FYDs(TabPage tabPage_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x25CC)
		{
		}
		tabPage_0.set_UseVisualStyleBackColor(bool_0);
	}

	internal static void Evh8VCkw(ColumnHeader columnHeader_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0x170F)
		{
		}
		columnHeader_0.set_Text(string_0);
	}

	internal static void gVKXoNvQ(ListView listView_0, View view_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0xC37E)
		{
		}
		listView_0.set_View(view_0);
	}

	internal static void SndtE16C(TabPage tabPage_0, Point point_0, int int_0)
	{
		switch (int_0 ^ 0x487)
		{
		}
		tabPage_0.set_Location(point_0);
	}

	internal static ListViewItemCollection asDkjSAl(ListView listView_0, int int_0)
	{
		return (ListViewItemCollection)((int_0 ^ 0x4294) switch
		{
			_ => listView_0.get_Items(), 
		});
	}

	internal static void WdjU4xmq(ListViewItemCollection listViewItemCollection_0, ListViewItem[] listViewItem_0, int int_0)
	{
		switch (int_0 ^ 0x699)
		{
		}
		listViewItemCollection_0.AddRange(listViewItem_0);
	}

	internal static void l89Xil4v(Control control_0, Padding padding_0, int int_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		switch (int_0 ^ 0x5584)
		{
		}
		control_0.set_Padding(padding_0);
	}

	internal static void MyciL9OD(ColumnHeader columnHeader_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x6407)
		{
		}
		columnHeader_0.set_Width(int_0);
	}

	internal static void pFXtYZco(TabPage tabPage_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x8CA9)
		{
		}
		tabPage_0.set_TabIndex(int_0);
	}

	internal static void lp0buAMk(TabPage tabPage_0, string string_0, int int_0)
	{
		switch (int_0 ^ 0xE15B)
		{
		}
		tabPage_0.set_Text(string_0);
	}

	internal static void smethod_2(TabControl tabControl_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x5584)
		{
		}
		tabControl_0.set_SelectedIndex(int_0);
	}

	internal static ColumnHeaderCollection n8yKFiAN(ListView listView_0, int int_0)
	{
		return (ColumnHeaderCollection)((int_0 ^ 0xAD72) switch
		{
			_ => listView_0.get_Columns(), 
		});
	}
}
