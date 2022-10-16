using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComposerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceListener()
	{
	}
}
