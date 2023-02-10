using System;

internal class ReadTypeRefRow : Attribute
{
	internal readonly int M_assembly;

	internal ReadTypeRefRow(int P_0)
	{
		while (true)
		{
			int data = -298342192;
			while (true)
			{
				uint num;
				switch ((num = (uint)_003CModule_003E.SetData(data)) % 3u)
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
				M_assembly = 1026768471 - (~(-P_0 + (-473657012 ^ 0x7190BF2C)) ^ 0x1EB7FA3B);
				data = (int)(num * 2038924862) ^ -1921850201;
			}
		}
	}

	public override int OwnClipboard()
	{
		return M_assembly;
	}
}
