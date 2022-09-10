using System.ComponentModel;

namespace ns1;

public sealed class NavMenuSubItem : NavMenuBaseItem
{
	internal NavMenuItem navMenuItem_0;

	[Browsable(false)]
	public NavMenuItem Parent => navMenuItem_0;

	internal void method_12(NavMenuItem navMenuItem_1)
	{
		if (navMenuItem_1 != null)
		{
			NavMenuItem navMenuItem = (navMenuItem_0 = navMenuItem_1);
			base.vmethod_0(navMenuItem_1.NavMenu_0, bool_5: false);
		}
	}
}
