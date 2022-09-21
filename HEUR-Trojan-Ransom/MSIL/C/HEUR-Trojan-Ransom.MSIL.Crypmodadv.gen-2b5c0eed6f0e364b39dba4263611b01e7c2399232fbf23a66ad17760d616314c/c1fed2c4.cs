using System;

internal class c1fed2c4 : Attribute
{
	internal readonly int _315c029e;

	internal c1fed2c4(int P_0)
	{
		while (true)
		{
			int num = -481501124;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E.f2aad42f(num)) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0027;
				case 2u:
					return;
				}
				break;
				IL_0027:
				_315c029e = (~(-P_0) - 2017365957 * 275471643) ^ 0x4FF168B8 ^ 0x1C8BA08A;
				num = (num2 * 157964064) ^ 0xCC1FE38;
			}
		}
	}

	public override int _91aaeb91()
	{
		return _315c029e;
	}
}
