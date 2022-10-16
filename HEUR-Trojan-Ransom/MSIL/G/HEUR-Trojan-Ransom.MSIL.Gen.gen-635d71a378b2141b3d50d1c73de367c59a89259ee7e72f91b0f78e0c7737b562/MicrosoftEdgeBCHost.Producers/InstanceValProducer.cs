using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InstanceValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillIndexer()
	{
	}
}
