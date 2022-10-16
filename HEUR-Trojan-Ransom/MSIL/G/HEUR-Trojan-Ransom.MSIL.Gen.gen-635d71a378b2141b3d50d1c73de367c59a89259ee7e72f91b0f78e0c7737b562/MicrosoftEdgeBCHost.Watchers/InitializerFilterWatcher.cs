using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InitializerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeProcess()
	{
	}
}
