using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ns0;

namespace ns1;

public sealed class NavMenuItem : NavMenuBaseItem
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
	private struct Struct0
	{
	}

	private bool bool_5;

	private Rectangle rectangle_3;

	private NavMenuSubItemCollection navMenuSubItemCollection_0;

	private Class2 class2_0;

	private static readonly object object_1;

	private static readonly object object_2 = new char[20];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal bool bool_6;

	internal bool bool_7;

	internal Rectangle rectangle_4;

	internal Rectangle Rectangle_3
	{
		get
		{
			return rectangle_3;
		}
		set
		{
			rectangle_3 = value;
		}
	}

	internal Rectangle Rectangle_4
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

	internal Class2 Class2_0
	{
		get
		{
			return class2_0;
		}
		set
		{
			class2_0 = value;
		}
	}

	public bool Expanded
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

	public bool IsDropDown
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

	public new bool Selected
	{
		get
		{
			if (bool_5)
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
		bool_6 = true;
		bool_5 = true;
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
		array[2] = '㛓';
		array[1] = 'Ԗ';
		array[4] = '\u0eeb';
		array[6] = 'ᴿ';
		array[3] = '㥴';
		array[0] = '┩';
		array[7] = '⦀';
		array[5] = 'Ʃ';
		array_0 = new string[2];
		object_1 = array;
	}
}
