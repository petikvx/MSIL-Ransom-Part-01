using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ItemFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectPredicate()
	{
	}
}
