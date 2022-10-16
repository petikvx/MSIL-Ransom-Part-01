using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WorkerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerVal()
	{
		WriterPropertyProducer.ResolveStub();
		MovePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MovePublisher()
	{
	}
}
