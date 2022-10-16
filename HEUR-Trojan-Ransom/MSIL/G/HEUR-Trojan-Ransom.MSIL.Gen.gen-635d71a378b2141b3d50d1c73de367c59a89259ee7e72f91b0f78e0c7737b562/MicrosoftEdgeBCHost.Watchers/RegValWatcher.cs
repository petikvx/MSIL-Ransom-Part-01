using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfacePrinter()
	{
	}
}
