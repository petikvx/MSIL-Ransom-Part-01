using System;

internal class Get_IsCorLibType : Attribute
{
	internal readonly int Get_PreserveEventRids;

	internal Get_IsCorLibType(int P_0)
	{
		while (true)
		{
			int num = -63089104;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.Get_Major(num)) % 3u)
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
				Get_PreserveEventRids = ((P_0 ^ (~(--1294291521) * -961751989 + (0x5E6C14E1 ^ 0x2CBF77C2))) * 2099612333 * 1895087689) ^ 0x4E264EF6 ^ 0x1D825191;
				num = (int)(num2 * 176536947) ^ -1955924752;
			}
		}
	}

	public override int GetLocalSignature()
	{
		return Get_PreserveEventRids;
	}
}
