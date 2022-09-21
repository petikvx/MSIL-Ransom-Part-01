using System;

internal class _7a426dff : Attribute
{
	internal readonly int dc094bc0;

	internal _7a426dff(int P_0)
	{
		while (true)
		{
			int num = -227604846;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._416032a1(num)) % 3u)
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
				dc094bc0 = (~(~(-P_0)) - ~-173525473) ^ -513221651;
				num = (num2 * 1027663476) ^ -1815947108;
			}
		}
	}

	public override int d93266f0()
	{
		return dc094bc0;
	}
}
