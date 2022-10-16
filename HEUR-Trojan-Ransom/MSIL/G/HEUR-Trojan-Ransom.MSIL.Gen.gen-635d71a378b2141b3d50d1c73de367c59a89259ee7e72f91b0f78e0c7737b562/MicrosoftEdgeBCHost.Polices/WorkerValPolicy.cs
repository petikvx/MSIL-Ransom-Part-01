using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WorkerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectRequest()
	{
	}
}
