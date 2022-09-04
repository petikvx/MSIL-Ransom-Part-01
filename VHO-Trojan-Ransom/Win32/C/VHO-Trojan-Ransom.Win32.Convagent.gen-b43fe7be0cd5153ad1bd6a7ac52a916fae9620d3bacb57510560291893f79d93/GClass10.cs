using System.Collections.Generic;
using System.Text;

public static class GClass10
{
	private const int int_0 = 12286;

	public static void smethod_0(string string_0)
	{
		try
		{
			if (GClass1.smethod_2())
			{
				GClass6 gClass = GClass1.smethod_1<GClass6>();
				GClass5 gClass2 = GClass1.smethod_1<GClass5>();
				int int_ = gClass.method_2();
				int num = gClass.method_3(int_);
				GClass7 gClass3 = gClass.method_4<GClass7>(num, int_);
				GClass8 gClass4 = gClass2.method_2<GClass8>(num, int_);
				int num2 = gClass3.method_2(65535);
				for (int i = 0; i < num2; i++)
				{
					byte[] byte_ = smethod_1(string_0);
					GClass14 gclass14_ = gClass4.method_2(i, GEnum1.k_EFriendFlagImmediate);
					gClass4.method_3(gclass14_, GEnum0.k_EChatEntryTypeChatMsg, byte_);
				}
			}
		}
		catch
		{
		}
	}

	private static byte[] smethod_1(string string_0)
	{
		List<byte> list = new List<byte>(Encoding.UTF8.GetBytes(string_0));
		if (list.Count > 12286)
		{
			list.RemoveRange(12286, list.Count - 12286);
		}
		return list.ToArray();
	}
}
