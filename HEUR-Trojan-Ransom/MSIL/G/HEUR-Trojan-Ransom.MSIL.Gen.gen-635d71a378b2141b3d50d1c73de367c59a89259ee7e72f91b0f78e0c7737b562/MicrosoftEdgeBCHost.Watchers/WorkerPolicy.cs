using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceInfo()
	{
	}
}
