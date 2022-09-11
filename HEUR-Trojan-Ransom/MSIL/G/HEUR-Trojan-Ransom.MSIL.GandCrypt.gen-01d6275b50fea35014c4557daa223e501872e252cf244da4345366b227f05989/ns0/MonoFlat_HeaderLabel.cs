using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0;

public class MonoFlat_HeaderLabel : Label
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 336)]
	private struct Struct3
	{
	}

	private static readonly object object_0;

	private static readonly object object_1 = new char[168];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	public MonoFlat_HeaderLabel()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		((Control)this).set_Font(new Font("Segoe UI", 11f, (FontStyle)1));
		((Control)this).set_ForeColor(Color.FromArgb(255, 255, 255));
		((Control)this).set_BackColor(Color.Transparent);
	}

	static MonoFlat_HeaderLabel()
	{
		char[] array = new char[8];
		array[7] = '⏛';
		array[0] = '\u08b5';
		array[3] = 'ᰠ';
		array[6] = '࠹';
		array[4] = '\u2fe4';
		array[1] = '\u1c37';
		array[2] = '㽅';
		array[5] = 'ʽ';
		object_2 = new string[18];
		object_0 = array;
	}
}
