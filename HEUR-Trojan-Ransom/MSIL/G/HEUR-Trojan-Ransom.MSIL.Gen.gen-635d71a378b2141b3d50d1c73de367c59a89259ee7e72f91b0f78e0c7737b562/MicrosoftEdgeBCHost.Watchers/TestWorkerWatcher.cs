using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TestWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceField()
	{
	}
}
