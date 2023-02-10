using System;

internal class _003CSortTables_003Eb__191_4 : Attribute
{
	internal readonly int IMemberForwarded;

	internal _003CSortTables_003Eb__191_4(int P_0)
	{
		while (true)
		{
			int num = -1539194788;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.CompareDeclaringTypes(num)) % 3u)
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
				IMemberForwarded = (((P_0 - -681327417 * ~(~-1359743742)) ^ -297964107 ^ 0x2916D369) * 783116185) ^ -1073106344;
				num = (int)(num2 * 905278156) ^ -1865561888;
			}
		}
	}

	public override int GetTableReader()
	{
		return IMemberForwarded;
	}
}
