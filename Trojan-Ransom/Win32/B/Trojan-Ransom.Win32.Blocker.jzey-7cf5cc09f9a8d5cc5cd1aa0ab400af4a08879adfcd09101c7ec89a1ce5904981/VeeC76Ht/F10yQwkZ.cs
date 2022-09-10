using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace VeeC76Ht;

internal class F10yQwkZ
{
	internal static object WUrW74sL(Type type_0, string string_0, int int_0)
	{
		return (int_0 ^ 0x582A) switch
		{
			_ => Enum.Parse(type_0, string_0), 
		};
	}

	internal static bool K3qKGRBN(object object_0, object object_1, bool bool_0, int int_0)
	{
		return (int_0 ^ 0xBEE4) switch
		{
			1 => Operators.ConditionalCompareObjectNotEqual(object_0, object_1, bool_0), 
			2 => Operators.ConditionalCompareObjectGreaterEqual(object_0, object_1, bool_0), 
			3 => Operators.ConditionalCompareObjectLessEqual(object_0, object_1, bool_0), 
			4 => Operators.ConditionalCompareObjectLess(object_0, object_1, bool_0), 
			5 => Operators.ConditionalCompareObjectGreater(object_0, object_1, bool_0), 
			_ => Operators.ConditionalCompareObjectEqual(object_0, object_1, bool_0), 
		};
	}

	internal static void exk7qz0L(ComboBox comboBox_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0xD5C9)
		{
		}
		comboBox_0.set_SelectedIndex(int_0);
	}

	internal static ObjectCollection Y7wNgoTy(ComboBox comboBox_0, int int_0)
	{
		return (ObjectCollection)((int_0 ^ 0x4823) switch
		{
			_ => comboBox_0.get_Items(), 
		});
	}

	internal static int smethod_0(ObjectCollection objectCollection_0, object object_0, int int_0)
	{
		return (int_0 ^ 0xC628) switch
		{
			_ => objectCollection_0.Add(object_0), 
		};
	}

	internal static string[] smethod_1(Type type_0, int int_0)
	{
		return (int_0 ^ 0x42AD) switch
		{
			_ => Enum.GetNames(type_0), 
		};
	}

	internal static int febNgslm(Control control_0, int int_0)
	{
		return (int_0 ^ 0x39A0) switch
		{
			1 => control_0.get_Width(), 
			2 => control_0.get_Top(), 
			3 => control_0.get_Height(), 
			_ => control_0.get_Left(), 
		};
	}

	internal static int UGY0xFvl(ComboBox comboBox_0, int int_0)
	{
		return (int_0 ^ 0x2263) switch
		{
			_ => comboBox_0.get_SelectedIndex(), 
		};
	}

	internal static object aSDLyd1L(ObjectCollection objectCollection_0, int int_0, int int_1)
	{
		return (int_1 ^ 0x538A) switch
		{
			_ => objectCollection_0.get_Item(int_0), 
		};
	}

	internal static string zN0SvdUV(object object_0, int int_0)
	{
		return (int_0 ^ 0x65D3) switch
		{
			_ => object_0.ToString(), 
		};
	}

	internal static void smethod_2(ListBox listBox_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0xDC38)
		{
		}
		listBox_0.set_ItemHeight(int_0);
	}

	internal static void zXt5uXYr(ListBox listBox_0, Font font_0, int int_0)
	{
		switch (int_0 ^ 0x63B0)
		{
		}
		listBox_0.set_Font(font_0);
	}

	internal static ObjectCollection smethod_3(ListBox listBox_0, int int_0)
	{
		return (ObjectCollection)((int_0 ^ 0x164A) switch
		{
			_ => listBox_0.get_Items(), 
		});
	}

	internal static void cpetstRH(ObjectCollection objectCollection_0, int int_0)
	{
		switch (int_0 ^ 0xF3BE)
		{
		}
		objectCollection_0.Clear();
	}

	internal static int M2U77s85(ObjectCollection objectCollection_0, object object_0, int int_0)
	{
		return (int_0 ^ 0x4D9A) switch
		{
			_ => objectCollection_0.Add(object_0), 
		};
	}

	internal static void BYcBJVhC(ObjectCollection objectCollection_0, int int_0)
	{
		switch (int_0 ^ 0x47F6)
		{
		}
		objectCollection_0.Clear();
	}

	internal static int PzOMAVvP(ListBox listBox_0, int int_0)
	{
		return (int_0 ^ 0xE234) switch
		{
			_ => listBox_0.get_SelectedIndex(), 
		};
	}

	internal static object SvPNRNc6(ListBox listBox_0, int int_0)
	{
		return (int_0 ^ 0xD5B5) switch
		{
			_ => listBox_0.get_SelectedItem(), 
		};
	}

	internal static object smethod_4(ComboBox comboBox_0, int int_0)
	{
		return (int_0 ^ 0x9B29) switch
		{
			_ => comboBox_0.get_SelectedItem(), 
		};
	}

	internal static void Axnr4Wjh(CheckBox checkBox_0, EventHandler eventHandler_0, int int_0)
	{
		switch (int_0 ^ 0x883C)
		{
		default:
			checkBox_0.remove_CheckedChanged(eventHandler_0);
			break;
		case 1:
			checkBox_0.add_CheckedChanged(eventHandler_0);
			break;
		}
	}
}
