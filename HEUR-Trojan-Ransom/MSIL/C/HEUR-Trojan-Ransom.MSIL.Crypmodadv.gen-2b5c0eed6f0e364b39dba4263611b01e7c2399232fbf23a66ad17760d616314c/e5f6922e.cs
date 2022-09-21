using System;

internal class e5f6922e : Attribute
{
	internal readonly int _474c4a98;

	internal e5f6922e(int P_0)
	{
		while (true)
		{
			int num = 764333432;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E.e7c8d636(num)) % 3u)
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
				_474c4a98 = ~((P_0 ^ (-(-1241444711 * 1102856559) - -(708288976 + 103187187) + -(-(1984231028 + -669772264)))) * 838456981) + ~-1174041491;
				num = (num2 * -1289987556) ^ -779460767;
			}
		}
	}

	public override int _1fc2bc80()
	{
		return _474c4a98;
	}
}
