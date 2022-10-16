using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IteratorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceList()
	{
	}
}
