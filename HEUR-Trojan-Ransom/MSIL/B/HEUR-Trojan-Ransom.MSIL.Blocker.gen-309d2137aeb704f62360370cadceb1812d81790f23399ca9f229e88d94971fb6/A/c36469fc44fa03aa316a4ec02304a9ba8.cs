using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class c36469fc44fa03aa316a4ec02304a9ba8
{
	internal static readonly byte[] c5699da6cff4aedcc02bab1c4aba70502;

	internal readonly int c06cacdbbf6735926c0c61767fa4f94e9;

	static c36469fc44fa03aa316a4ec02304a9ba8()
	{
		if (c5699da6cff4aedcc02bab1c4aba70502 != null)
		{
			return;
		}
		while (true)
		{
			switch (1)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = "cHR1bmEl";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			c5699da6cff4aedcc02bab1c4aba70502 = caaa9892e55af57ca7802d20b2cd5be85.c7e8eb5a938e48808a26d839d10c2ffcf(97L, manifestResourceStream);
			return;
		}
	}

	internal static int c8819246141186a91e5bb0791c9b67322(int P_0)
	{
		return BitConverter.ToInt32(c5699da6cff4aedcc02bab1c4aba70502, P_0);
	}

	internal static long c9ba417337ae1a66efe691f9a7c374e7e(int P_0)
	{
		return BitConverter.ToInt64(c5699da6cff4aedcc02bab1c4aba70502, P_0);
	}

	internal static float c34c32ac7ea95889a5137b4d86a334b85(int P_0)
	{
		return BitConverter.ToSingle(c5699da6cff4aedcc02bab1c4aba70502, P_0);
	}

	internal static double cd0cae36f8bba2281d83d2641c915d268(int P_0)
	{
		return BitConverter.ToDouble(c5699da6cff4aedcc02bab1c4aba70502, P_0);
	}

	internal static void ce0cb57eade935f6365d74ca942999ec4(Array P_0, int P_1)
	{
		int num = 0;
		if ((c5699da6cff4aedcc02bab1c4aba70502[P_1] & 0x80) == 0)
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
			num = c5699da6cff4aedcc02bab1c4aba70502[P_1];
			P_1++;
		}
		else if ((c5699da6cff4aedcc02bab1c4aba70502[P_1] & 0x40) == 0)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (c5699da6cff4aedcc02bab1c4aba70502[P_1] & -129) << 8;
			num |= c5699da6cff4aedcc02bab1c4aba70502[P_1 + 1];
			P_1 += 2;
		}
		else
		{
			num = (c5699da6cff4aedcc02bab1c4aba70502[P_1] & -193) << 24;
			num |= c5699da6cff4aedcc02bab1c4aba70502[P_1 + 1] << 16;
			num |= c5699da6cff4aedcc02bab1c4aba70502[P_1 + 2] << 8;
			num |= c5699da6cff4aedcc02bab1c4aba70502[P_1 + 3];
			P_1 += 4;
		}
		if (num >= 1)
		{
			Buffer.BlockCopy(c5699da6cff4aedcc02bab1c4aba70502, P_1, P_0, 0, num);
		}
	}
}
