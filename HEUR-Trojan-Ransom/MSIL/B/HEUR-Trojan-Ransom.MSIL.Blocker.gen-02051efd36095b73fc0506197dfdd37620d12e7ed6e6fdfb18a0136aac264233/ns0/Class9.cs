using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ns0;

internal class Class9
{
	internal static readonly byte[] byte_0;

	internal readonly int int_0;

	internal readonly int int_1;

	static Class9()
	{
		if (byte_0 == null)
		{
			string s = "Qnl0ZWxvY2tlciU=";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			byte_0 = Class13.smethod_3(97L, manifestResourceStream);
		}
	}

	internal static int smethod_0(int int_2)
	{
		return BitConverter.ToInt32(byte_0, int_2);
	}

	internal static long smethod_1(int int_2)
	{
		return BitConverter.ToInt64(byte_0, int_2);
	}

	internal static float smethod_2(int int_2)
	{
		return BitConverter.ToSingle(byte_0, int_2);
	}

	internal static double smethod_3(int int_2)
	{
		return BitConverter.ToDouble(byte_0, int_2);
	}

	internal static void smethod_4(Array array_0, int int_2)
	{
		int num = 0;
		if ((byte_0[int_2] & 0x80) == 0)
		{
			num = byte_0[int_2];
			int_2++;
		}
		else if ((byte_0[int_2] & 0x40) == 0)
		{
			num = (byte_0[int_2] & -129) << 8;
			num |= byte_0[int_2 + 1];
			int_2 += 2;
		}
		else
		{
			num = (byte_0[int_2] & -193) << 24;
			num |= byte_0[int_2 + 1] << 16;
			num |= byte_0[int_2 + 2] << 8;
			num |= byte_0[int_2 + 3];
			int_2 += 4;
		}
		if (num >= 1)
		{
			Buffer.BlockCopy(byte_0, int_2, array_0, 0, num);
		}
	}
}
