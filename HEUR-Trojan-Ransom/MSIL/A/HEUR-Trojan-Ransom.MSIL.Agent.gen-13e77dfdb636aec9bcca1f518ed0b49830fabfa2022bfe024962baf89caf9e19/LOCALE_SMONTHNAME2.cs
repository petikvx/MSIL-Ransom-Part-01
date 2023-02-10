using System;

internal class LOCALE_SMONTHNAME2 : Attribute
{
	internal readonly int StrFileName;

	internal LOCALE_SMONTHNAME2(int P_0)
	{
		while (true)
		{
			int num = 946577922;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.TryLookingForSatellite(num)) % 3u)
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
				StrFileName = (~(~(-P_0)) - -1715437419 * -323091494) * -1390815121;
				num = (int)((num2 * 825023418) ^ 0xCBE7220);
			}
		}
	}

	public override int IContainsGenericParameter()
	{
		return StrFileName;
	}
}
