using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AlgoValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceDecorator()
	{
	}
}
