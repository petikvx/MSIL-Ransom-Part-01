using System;

internal class CSIDL_SYSTEM : Attribute
{
	internal readonly int CurrencyDecimalDigits;

	internal CSIDL_SYSTEM(int P_0)
	{
		while (true)
		{
			int num = 164477401;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.ApplyRidMap(num)) % 3u)
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
				CurrencyDecimalDigits = ~(~(P_0 ^ -948923472));
				num = (int)(num2 * 2022071398) ^ -1053792270;
			}
		}
	}

	public override int M_transformMode()
	{
		return CurrencyDecimalDigits;
	}
}
