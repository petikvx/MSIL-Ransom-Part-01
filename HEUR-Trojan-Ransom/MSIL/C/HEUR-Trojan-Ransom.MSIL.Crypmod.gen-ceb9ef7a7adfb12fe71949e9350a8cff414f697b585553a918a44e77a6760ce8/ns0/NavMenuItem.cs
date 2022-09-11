using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ns1;

namespace ns0;

public sealed class NavMenuItem : NavMenuBaseItem
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 62)]
	private struct Struct1
	{
	}

	private bool bool_5;

	private NavMenuSubItemCollection navMenuSubItemCollection_0;

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[31];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal bool bool_6;

	internal bool bool_7;

	internal Rectangle rectangle_3;

	internal Rectangle rectangle_4;

	internal Class2 class2_0;

	internal Rectangle Rectangle_3
	{
		get
		{
			return rectangle_4;
		}
		set
		{
			Rectangle rectangle = (rectangle_4 = value);
		}
	}

	internal Rectangle Rectangle_4
	{
		get
		{
			return rectangle_3;
		}
		set
		{
			Rectangle rectangle = (rectangle_3 = value);
		}
	}

	internal Class2 Class2_0
	{
		get
		{
			return class2_0;
		}
		set
		{
			Class2 @class = (class2_0 = value);
		}
	}

	public bool Expanded
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
			method_6();
		}
	}

	public bool IsDropDown
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool flag = (bool_6 = value);
			method_6();
		}
	}

	public new bool Selected
	{
		get
		{
			if (bool_6)
			{
				return Boolean_3;
			}
			return base.Selected;
		}
		set
		{
			base.Selected = value;
		}
	}

	public NavMenuSubItemCollection SubItems => navMenuSubItemCollection_0;

	internal bool Boolean_3
	{
		get
		{
			if (!base.Enabled)
			{
				return false;
			}
			return bool_7;
		}
		set
		{
			bool flag = (bool_7 = value);
		}
	}

	public NavMenuItem()
	{
		bool_5 = true;
		bool_6 = true;
		navMenuSubItemCollection_0 = new NavMenuSubItemCollection();
	}

	public void method_12(NavMenu navMenu_1)
	{
		base.vmethod_0(navMenu_1, bool_5: true);
		navMenuSubItemCollection_0.method_5(this);
	}

	static NavMenuItem()
	{
		char[] array = new char[8];
		array[2] = '㾈';
		array[3] = '㣘';
		array[5] = '\u0b03';
		array[1] = 'ዄ';
		array[0] = 'ὑ';
		array[7] = '\u17c5';
		array[6] = 'ᨖ';
		array[4] = 'ⓑ';
		object_1 = new string[4];
		array_0 = array;
	}
}
