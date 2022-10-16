using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class VisitorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceIterator()
	{
	}
}
