[GAttribute0]
public static class GClass35
{
	[GAttribute0]
	public static bool smethod_0(string string_0, char char_0)
	{
		bool flag = string.IsNullOrEmpty(string_0);
		bool result = default(bool);
		while (true)
		{
			int num = -1072045499;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B338276u) % 5u)
				{
				case 4u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -215595366;
						num4 = -215595366;
					}
					else
					{
						num3 = -1486137544;
						num4 = -1486137544;
					}
					num = num3 ^ ((int)num2 * -1446996717);
					continue;
				}
				case 2u:
					result = false;
					num = (int)(num2 * 971573895) ^ -1523953285;
					continue;
				case 0u:
					result = string_0[string_0.Length - 1] == char_0;
					num = -1367519496;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
