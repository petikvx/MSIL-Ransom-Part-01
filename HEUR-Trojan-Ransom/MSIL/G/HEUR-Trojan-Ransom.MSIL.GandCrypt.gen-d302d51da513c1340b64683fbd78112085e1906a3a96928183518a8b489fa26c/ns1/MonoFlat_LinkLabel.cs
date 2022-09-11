using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns1;

public class MonoFlat_LinkLabel : LinkLabel
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 308)]
	private struct Struct3
	{
	}

	private static readonly Array array_0;

	private static readonly object object_0 = new char[154];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public MonoFlat_LinkLabel()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)this).set_Font(new Font("Segoe UI", 9f, (FontStyle)0));
		((Control)this).set_BackColor(Color.Transparent);
		((LinkLabel)this).set_LinkColor(Color.FromArgb(181, 41, 42));
		((LinkLabel)this).set_ActiveLinkColor(Color.FromArgb(153, 34, 34));
		((LinkLabel)this).set_VisitedLinkColor(Color.FromArgb(181, 41, 42));
		((LinkLabel)this).set_LinkBehavior((LinkBehavior)3);
	}

	static MonoFlat_LinkLabel()
	{
		char[] array = new char[8];
		array[4] = '㢗';
		array[3] = 'ᐓ';
		array[6] = 'ֆ';
		array[2] = 'ᬮ';
		array[7] = '\u10cf';
		array[1] = 'ឋ';
		array[0] = 'Ϳ';
		array[5] = 'ɚ';
		array_1 = new string[16];
		array_0 = array;
	}
}
