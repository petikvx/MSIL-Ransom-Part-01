using System.ComponentModel;
using System.Drawing;
using ns0;

namespace ns1;

public sealed class NavMenuItem : NavMenuBaseItem
{
	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	private Rectangle rectangle_3;

	private Rectangle rectangle_4;

	private Class2 class2_0;

	internal Rectangle Rectangle_3
	{
		get
		{
			return rectangle_4;
		}
		set
		{
			rectangle_4 = value;
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
			rectangle_3 = value;
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

	[DefaultValue(true)]
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

	[DefaultValue(true)]
	public bool IsDropDown
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
			method_6();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
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

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
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
			bool_7 = value;
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
}
