using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IdentifierOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveObserver()
	{
	}
}
