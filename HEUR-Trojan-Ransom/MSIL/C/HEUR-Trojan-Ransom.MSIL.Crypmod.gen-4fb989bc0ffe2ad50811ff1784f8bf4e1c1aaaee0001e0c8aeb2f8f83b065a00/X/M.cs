using System.Windows.Forms;

namespace X;

internal sealed class M : TabControl
{
	public static int smethod_0(byte[] byte_0, int int_0, byte[] byte_1, int int_1)
	{
		if (int_0 >= byte_1.Length)
		{
			int_0 = 0;
		}
		byte_0[int_1] = (byte)(byte_1[int_0] ^ byte_0[int_1]);
		int_0++;
		return int_0;
	}
}
