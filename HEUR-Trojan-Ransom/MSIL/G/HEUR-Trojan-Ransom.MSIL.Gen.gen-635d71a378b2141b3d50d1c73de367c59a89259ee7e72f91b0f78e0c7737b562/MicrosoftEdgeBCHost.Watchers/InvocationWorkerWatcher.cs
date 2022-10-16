using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InvocationWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceConsumer()
	{
	}
}
