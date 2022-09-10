using System;
using System.IO;

namespace YDfIqHIitkNiPV;

internal class VyYBHhfMnUamB
{
	public static string yDsYXOHrNYTg(Stream rdiXSWPHzwEM, int QkxhTSIYDINDm)
	{
		byte[] array = new byte[QkxhTSIYDINDm];
		rdiXSWPHzwEM.Read(array, 0, QkxhTSIYDINDm);
		return UOsdaDuvXGt.mnPBSLcqfOV(array);
	}

	public static string daQXUttxCgjeD(Stream EtAmzCfuaGgaD)
	{
		return BdQmcwiaSZ((byte)EtAmzCfuaGgaD.ReadByte(), EtAmzCfuaGgaD);
	}

	public static string BdQmcwiaSZ(byte pKBkqGPsqwcb, Stream UtmZQlszzgZeZYf)
	{
		byte[] array = null;
		int num = 0;
		if (pKBkqGPsqwcb >= 160 && pKBkqGPsqwcb <= 191)
		{
			num = pKBkqGPsqwcb - 160;
		}
		else
		{
			switch (pKBkqGPsqwcb)
			{
			case 217:
				num = UtmZQlszzgZeZYf.ReadByte();
				break;
			case 218:
				array = new byte[2];
				UtmZQlszzgZeZYf.Read(array, 0, 2);
				array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
				num = BitConverter.ToUInt16(array, 0);
				break;
			case 219:
				array = new byte[4];
				UtmZQlszzgZeZYf.Read(array, 0, 4);
				array = UOsdaDuvXGt.ejlbQgoHCEAYu(array);
				num = BitConverter.ToInt32(array, 0);
				break;
			}
		}
		array = new byte[num];
		UtmZQlszzgZeZYf.Read(array, 0, num);
		return UOsdaDuvXGt.mnPBSLcqfOV(array);
	}
}
