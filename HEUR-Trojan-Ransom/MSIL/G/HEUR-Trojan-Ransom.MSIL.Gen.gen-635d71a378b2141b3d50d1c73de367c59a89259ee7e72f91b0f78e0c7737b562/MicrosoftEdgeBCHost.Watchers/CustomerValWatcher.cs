using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CustomerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceComposer()
	{
	}
}
