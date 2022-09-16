using System;
using ns4;
using ns6;

namespace P6eumo6ectomies;

public static class Pinfol7ing
{
	public static string Achroma7ism(this ILogMessage Decocte1)
	{
		if (Decocte1.Code > Thermogr5phers.Undefined && Decocte1.Code.U6raise(out var Coin0estors))
		{
			return $"{Coin0estors}: {Decocte1.Message}";
		}
		return Decocte1.Message;
	}

	public static string Swithe3ed(this Thermogr5phers Fat7tock)
	{
		return Enum.GetName(typeof(Thermogr5phers), Fat7tock);
	}

	public static bool U6raise(this Thermogr5phers thermogr5phers_0, out string Coin0estors)
	{
		Coin0estors = thermogr5phers_0.Swithe3ed();
		return Coin0estors != null;
	}
}
