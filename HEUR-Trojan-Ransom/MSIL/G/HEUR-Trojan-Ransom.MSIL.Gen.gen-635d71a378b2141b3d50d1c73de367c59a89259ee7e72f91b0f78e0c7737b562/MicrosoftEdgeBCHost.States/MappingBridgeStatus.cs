using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MappingBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveTask()
	{
	}
}
