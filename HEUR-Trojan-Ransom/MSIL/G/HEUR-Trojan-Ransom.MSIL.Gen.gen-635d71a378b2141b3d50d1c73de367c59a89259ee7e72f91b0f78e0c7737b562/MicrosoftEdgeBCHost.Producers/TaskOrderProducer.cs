using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceWrapper()
	{
	}
}
