using System;
using System.IO;

namespace lbBmsCGqmaavDk;

internal class bTiTWyAenDMH
{
	public static string LoKvyIJCiPf(Stream PLkUEdpFGPtjZHb, int NCywwFCRbgEmha)
	{
		byte[] array = new byte[NCywwFCRbgEmha];
		PLkUEdpFGPtjZHb.Read(array, 0, NCywwFCRbgEmha);
		return mvCuPdYBvDWOQ.AEglAAlFkYZ(array);
	}

	public static string rEGQVSRugryb(Stream fgpGTAPjbSiCi)
	{
		return ucjpLLiFSigfJY((byte)fgpGTAPjbSiCi.ReadByte(), fgpGTAPjbSiCi);
	}

	public static string ucjpLLiFSigfJY(byte mfjfsJYJGUM, Stream qCmCFdjThJeuhr)
	{
		byte[] array = null;
		int num = 0;
		if (mfjfsJYJGUM >= 160 && mfjfsJYJGUM <= 191)
		{
			num = mfjfsJYJGUM - 160;
		}
		else
		{
			switch (mfjfsJYJGUM)
			{
			case 217:
				num = qCmCFdjThJeuhr.ReadByte();
				break;
			case 218:
				array = new byte[2];
				qCmCFdjThJeuhr.Read(array, 0, 2);
				array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
				num = BitConverter.ToUInt16(array, 0);
				break;
			case 219:
				array = new byte[4];
				qCmCFdjThJeuhr.Read(array, 0, 4);
				array = mvCuPdYBvDWOQ.pzfCndFTSze(array);
				num = BitConverter.ToInt32(array, 0);
				break;
			}
		}
		array = new byte[num];
		qCmCFdjThJeuhr.Read(array, 0, num);
		return mvCuPdYBvDWOQ.AEglAAlFkYZ(array);
	}
}
