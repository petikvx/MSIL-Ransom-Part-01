using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class c16ad50f4b29ac1c5019262c0eb124cff
{
	internal static readonly byte[] cdc826402e29d5c48e3b5167fcf8dfcd7;

	internal readonly int c51bd1276ca8af9049cdfa06cc2d6717f;

	static c16ad50f4b29ac1c5019262c0eb124cff()
	{
		if (cdc826402e29d5c48e3b5167fcf8dfcd7 != null)
		{
			return;
		}
		while (true)
		{
			switch (5)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = "SmF2YSBVcGRhdGVyJQ==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			cdc826402e29d5c48e3b5167fcf8dfcd7 = cad9a15757977f5874eabf13acd31ea9a.c74478c8008c8c6dbef9395462fb1ed67(97L, manifestResourceStream);
			return;
		}
	}

	internal static int c2f3402b6706c0f4b54840e551c0b6599(int c203d851120dc885701ad7b6c06cb2316)
	{
		return BitConverter.ToInt32(cdc826402e29d5c48e3b5167fcf8dfcd7, c203d851120dc885701ad7b6c06cb2316);
	}

	internal static long c669ac6f5f3f32dbdcc52c4e3177d0937(int c203d851120dc885701ad7b6c06cb2316)
	{
		return BitConverter.ToInt64(cdc826402e29d5c48e3b5167fcf8dfcd7, c203d851120dc885701ad7b6c06cb2316);
	}

	internal static float c638a4c701af76037671bf33ccc3333c3(int c203d851120dc885701ad7b6c06cb2316)
	{
		return BitConverter.ToSingle(cdc826402e29d5c48e3b5167fcf8dfcd7, c203d851120dc885701ad7b6c06cb2316);
	}

	internal static double ca0925cf1250e975728350123433b41ee(int c203d851120dc885701ad7b6c06cb2316)
	{
		return BitConverter.ToDouble(cdc826402e29d5c48e3b5167fcf8dfcd7, c203d851120dc885701ad7b6c06cb2316);
	}

	internal static void c644fc7062ba99416eddf3803df11004d(Array c83e778a7f49fafd553a4560e4763856e, int c203d851120dc885701ad7b6c06cb2316)
	{
		int num = 0;
		if ((cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316] & 0x80) == 0)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316];
			c203d851120dc885701ad7b6c06cb2316++;
		}
		else if ((cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316] & 0x40) == 0)
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316] & -129) << 8;
			num |= cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316 + 1];
			c203d851120dc885701ad7b6c06cb2316 += 2;
		}
		else
		{
			num = (cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316] & -193) << 24;
			num |= cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316 + 1] << 16;
			num |= cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316 + 2] << 8;
			num |= cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316 + 3];
			c203d851120dc885701ad7b6c06cb2316 += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}
		Buffer.BlockCopy(cdc826402e29d5c48e3b5167fcf8dfcd7, c203d851120dc885701ad7b6c06cb2316, c83e778a7f49fafd553a4560e4763856e, 0, num);
	}
}
