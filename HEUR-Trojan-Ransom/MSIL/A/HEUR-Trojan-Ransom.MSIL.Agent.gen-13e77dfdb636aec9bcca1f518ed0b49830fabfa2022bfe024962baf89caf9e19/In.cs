using System;

internal class In : Attribute
{
	internal readonly int M_firstChar;

	internal In(int P_0)
	{
		while (true)
		{
			int num = -793130586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.get_IsRuntime(num)) % 3u)
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
				M_firstChar = -(-(~(P_0 * -1572570109 + (-473597080 ^ 0x57ECB38F))));
				num = (int)(num2 * 767738696) ^ -749614914;
			}
		}
	}

	public override int Windows()
	{
		return M_firstChar;
	}
}
