using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListenerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CollectFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectFilter()
	{
	}
}
