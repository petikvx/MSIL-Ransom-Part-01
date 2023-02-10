using System;

internal class GetHandleValue : Attribute
{
	internal readonly int InternalRegisterWithoutEC;

	internal GetHandleValue(int P_0)
	{
		while (true)
		{
			int num = 1744326902;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.EnumEventsCount(num)) % 3u)
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
				InternalRegisterWithoutEC = -1125357685 - (P_0 - (-(--1141345664) ^ -(~-1748139093) ^ 0x1005D7FC) - (-1477342069 ^ 0x5DCD10FC)) * -2060589799 * 1432792705;
				num = ((int)num2 * -466555087) ^ 0x2C5B93C3;
			}
		}
	}

	public override int ReadStandAloneSigRow2()
	{
		return InternalRegisterWithoutEC;
	}
}
