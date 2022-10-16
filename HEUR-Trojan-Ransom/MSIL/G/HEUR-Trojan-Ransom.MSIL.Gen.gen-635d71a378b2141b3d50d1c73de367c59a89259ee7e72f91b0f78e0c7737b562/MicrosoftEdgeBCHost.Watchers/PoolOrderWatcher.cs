using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralInvocation()
	{
	}
}
