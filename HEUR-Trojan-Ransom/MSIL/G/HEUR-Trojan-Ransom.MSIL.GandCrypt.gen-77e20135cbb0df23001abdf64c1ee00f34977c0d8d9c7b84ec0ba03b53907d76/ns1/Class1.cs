using System.Windows.Forms;

namespace ns1;

internal sealed class Class1 : PictureBox
{
	public static void smethod_0(byte[] byte_0, byte[] byte_1, int int_0)
	{
		byte_0[int_0] ^= byte_1[int_0 % byte_1.Length];
	}
}
