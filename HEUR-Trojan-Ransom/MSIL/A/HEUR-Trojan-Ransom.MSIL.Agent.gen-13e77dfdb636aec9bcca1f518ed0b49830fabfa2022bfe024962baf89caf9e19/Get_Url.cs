using System;

internal class Get_Url : Attribute
{
	internal readonly int GetFinallyEndAddress;

	internal Get_Url(int P_0)
	{
		while (true)
		{
			int num = -643640352;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)_003CModule_003E.FileInfo(num)) % 3u)
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
				GetFinallyEndAddress = (~((P_0 ^ -839874734) - -(~(114241628 + -1751631978))) ^ 0x512864C9) - 362050889;
				num = (int)((num2 * 120829472) ^ 0x4E6DAA4B);
			}
		}
	}

	public override int Set_Root()
	{
		return GetFinallyEndAddress;
	}
}
