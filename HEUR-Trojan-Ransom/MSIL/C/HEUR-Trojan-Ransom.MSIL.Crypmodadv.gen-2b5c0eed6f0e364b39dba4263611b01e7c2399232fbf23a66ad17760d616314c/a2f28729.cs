using System;

internal class a2f28729 : Attribute
{
	internal readonly int e8a3c81f;

	internal a2f28729(int P_0)
	{
		while (true)
		{
			int num = 615075138;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E.b00154eb(num)) % 3u)
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
				e8a3c81f = -1356623371 - -(P_0 ^ -(-1559339373 * (1874193031 * 527791789 - (-584612219 - -612473088)))) * 329382629 * -657283017;
				num = (num2 * 1075846638) ^ 0x3A7C789B;
			}
		}
	}

	public override int d8f4814b()
	{
		return e8a3c81f;
	}
}
