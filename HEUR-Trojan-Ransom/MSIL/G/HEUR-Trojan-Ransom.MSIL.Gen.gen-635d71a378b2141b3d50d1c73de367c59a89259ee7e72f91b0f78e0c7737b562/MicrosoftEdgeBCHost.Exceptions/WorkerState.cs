using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WorkerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerState()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceStatus()
	{
	}
}
