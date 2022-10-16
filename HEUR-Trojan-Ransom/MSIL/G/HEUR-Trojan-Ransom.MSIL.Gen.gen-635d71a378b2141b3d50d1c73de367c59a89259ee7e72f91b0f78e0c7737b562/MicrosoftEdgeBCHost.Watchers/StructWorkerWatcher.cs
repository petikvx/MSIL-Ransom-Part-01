using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StructWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceRule()
	{
	}
}
