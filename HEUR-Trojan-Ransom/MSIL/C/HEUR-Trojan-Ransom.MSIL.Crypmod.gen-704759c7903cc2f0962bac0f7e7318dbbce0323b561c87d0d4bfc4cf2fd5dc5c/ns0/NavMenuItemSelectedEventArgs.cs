using System;
using System.ComponentModel;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class NavMenuItemSelectedEventArgs : EventArgs
{
	private NavMenuItem navMenuItem_0;

	private NavMenuSubItem navMenuSubItem_0;

	public NavMenuItem Item => navMenuItem_0;

	public NavMenuSubItem SubItem => navMenuSubItem_0;

	public NavMenuItemSelectedEventArgs(NavMenuItem navMenuItem_1, NavMenuSubItem navMenuSubItem_1)
	{
		navMenuItem_0 = navMenuItem_1;
		navMenuSubItem_0 = navMenuSubItem_1;
	}
}
