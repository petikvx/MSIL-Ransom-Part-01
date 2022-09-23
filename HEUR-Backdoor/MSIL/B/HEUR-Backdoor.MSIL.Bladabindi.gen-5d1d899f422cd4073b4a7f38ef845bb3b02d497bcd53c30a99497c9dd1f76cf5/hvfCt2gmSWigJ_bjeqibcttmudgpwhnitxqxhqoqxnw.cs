using System;
using System.IO;
using rgA69G;

internal class hvfCt2gmSWigJ_bjeqibcttmudgpwhnitxqxhqoqxnw
{
	public static string PsYjkc_a(Stream a, int b)
	{
		byte[] array = new byte[b];
		a.Read(array, 0, b);
		return V7qSaHaL8shx.bHb9i0UJW0(array);
	}

	public static string PsYjkc_b(Stream a)
	{
		return PsYjkc_c((byte)a.ReadByte(), a);
	}

	public static string PsYjkc_c(byte a, Stream b)
	{
		DateTime dateTime = new DateTime(2021, 7, 20, 12, 19, 22);
		if ((dateTime - DateTime.Now).TotalDays >= 0.0)
		{
		}
		byte[] array = null;
		int num = 0;
		if (a >= 160 && a <= 191)
		{
			num = a - 160;
		}
		else
		{
			switch (a)
			{
			case 217:
				num = b.ReadByte();
				break;
			case 218:
				array = new byte[2];
				b.Read(array, 0, 2);
				array = V7qSaHaL8shx.aduO6vFYO(array);
				num = BitConverter.ToUInt16(array, 0);
				break;
			case 219:
				array = new byte[4];
				b.Read(array, 0, 4);
				array = V7qSaHaL8shx.aduO6vFYO(array);
				num = BitConverter.ToInt32(array, 0);
				break;
			}
		}
		array = new byte[num];
		b.Read(array, 0, num);
		return V7qSaHaL8shx.bHb9i0UJW0(array);
	}
}
