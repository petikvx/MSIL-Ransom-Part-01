using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IssuerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AwakePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakePool()
	{
	}
}
