using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TaskBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteParameter()
	{
	}
}
