using System;

internal class S_InternalSyncObject : Attribute
{
	internal readonly int ICustomFormatter;

	internal S_InternalSyncObject(int P_0)
	{
		while (true)
		{
			int num = 1940869407;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.S_GPROC16(num)) % 3u)
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
				ICustomFormatter = ~(-((P_0 * -2039311371 - ~(--28386638)) * 2030682775));
				num = (int)(num2 * 186478993) ^ -302030510;
			}
		}
	}

	public override int Get_HasDefault()
	{
		return ICustomFormatter;
	}
}
