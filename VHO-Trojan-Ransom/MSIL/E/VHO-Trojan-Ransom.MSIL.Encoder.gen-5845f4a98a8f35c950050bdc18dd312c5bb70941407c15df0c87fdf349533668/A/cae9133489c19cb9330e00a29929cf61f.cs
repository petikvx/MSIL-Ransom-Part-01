using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class cae9133489c19cb9330e00a29929cf61f
{
	internal static readonly byte[] c6b172017c22567c2d0484ee95cecda30;

	static cae9133489c19cb9330e00a29929cf61f()
	{
		if (c6b172017c22567c2d0484ee95cecda30 == null)
		{
			string s = "SHVsdSQ=";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			c6b172017c22567c2d0484ee95cecda30 = c14f4fdfe28b860a849e4380de9b9f125.cb9b84783b9c89d6d4ffab0fe79627c3a(97L, manifestResourceStream);
		}
	}

	internal static string c0a9b4096f8bd5ee628bdaf8f596f912d(int ccb2d27bc90b51eeaaf08a83e671d03ca)
	{
		int num = 0;
		if ((c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca] & 0x80) == 0)
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
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca];
			ccb2d27bc90b51eeaaf08a83e671d03ca++;
		}
		else if ((c6b172017c22567c2d0484ee95cecda30[ccb2d27bc90b51eeaaf08a83e671d03ca] & 0x40) == 0)
		{
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
		if (num < 1)
		{
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
					return string.Empty;
				}
			}
		}
		string @string = Encoding.Unicode.GetString(c6b172017c22567c2d0484ee95cecda30, ccb2d27bc90b51eeaaf08a83e671d03ca, num);
		return string.Intern(@string);
	}
}
