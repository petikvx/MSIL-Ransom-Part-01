using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DefinitionValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceQueue()
	{
	}
}
