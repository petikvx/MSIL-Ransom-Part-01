using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PrototypeWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceSerializer()
	{
	}
}
