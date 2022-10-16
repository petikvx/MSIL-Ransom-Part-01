using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExporterAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		CountLiteralContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountLiteralContext()
	{
	}
}
