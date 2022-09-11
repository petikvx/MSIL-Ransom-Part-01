using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms.Design;

namespace ns0;

public class NavMenuDesigner : ControlDesigner
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[20];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	protected override bool vmethod_0(Point point_0)
	{
		return ((NavMenu)(object)((ControlDesigner)this).get_Control()).vmethod_0(((ControlDesigner)this).get_Control().PointToClient(point_0)) != null;
	}

	protected override void vmethod_1()
	{
		((NavMenu)(object)((ControlDesigner)this).get_Control()).method_3(null);
		((ControlDesigner)this).OnMouseLeave();
	}

	static NavMenuDesigner()
	{
		char[] array = new char[8];
		array[2] = '㾈';
		array[5] = '\u0b03';
		array[7] = '\u17c5';
		array[6] = 'ᨖ';
		array[0] = 'ὑ';
		array[1] = 'ዄ';
		array[4] = 'ⓑ';
		array[3] = '㣘';
		array_0 = new string[2];
		object_0 = array;
	}
}
