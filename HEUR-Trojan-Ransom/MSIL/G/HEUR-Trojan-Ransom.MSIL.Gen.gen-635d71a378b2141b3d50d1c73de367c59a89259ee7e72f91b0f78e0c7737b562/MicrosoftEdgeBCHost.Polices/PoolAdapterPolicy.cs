using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PoolAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralReponse()
	{
	}
}
