using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ClassValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceAlgo()
	{
	}
}
