using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PoolFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RestartPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartPublisher()
	{
	}
}
