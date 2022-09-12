using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class c55ffa6db73375a0be5fddb47b9f55e41
{
	internal static readonly byte[] c6b172017c22567c2d0484ee95cecda30;

	internal readonly int cb8b941afaa58981f3de624ae435ab880;

	static c55ffa6db73375a0be5fddb47b9f55e41()
	{
		if (c6b172017c22567c2d0484ee95cecda30 != null)
		{
			return;
		}
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = "SHVsdSU=";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			c6b172017c22567c2d0484ee95cecda30 = c14f4fdfe28b860a849e4380de9b9f125.cb9b84783b9c89d6d4ffab0fe79627c3a(97L, manifestResourceStream);
			return;
		}
	}

	internal static int c366fc34c2d0f681f276686895b372a83(int ccb2d27bc90b51eeaaf08a83e671d03ca)
	{
		return BitConverter.ToInt32(c6b172017c22567c2d0484ee95cecda30, ccb2d27bc90b51eeaaf08a83e671d03ca);
	}

	internal static long cf7080d127cf2d0f7892df657d9d7dbac(int ccb2d27bc90b51eeaaf08a83e671d03ca)
	{
		return BitConverter.ToInt64(c6b172017c22567c2d0484ee95cecda30, ccb2d27bc90b51eeaaf08a83e671d03ca);
	}

	internal static float c63114f8f3101f35844b1307aba00b65b(int ccb2d27bc90b51eeaaf08a83e671d03ca)
	{
		return BitConverter.ToSingle(c6b172017c22567c2d0484ee95cecda30, ccb2d27bc90b51eeaaf08a83e671d03ca);
	}

	internal static double c39d91937b4337bf36c6cc7f9b5b7a576(int ccb2d27bc90b51eeaaf08a83e671d03ca)
	{
		return BitConverter.ToDouble(c6b172017c22567c2d0484ee95cecda30, ccb2d27bc90b51eeaaf08a83e671d03ca);
	}

	internal static void c6a68ebf8d08093104a77f7afb0831c92(Array c7d2461c0459437d75ae1ee360592e4be, int ccb2d27bc90b51eeaaf08a83e671d03ca)
	{
		int num = 0;
		if ((c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca] & 0x80) == 0)
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
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca];
			ccb2d27bc90b51eeaaf08a83e671d03ca++;
		}
		else if ((c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca] & 0x40) == 0)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca] & -129) << 8;
			num |= c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca + 1];
			ccb2d27bc90b51eeaaf08a83e671d03ca += 2;
		}
		else
		{
			num = (c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca] & -193) << 24;
			num |= c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca + 1] << 16;
			num |= c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca + 2] << 8;
			num |= c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca + 3];
			ccb2d27bc90b51eeaaf08a83e671d03ca += 4;
		}
		if (num >= 1)
		{
			Buffer.BlockCopy(c6b172017c22567c2d0484ee95cecda30, ccb2d27bc90b51eeaaf08a83e671d03ca, c7d2461c0459437d75ae1ee360592e4be, 0, num);
		}
	}
}
