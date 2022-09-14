using ns1;
using ns11;
using ns3;
using ns5;

namespace ns14;

internal sealed class Class45
{
	public byte[] byte_0;

	public byte[] byte_1;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public GClass2 gclass2_0;

	public Class45(int int_5, Enum20 enum20_0, Enum21 enum21_0, int int_6)
	{
		byte_0 = new byte[int_5];
		int num = int_5 + (int_5 / 32768 + 1) * 5 * 2;
		byte_1 = new byte[num];
		gclass2_0 = new GClass2();
		Class6.smethod_92(enum20_0, gclass2_0, bool_0: false);
		gclass2_0.byte_1 = byte_1;
		gclass2_0.byte_0 = byte_0;
		int_1 = int_6;
	}
}
