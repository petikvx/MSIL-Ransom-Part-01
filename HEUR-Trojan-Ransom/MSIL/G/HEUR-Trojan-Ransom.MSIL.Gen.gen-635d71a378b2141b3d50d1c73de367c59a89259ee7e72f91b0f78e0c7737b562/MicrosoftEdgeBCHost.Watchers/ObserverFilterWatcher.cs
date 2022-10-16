using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ObserverFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetField()
	{
	}
}
