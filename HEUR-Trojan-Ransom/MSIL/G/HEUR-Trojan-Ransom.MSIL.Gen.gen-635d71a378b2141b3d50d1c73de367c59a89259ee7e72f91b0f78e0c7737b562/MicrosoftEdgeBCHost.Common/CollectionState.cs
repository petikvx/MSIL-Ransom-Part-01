using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionState()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceIndexer()
	{
	}
}
