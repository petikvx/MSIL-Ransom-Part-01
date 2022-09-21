using System;

internal class _5be341e5 : Attribute
{
	internal readonly int _312d0aa2;

	internal _5be341e5(int P_0)
	{
		while (true)
		{
			int num = -2139803097;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._4feab09d(num)) % 3u)
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
				_312d0aa2 = ((P_0 * -1110440609) ^ -1623181552) * 534756025 * -647830861 + -998909072;
				num = (num2 * -1133382575) ^ 0x1FDD9BDA;
			}
		}
	}

	public override int da7c82a0()
	{
		return _312d0aa2;
	}
}
