using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrinterOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeRule()
	{
	}
}
