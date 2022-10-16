using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceProperty()
	{
	}
}
