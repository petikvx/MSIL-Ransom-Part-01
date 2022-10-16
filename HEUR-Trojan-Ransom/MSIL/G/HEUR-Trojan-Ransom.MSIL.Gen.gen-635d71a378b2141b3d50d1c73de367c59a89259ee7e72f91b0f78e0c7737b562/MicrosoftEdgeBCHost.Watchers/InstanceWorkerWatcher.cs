using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InstanceWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceInvocation()
	{
	}
}
