using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TaskWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInvocation()
	{
	}
}
