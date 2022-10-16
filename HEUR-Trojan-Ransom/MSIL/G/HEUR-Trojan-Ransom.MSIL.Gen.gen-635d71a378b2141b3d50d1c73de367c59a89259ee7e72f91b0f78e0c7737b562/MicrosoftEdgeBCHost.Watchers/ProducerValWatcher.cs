using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceInitializer()
	{
	}
}
