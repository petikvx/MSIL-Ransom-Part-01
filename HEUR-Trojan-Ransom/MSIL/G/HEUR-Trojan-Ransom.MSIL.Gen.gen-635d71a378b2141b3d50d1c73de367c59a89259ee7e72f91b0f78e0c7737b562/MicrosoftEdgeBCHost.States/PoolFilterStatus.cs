using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PoolFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralIssuer()
	{
	}
}
