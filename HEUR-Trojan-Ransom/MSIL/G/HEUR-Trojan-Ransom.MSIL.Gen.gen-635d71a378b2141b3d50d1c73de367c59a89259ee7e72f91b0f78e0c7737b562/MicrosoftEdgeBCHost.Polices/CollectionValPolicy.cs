using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CollectionValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInvocation()
	{
	}
}
