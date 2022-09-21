using System;

internal class _74811fba : Attribute
{
	internal readonly int _5d086b58;

	internal _74811fba(int P_0)
	{
		while (true)
		{
			int num = 82631540;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E.f694e34a(num)) % 3u)
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
				_5d086b58 = (((-P_0 ^ ~(-(~382241698))) + -(0x53F3B58C ^ -1011976556)) ^ --27172369) - -741651112;
				num = (num2 * -1621890956) ^ 0x26DF17C4;
			}
		}
	}

	public override int _39f5280e()
	{
		return _5d086b58;
	}
}
