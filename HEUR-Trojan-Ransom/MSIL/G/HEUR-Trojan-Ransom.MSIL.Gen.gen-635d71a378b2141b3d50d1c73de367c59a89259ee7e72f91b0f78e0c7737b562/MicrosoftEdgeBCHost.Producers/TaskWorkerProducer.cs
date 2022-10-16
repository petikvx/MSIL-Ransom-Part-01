using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceValue()
	{
	}
}
