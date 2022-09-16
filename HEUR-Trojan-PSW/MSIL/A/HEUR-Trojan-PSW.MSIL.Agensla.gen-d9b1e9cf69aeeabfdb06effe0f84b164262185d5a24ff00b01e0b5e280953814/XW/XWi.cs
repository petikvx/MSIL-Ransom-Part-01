using System;

namespace XW;

public static class XWi
{
	internal static XWi KqN;

	public static string ci8(this bool bool_0)
	{
		return bool_0 ? "Yes" : "No";
	}

	public static int Rin(this DateTime dateTime_0)
	{
		DateTime dateTime_ = XyV.nJ(XyV.Jy6);
		int num = suA.nJ(ref dateTime_, suA.Uuv) - suA.nJ(ref dateTime_0, suA.Uuv);
		dateTime_ = XyV.nJ(XyV.Jy6);
		int num2 = 0;
		if (gqx() != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
		{
			bool num4 = suA.nJ(ref dateTime_, suA.QuH) < suA.nJ(ref dateTime_0, suA.QuH);
			dateTime_ = XyV.nJ(XyV.Jy6);
			int num5;
			if (suA.nJ(ref dateTime_, suA.QuH) == suA.nJ(ref dateTime_0, suA.QuH))
			{
				dateTime_ = XyV.nJ(XyV.Jy6);
				num5 = ((suA.nJ(ref dateTime_, suA.Uun) < suA.nJ(ref dateTime_0, suA.Uun)) ? 1 : 0);
			}
			else
			{
				num5 = 0;
			}
			if (((num4 ? 1u : 0u) | (uint)num5) != 0)
			{
				num--;
			}
			return num;
		}
		}
	}

	public static DateTime niX(this double double_0)
	{
		DateTime dateTime_;
		while (true)
		{
			dateTime_ = new DateTime(1970, 1, 1, 0, 0, 0, 0);
			if (gqx() == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		DateTime dateTime_2 = Ruo.nJ(ref dateTime_, Ruo.nue);
		return HuV.nJ(ref dateTime_2, XuE.nJ(double_0, XuE.Pus), HuV.Ku6);
	}

	public static double Rib(this DateTime dateTime_0)
	{
		DateTime dateTime_ = new DateTime(1970, 1, 1, 0, 0, 0, 0);
		DateTime dateTime_2 = Ruo.nJ(ref dateTime_, Ruo.nue);
		dateTime_ = Ruo.nJ(ref dateTime_0, Ruo.nue);
		if (gqx() != null)
		{
			switch (0)
			{
			}
		}
		TimeSpan timeSpan_ = cuF.nJ(ref dateTime_, dateTime_2, cuF.fuN);
		return XuE.nJ(ccM.nJ(ref timeSpan_, ccM.AuW), XuE.Pus);
	}

	public static string eic(this string string_0)
	{
		byte[] byte_ = uu8.nJ(NuU.nJ(NuU.iuj), string_0, uu8.xuT);
		return Yu5.nJ(byte_, Yu5.eul);
	}

	public static string dig(this byte[] byte_0)
	{
		return Yu5.nJ(byte_0, Yu5.eul);
	}

	internal static bool Aqa()
	{
		return KqN == null;
	}

	internal static XWi gqx()
	{
		return KqN;
	}
}
