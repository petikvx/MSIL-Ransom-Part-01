using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ServiceFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceFilter()
	{
		WriterPropertyProducer.ResolveStub();
		CollectIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectIterator()
	{
	}
}
