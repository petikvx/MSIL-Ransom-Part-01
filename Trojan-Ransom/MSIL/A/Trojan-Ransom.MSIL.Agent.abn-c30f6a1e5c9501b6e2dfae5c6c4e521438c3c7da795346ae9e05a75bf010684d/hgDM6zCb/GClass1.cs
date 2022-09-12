using System.Security.Cryptography;

namespace hgDM6zCb;

public class GClass1
{
	internal static byte[] smethod_0(byte[] byte_0)
	{
		byte[] array = new byte[16]
		{
			200, 158, 84, 28, 83, 123, 52, 129, 144, 65,
			5, 78, 185, 215, 160, 128
		};
		using RijndaelManaged rijndaelManaged_ = new RijndaelManaged();
		GClass2.smethod_2(rijndaelManaged_, array);
		return Class4.Class5.smethod_0(byte_0, rijndaelManaged_, array);
	}
}
