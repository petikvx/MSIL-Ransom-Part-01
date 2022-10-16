using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CollectionOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceIssuer()
	{
	}
}
