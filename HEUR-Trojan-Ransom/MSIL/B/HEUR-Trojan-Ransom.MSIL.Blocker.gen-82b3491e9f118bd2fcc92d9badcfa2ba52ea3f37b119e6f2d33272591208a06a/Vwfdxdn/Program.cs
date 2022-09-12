using System;

namespace Vwfdxdn;

internal class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		TwitchApi.Donate();
		TwitchApi.Chat();
		TwitchApi.Reply();
	}
}
