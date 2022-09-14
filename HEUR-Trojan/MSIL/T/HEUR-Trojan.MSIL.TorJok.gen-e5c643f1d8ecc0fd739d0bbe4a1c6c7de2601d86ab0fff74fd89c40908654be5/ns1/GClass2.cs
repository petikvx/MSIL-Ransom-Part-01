using System.Runtime.InteropServices;
using ns11;
using ns2;
using ns3;
using ns5;
using ns8;
using ns9;

namespace ns1;

[ComVisible(true)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public sealed class GClass2
{
	public byte[] byte_0;

	public int int_0;

	public int int_1;

	public long long_0;

	public byte[] byte_1;

	public int int_2;

	public int int_3;

	public long long_1;

	public string string_0;

	internal Class38 class38_0;

	internal Class43 class43_0;

	internal uint uint_0;

	public Enum20 enum20_0 = Enum20.const_8;

	public int int_4 = 15;

	public Enum21 enum21_0;

	public int Adler32 => (int)uint_0;

	public GClass2()
	{
	}

	public GClass2(Enum22 enum22_0)
	{
		switch (enum22_0)
		{
		case Enum22.const_0:
			if (Class6.smethod_298(this) != 0)
			{
				throw new GException0("Cannot initialize for deflate.");
			}
			break;
		case Enum22.const_1:
			if (Class6.smethod_523(this) != 0)
			{
				throw new GException0("Cannot initialize for inflate.");
			}
			break;
		default:
			throw new GException0("Invalid ZlibStreamFlavor.");
		}
	}
}
