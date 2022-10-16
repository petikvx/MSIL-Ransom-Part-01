using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrinterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterRules()
	{
		WriterPropertyProducer.ResolveStub();
		CreateListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateListener()
	{
	}
}
