using System;

internal class _61a86fca : Attribute
{
	internal readonly int _079fd32a;

	internal _61a86fca(int P_0)
	{
		while (true)
		{
			int num = -1999301703;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E.fbc4b2c2(num)) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0027;
				case 1u:
					return;
				}
				break;
				IL_0027:
				_079fd32a = -(~(~(P_0 - (--938652823 - -2145265680)))) - -1002993022;
				num = (num2 * -433934088) ^ 0x31F5EE55;
			}
		}
	}

	public override int eb1a4ff0()
	{
		return _079fd32a;
	}
}
