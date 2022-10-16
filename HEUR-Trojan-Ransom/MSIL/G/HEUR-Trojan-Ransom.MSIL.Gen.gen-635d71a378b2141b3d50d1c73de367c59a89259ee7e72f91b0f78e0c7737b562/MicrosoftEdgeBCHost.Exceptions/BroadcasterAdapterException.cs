using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BroadcasterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceRepository()
	{
	}
}
