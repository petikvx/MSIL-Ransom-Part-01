using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ResolverBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CollectIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectIndexer()
	{
	}
}
