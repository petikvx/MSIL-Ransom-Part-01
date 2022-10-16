using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SerializerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceWrapper()
	{
	}
}
