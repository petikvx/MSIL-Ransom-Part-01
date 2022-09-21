internal class _0603ac9f
{
	internal static string _423c3aa2(string P_0, int P_1)
	{
		char[] array = default(char[]);
		string text = default(string);
		int num3 = default(int);
		string result = default(string);
		while (true)
		{
			int num = -1080543046;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._18ac1150(num)) % 8u)
				{
				case 3u:
					break;
				case 6u:
					string.Intern(P_0);
					num = (num2 * 401175743) ^ 0x2DDC3047;
					continue;
				case 7u:
					array = P_0.ToCharArray();
					num = (num2 * -1761091609) ^ -813208126;
					continue;
				case 1u:
					text = num3.ToString();
					num = (num2 * -1004272857) ^ -290087909;
					continue;
				case 5u:
					num3 = 5;
					num = (num2 * -1900402788) ^ -1694629197;
					continue;
				case 4u:
					num = (num2 * 2027992043) ^ -1681931486;
					continue;
				case 0u:
					result = string.Concat((object?)text, (object?)array);
					num = (num2 * -1469925440) ^ 0x55433110;
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal _0603ac9f()
	{
		while (true)
		{
			int num = -1276261156;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._18ac1150(num)) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0027;
				case 0u:
					return;
				}
				break;
				IL_0027:
				num = (num2 * -558116684) ^ 0x506E1ADA;
			}
		}
	}
}
