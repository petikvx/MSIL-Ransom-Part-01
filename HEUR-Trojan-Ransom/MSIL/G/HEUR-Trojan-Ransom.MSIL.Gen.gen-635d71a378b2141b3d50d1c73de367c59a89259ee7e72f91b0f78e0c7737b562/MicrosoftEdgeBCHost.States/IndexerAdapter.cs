using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IndexerAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceFactory()
	{
	}
}
