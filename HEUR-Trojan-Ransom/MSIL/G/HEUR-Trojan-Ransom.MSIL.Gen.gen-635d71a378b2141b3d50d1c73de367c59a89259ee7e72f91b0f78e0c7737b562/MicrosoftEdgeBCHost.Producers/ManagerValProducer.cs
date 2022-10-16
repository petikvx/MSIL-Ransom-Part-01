using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ManagerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallTask()
	{
	}
}
