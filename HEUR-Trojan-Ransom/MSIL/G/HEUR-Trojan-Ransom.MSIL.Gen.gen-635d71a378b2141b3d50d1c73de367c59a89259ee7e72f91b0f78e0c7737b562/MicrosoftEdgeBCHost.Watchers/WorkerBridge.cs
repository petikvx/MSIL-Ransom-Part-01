using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WorkerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectParser()
	{
	}
}
