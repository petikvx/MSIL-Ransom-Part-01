using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComparatorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceAccount()
	{
	}
}
