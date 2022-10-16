using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SystemFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		EnableProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableProcess()
	{
	}
}
