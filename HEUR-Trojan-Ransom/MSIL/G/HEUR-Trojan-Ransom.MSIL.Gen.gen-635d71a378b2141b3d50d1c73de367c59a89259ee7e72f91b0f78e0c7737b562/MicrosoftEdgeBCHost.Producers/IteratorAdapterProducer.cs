using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IteratorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralPrinter()
	{
	}
}
