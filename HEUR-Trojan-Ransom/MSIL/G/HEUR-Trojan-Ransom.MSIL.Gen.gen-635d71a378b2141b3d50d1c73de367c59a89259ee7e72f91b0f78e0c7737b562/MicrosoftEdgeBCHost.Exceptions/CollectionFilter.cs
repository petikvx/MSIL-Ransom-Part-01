using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CollectionFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionFilter()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareComposer()
	{
	}
}
