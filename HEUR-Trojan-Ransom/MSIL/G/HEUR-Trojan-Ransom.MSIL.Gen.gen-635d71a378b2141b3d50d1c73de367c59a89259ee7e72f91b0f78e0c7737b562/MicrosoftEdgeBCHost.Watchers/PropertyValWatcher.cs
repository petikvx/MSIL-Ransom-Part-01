using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PropertyValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceCode()
	{
	}
}
