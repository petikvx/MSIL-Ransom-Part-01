using System;
using System.IO;

namespace yKFnPcLKLkIvyuyev;

internal class OqorelcqEXXMs
{
	public static string BekNPmXkceiLSQ(Stream gTUQizimNbBi, int dTzlgyFqwIXYkQ)
	{
		byte[] array = new byte[dTzlgyFqwIXYkQ];
		gTUQizimNbBi.Read(array, 0, dTzlgyFqwIXYkQ);
		return ArcLSVHldVsl.PFWhtCpPVFEsAaJ(array);
	}

	public static string DqGyjaPViSShn(Stream xlktAnZXmOiM)
	{
		return GBcBiSiAjhsWaeC((byte)xlktAnZXmOiM.ReadByte(), xlktAnZXmOiM);
	}

	public static string GBcBiSiAjhsWaeC(byte stSSRlaDYUbWV, Stream UnDqJhbViyObZ)
	{
		byte[] array = null;
		int num = 0;
		if (stSSRlaDYUbWV >= 160 && stSSRlaDYUbWV <= 191)
		{
			num = stSSRlaDYUbWV - 160;
		}
		else
		{
			switch (stSSRlaDYUbWV)
			{
			case 217:
				num = UnDqJhbViyObZ.ReadByte();
				break;
			case 218:
				array = new byte[2];
				UnDqJhbViyObZ.Read(array, 0, 2);
				array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
				num = BitConverter.ToUInt16(array, 0);
				break;
			case 219:
				array = new byte[4];
				UnDqJhbViyObZ.Read(array, 0, 4);
				array = ArcLSVHldVsl.TvlDPJoCjMDCsQh(array);
				num = BitConverter.ToInt32(array, 0);
				break;
			}
		}
		array = new byte[num];
		UnDqJhbViyObZ.Read(array, 0, num);
		return ArcLSVHldVsl.PFWhtCpPVFEsAaJ(array);
	}
}
