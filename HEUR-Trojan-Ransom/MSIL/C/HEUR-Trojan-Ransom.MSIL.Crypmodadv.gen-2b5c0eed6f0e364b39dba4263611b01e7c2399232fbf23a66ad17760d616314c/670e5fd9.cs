using System;

internal class _670e5fd9 : Attribute
{
	internal readonly int _3387e8c3;

	internal _670e5fd9(int P_0)
	{
		while (true)
		{
			int num = 25104711;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._17f49f33(num)) % 3u)
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
				_3387e8c3 = -(-(P_0 - (-1045173542 - -(~(-1508435934 + -514600294))))) - -193175177 - -1925230206;
				num = (num2 * 1078745119) ^ 0x413FA6C8;
			}
		}
	}

	public override int _13aefaf5()
	{
		return _3387e8c3;
	}
}
