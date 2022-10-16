using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralBroadcaster()
	{
	}
}
