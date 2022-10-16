using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class EventOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceTask()
	{
	}
}
