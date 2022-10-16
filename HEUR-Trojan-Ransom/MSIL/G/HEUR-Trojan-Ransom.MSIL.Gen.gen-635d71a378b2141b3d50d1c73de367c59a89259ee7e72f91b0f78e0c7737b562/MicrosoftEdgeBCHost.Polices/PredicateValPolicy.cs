using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PredicateValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceBroadcaster()
	{
	}
}
