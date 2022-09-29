using System;
using System.Reflection;

public class GClass8
{
	private object object_0;

	public GClass8(long long_0)
	{
		object[] array = new object[2] { this, long_0 };
		new GClass22().method_112(array, 1551464);
	}

	private void method_0(ref byte[] byte_0, uint uint_0)
	{
		uint num = 2051954097u;
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			num = 0x113856B4u ^ num;
			IntPtr intPtr = (nint)byte_0.LongLength;
			num = 1155792963u / num;
			if (num3 < (int)(nint)intPtr)
			{
				num = 534976684u;
				num = 90198u;
				byte[] obj = byte_0;
				int num4 = num2;
				byte[] obj2 = byte_0;
				int num5 = num2;
				num = 3264096820u;
				long num6 = obj2[num5];
				num = 6225u;
				long num7 = GClass13.smethod_0(uint_0, num2);
				num = 3644507888u;
				obj[num4] = (byte)(num6 ^ (num7 + num2));
				num = 2466620675u;
				int num8 = num2;
				num = 18818u;
				int num9 = num8 + 1;
				num = 1623083458u;
				num2 = num9;
				num = 2051954097u;
			}
			else if ((0x7DBB48D6u ^ num) != 0)
			{
				break;
			}
		}
	}

	private Assembly method_1(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		object[] array = new object[3] { this, object_1, resolveEventArgs_0 };
		return (Assembly)new GClass22().method_112(array, 689021);
	}
}
