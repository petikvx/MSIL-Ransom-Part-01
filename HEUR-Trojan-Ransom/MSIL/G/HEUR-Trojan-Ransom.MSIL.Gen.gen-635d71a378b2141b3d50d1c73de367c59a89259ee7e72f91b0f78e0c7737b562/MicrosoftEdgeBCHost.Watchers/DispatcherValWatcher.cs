using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DispatcherValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceRecord()
	{
	}
}
