using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IndexerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateClass()
	{
	}
}
