using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProductValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralState()
	{
	}
}
