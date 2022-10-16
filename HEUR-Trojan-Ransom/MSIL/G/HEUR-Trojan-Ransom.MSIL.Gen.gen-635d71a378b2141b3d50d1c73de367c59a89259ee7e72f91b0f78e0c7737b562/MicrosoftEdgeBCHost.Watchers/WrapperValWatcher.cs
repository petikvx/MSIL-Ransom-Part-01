using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WrapperValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceObject()
	{
	}
}
