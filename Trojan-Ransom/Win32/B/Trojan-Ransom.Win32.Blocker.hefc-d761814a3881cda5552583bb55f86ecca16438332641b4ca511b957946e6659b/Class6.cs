using System;
using System.Globalization;
using System.IO;
using System.Management;

internal class Class6
{
	public struct Struct0
	{
		public string string_0;

		public string string_1;

		public string string_2;

		public int int_0;

		public string string_3;
	}

	public static Struct0 smethod_0()
	{
		Struct0 result = default(Struct0);
		CultureInfo installedUICulture = CultureInfo.InstalledUICulture;
		result.string_3 = Environment.MachineName;
		result.string_0 = smethod_3();
		result.string_1 = installedUICulture.EnglishName;
		result.string_2 = smethod_2(GClass0.smethod_0("B"));
		result.int_0 = 1;
		return result;
	}

	private static string smethod_1()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		string text = GClass0.smethod_0("");
		ManagementObjectCollection instances = new ManagementClass(GClass0.smethod_0("xŧɣ\u033fйՕٹݺࡨ॥\u0a60୷\u0c70൭\u0e73")).GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				_ = (ManagementObject)enumerator.get_Current();
				if (text == GClass0.smethod_0(""))
				{
					break;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return GClass0.smethod_0("Sœɓ\u0345шՅوݜࡀ\u094f\u0a4e\u0b55\u0c40൏โཏ၅ᅆ");
	}

	private static string smethod_2(string string_0)
	{
		if (string_0 == string.Empty)
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					string_0 = driveInfo.RootDirectory.ToString();
					break;
				}
			}
		}
		if (string_0.EndsWith(GClass0.smethod_0("8ŝ")))
		{
			string_0 = string_0.Substring(0, string_0.Length - 2);
		}
		string text = smethod_4(string_0);
		string text2 = smethod_1();
		return text2.Substring(13) + text2.Substring(1, 4) + text + text2.Substring(4, 4);
	}

	private static string smethod_3()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = GClass0.smethod_0("");
		if (oSVersion.Platform == PlatformID.Win32Windows)
		{
			if (oSVersion.Version.Minor == 10)
			{
				text = GClass0.smethod_0("]Šɦ\u0363ѩղٷܣ࠻ह");
			}
			if (oSVersion.Version.Minor == 90)
			{
				text = GClass0.smethod_0("]Šɦ\u0363ѩղٷܣࡏ।");
			}
		}
		if (oSVersion.Platform == PlatformID.Win32NT)
		{
			if (oSVersion.Version.Major == 4)
			{
				text = GClass0.smethod_0("YŤɢ\u036fѥվٻܧࡈ\u0951ਤଷబറ");
			}
			if (oSVersion.Version.Major == 5)
			{
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = GClass0.smethod_0("[Ţɤ\u036dѧհٵܥ࠶ळਲ\u0b31");
					break;
				case 1:
					text = GClass0.smethod_0("]Šɦ\u0363ѩղٷܣ\u085a\u0951");
					break;
				case 2:
					text = GClass0.smethod_0("DŻɿʹѠչپܬࡘ९\u0a7b\u0b7e\u0c62൴ล༶\u1033ᄲሲ");
					break;
				}
			}
			if (oSVersion.Version.Major == 6 && oSVersion.Version.Minor == 0)
			{
				text = GClass0.smethod_0("Zťɥ\u036eѦտٴܦࡓ७\u0a70୶ౠ");
			}
		}
		if (text == GClass0.smethod_0(""))
		{
			text = GClass0.smethod_0("OŷɺͲѽմٺݽࡦॴਰ\u0b58౧\u0d63\u0e68ཤၽᅺሥፑᑣᕷᙷᝪᡭ\u196f");
		}
		return text;
	}

	private static string smethod_4(string string_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		ManagementObject val = new ManagementObject(GClass0.smethod_0("kŲɴ\u032aЪՈٺݺ\u0873ॺ\u0a71୰౼൫\u0e67\u0f7e\u1067ᄥቮ፬ᑾᕮᙥᝠᡭᥧᨿᬣ") + string_0 + GClass0.smethod_0("8ģ"));
		val.Get();
		string result = ((ManagementBaseObject)val).get_Item(GClass0.smethod_0("Džɼͺѣը\u065fݮ\u0878ॠ੩୫\u0c48൰\u0e69ཡ\u1067ᅳ")).ToString();
		val.Dispose();
		return result;
	}
}
