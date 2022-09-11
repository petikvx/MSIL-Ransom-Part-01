using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0;

public class GClass5 : Label
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 258)]
	private struct Struct4
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0 = new char[129];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public GClass5()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)this).set_Font(new Font("Segoe UI", 11f, (FontStyle)1));
		((Control)this).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)this).set_BackColor(Color.Transparent);
	}

	static GClass5()
	{
		char[] array = new char[8];
		array[3] = 'ဍ';
		array[4] = 'ᳫ';
		array[6] = '⟶';
		array[0] = '♺';
		array[5] = '➝';
		array[7] = 'ᴚ';
		array[2] = 'ৼ';
		array[1] = '㈁';
		object_1 = new string[16];
		object_0 = array;
	}
}
