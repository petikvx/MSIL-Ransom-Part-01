using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class NavMenuItemSelectedEventArgs : EventArgs
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 56)]
	private struct Struct1
	{
	}

	private NavMenuSubItem navMenuSubItem_0;

	private static readonly object object_0;

	private static readonly object object_1 = new char[28];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal NavMenuItem navMenuItem_0;

	public NavMenuItem Item => navMenuItem_0;

	public NavMenuSubItem SubItem => navMenuSubItem_0;

	public NavMenuItemSelectedEventArgs(NavMenuItem navMenuItem_1, NavMenuSubItem navMenuSubItem_1)
	{
		NavMenuItem navMenuItem = (navMenuItem_0 = navMenuItem_1);
		navMenuSubItem_0 = navMenuSubItem_1;
	}

	static NavMenuItemSelectedEventArgs()
	{
		char[] array = new char[8];
		array[5] = '㔧';
		array[2] = '\u0b56';
		array[1] = '\u0ff6';
		array[6] = '⯫';
		array[4] = 'ᎏ';
		array[7] = 'Ⓩ';
		array[0] = '㸭';
		array[3] = '፬';
		array_0 = new string[3];
		object_0 = array;
	}
}
