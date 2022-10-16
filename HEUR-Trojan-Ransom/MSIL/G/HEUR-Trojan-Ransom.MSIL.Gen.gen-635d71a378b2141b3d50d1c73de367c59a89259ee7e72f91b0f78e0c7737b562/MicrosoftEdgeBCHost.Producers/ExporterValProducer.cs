using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExporterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CancelReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelReader()
	{
	}
}
