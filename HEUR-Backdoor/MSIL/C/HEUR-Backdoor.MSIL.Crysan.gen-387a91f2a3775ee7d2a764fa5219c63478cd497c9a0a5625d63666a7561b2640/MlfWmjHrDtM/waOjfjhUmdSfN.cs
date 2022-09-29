using System;
using System.IO;

namespace MlfWmjHrDtM;

internal class waOjfjhUmdSfN
{
	public static string joAfDBMieauNbx(Stream HRlAypsikSvdI, int omdalPpSCWVH)
	{
		byte[] array = new byte[omdalPpSCWVH];
		HRlAypsikSvdI.Read(array, 0, omdalPpSCWVH);
		return HtHLMJnLldFHH.vivdgVWoHAoNdsL(array);
	}

	public static string PkpHmfkwViUif(Stream uRwuklYQXktX)
	{
		return IEQkeHssluYG((byte)uRwuklYQXktX.ReadByte(), uRwuklYQXktX);
	}

	public static string IEQkeHssluYG(byte fCOcgVvfkaFs, Stream SGbPgzyrzLULE)
	{
		byte[] array = null;
		int num = 0;
		if (fCOcgVvfkaFs >= 160 && fCOcgVvfkaFs <= 191)
		{
			num = fCOcgVvfkaFs - 160;
		}
		else
		{
			switch (fCOcgVvfkaFs)
			{
			case 217:
				num = SGbPgzyrzLULE.ReadByte();
				break;
			case 218:
				array = new byte[2];
				SGbPgzyrzLULE.Read(array, 0, 2);
				array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
				num = BitConverter.ToUInt16(array, 0);
				break;
			case 219:
				array = new byte[4];
				SGbPgzyrzLULE.Read(array, 0, 4);
				array = HtHLMJnLldFHH.eVeGzxKKqtkG(array);
				num = BitConverter.ToInt32(array, 0);
				break;
			}
		}
		array = new byte[num];
		SGbPgzyrzLULE.Read(array, 0, num);
		return HtHLMJnLldFHH.vivdgVWoHAoNdsL(array);
	}
}
