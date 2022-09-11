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

	private NavMenuItem navMenuItem_0;

	private NavMenuSubItem navMenuSubItem_0;

	private static readonly object object_0;

	private static readonly Array array_0 = new char[28];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public NavMenuItem Item => navMenuItem_0;

	public NavMenuSubItem SubItem => navMenuSubItem_0;

	public NavMenuItemSelectedEventArgs(NavMenuItem navMenuItem_1, NavMenuSubItem navMenuSubItem_1)
	{
		navMenuItem_0 = navMenuItem_1;
		navMenuSubItem_0 = navMenuSubItem_1;
	}

	static NavMenuItemSelectedEventArgs()
	{
		char[] array = new char[8];
		array[3] = '\u20ed';
		array[7] = '\u0cd8';
		array[1] = '\u0b3a';
		array[0] = 'ㆧ';
		array[2] = '↞';
		array[4] = 'ຫ';
		array[6] = 'ᘱ';
		array[5] = 'ݹ';
		object_1 = new string[3];
		object_0 = array;
	}
}
