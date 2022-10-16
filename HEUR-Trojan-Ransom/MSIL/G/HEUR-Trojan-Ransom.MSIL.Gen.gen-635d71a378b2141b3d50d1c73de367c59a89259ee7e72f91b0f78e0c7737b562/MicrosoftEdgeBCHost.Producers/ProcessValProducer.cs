using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcessValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveWrapper()
	{
	}
}
