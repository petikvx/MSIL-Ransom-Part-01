using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BroadcasterOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceEvent()
	{
	}
}
