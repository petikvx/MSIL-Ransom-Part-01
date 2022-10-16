using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FactoryValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceRef()
	{
	}
}
