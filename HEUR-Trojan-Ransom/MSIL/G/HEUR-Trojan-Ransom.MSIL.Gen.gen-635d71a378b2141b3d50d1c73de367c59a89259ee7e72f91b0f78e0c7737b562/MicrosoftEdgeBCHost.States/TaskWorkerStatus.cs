using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TaskWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralSerializer()
	{
	}
}
