using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace TGaER2JO;

internal class sSR2WoR5
{
	internal static void TK0xERZ6(TreeNodeCollection treeNodeCollection_0, int int_0)
	{
		switch (int_0 ^ 0xDCDA)
		{
		}
		treeNodeCollection_0.Clear();
	}

	internal static TreeNode xp96UAwa(TreeNodeCollection treeNodeCollection_0, string string_0, string string_1, int int_0)
	{
		return (TreeNode)((int_0 ^ 0x6395) switch
		{
			_ => treeNodeCollection_0.Add(string_0, string_1), 
		});
	}

	internal static void FplyA2dG(Form form_0, IWin32Window iwin32Window_0, int int_0)
	{
		switch (int_0 ^ 0xCCFC)
		{
		}
		form_0.Show(iwin32Window_0);
	}

	internal static TreeNode CWPtSJwr(TreeNodeMouseClickEventArgs treeNodeMouseClickEventArgs_0, int int_0)
	{
		return (TreeNode)((int_0 ^ 0x3A69) switch
		{
			_ => treeNodeMouseClickEventArgs_0.get_Node(), 
		});
	}

	internal static string Kua3nlB7(TreeNode treeNode_0, int int_0)
	{
		return (int_0 ^ 0x3223) switch
		{
			_ => treeNode_0.get_Text(), 
		};
	}

	internal static void QgTGUBli(XmlTextWriter xmlTextWriter_0, int int_0)
	{
		switch (int_0 ^ 0x8F9F)
		{
		}
		xmlTextWriter_0.WriteEndElement();
	}

	internal static void IbTYXQVQ(object object_0, int int_0)
	{
		switch (int_0 ^ 0x9E3)
		{
		}
		object_0.Finalize();
	}

	internal static string wjVH1wdN(IFormatProvider iformatProvider_0, string string_0, object[] object_0, int int_0)
	{
		return (int_0 ^ 0x6875) switch
		{
			_ => string.Format(iformatProvider_0, string_0, object_0), 
		};
	}

	internal static bool TIlpptNk(string string_0, int int_0)
	{
		return (int_0 ^ 0xEDC) switch
		{
			_ => Conversions.ToBoolean(string_0), 
		};
	}

	internal static Thread OdIk9xL0(int int_0)
	{
		return (int_0 ^ 0xE3A1) switch
		{
			_ => Thread.CurrentThread, 
		};
	}

	internal static bool AxKHQxtU(object object_0, int int_0)
	{
		return (int_0 ^ 0xF714) switch
		{
			_ => Monitor.TryEnter(object_0), 
		};
	}

	internal static void yjw3pT6k(MenuItem menuItem_0, bool bool_0, int int_0)
	{
		switch (int_0 ^ 0x4439)
		{
		}
		menuItem_0.set_Checked(bool_0);
	}

	internal static MenuItemCollection smethod_0(Menu menu_0, int int_0)
	{
		return (MenuItemCollection)((int_0 ^ 0x571A) switch
		{
			_ => menu_0.get_MenuItems(), 
		});
	}

	internal static int oz9J8BHZ(MenuItemCollection menuItemCollection_0, MenuItem menuItem_0, int int_0)
	{
		return (int_0 ^ 0xBFC6) switch
		{
			_ => menuItemCollection_0.Add(menuItem_0), 
		};
	}

	internal static double yV7uLwXl(object object_0, int int_0)
	{
		return (int_0 ^ 0x823C) switch
		{
			_ => Conversions.ToDouble(object_0), 
		};
	}

	internal static string erR6XKUV(string string_0, object object_0, int int_0)
	{
		return (int_0 ^ 0xE002) switch
		{
			_ => string.Format(string_0, object_0), 
		};
	}

	internal static object smethod_1(string string_0, int int_0)
	{
		return (int_0 ^ 0x8DB6) switch
		{
			_ => string_0.Clone(), 
		};
	}

	internal static void EvihoKLX(Graphics graphics_0, Pen pen_0, int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		switch (int_4 ^ 0x3F0F)
		{
		default:
			graphics_0.DrawLine(pen_0, int_0, int_1, int_2, int_3);
			break;
		case 1:
			graphics_0.DrawRectangle(pen_0, int_0, int_1, int_2, int_3);
			break;
		}
	}

	internal static void CwuuMByw(Pen pen_0, Color color_0, int int_0)
	{
		switch (int_0 ^ 0xE352)
		{
		}
		pen_0.set_Color(color_0);
	}

	internal static void smethod_2(Pen pen_0, float float_0, int int_0)
	{
		switch (int_0 ^ 0x16B7)
		{
		}
		pen_0.set_Width(float_0);
	}
}
