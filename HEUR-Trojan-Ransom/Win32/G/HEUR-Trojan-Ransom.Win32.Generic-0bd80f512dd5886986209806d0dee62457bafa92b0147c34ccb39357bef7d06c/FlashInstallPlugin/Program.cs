using System;
using System.Runtime.CompilerServices;

namespace FlashInstallPlugin;

internal static class Program
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	private static void Main()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Program()
	{
		_003CAgileDotNetRT_003E.Initialize();
		_003CAgileDotNetRT_003E.PostInitialize();
	}
}
