using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceIterator()
	{
	}
}
