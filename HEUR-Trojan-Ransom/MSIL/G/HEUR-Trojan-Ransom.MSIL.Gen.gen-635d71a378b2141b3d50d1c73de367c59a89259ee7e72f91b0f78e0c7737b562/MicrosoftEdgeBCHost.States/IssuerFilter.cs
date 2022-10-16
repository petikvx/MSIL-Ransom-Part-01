using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IssuerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptIterator()
	{
	}
}
