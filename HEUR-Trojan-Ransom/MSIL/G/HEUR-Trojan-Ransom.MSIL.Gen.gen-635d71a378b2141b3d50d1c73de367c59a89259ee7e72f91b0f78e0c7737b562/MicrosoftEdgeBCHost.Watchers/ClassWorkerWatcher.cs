using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClassWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceUtils()
	{
	}
}
