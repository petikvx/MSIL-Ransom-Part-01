using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ManagerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceConfig()
	{
	}
}
