using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConsumerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceException()
	{
	}
}
