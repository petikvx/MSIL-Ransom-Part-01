using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObserverWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceWatcher()
	{
	}
}
