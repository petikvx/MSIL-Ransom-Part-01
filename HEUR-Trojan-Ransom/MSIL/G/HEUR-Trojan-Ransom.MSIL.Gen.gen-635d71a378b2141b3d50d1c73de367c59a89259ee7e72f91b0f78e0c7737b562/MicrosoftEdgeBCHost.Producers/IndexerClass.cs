using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IndexerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerClass()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceObserver()
	{
	}
}
