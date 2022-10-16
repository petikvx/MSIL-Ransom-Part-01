using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralTask()
	{
	}
}
