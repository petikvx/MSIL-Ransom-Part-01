using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FactoryWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceAccount()
	{
	}
}
