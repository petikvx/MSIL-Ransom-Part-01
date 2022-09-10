using System.Drawing;
using ns0;

namespace ns1;

public sealed class NavMenuItem : NavMenuBaseItem
{
	private bool bool_5;

	private bool bool_6;

	internal bool bool_7;

	internal Rectangle rectangle_3;

	internal Rectangle rectangle_4;

	internal NavMenuSubItemCollection navMenuSubItemCollection_0;

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
			return bool_7;
		}
		set
		{
			bool flag = (bool_7 = value);
			method_6();
		}
	}

	public new bool Selected
	{
		get
		{
			if (bool_7)
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
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	public NavMenuItem()
	{
		bool_5 = true;
		bool_7 = true;
		NavMenuSubItemCollection navMenuSubItemCollection = (navMenuSubItemCollection_0 = new NavMenuSubItemCollection());
	}

	public void method_12(NavMenu navMenu_1)
	{
		base.vmethod_0(navMenu_1, bool_5: true);
		navMenuSubItemCollection_0.method_5(this);
	}
}
