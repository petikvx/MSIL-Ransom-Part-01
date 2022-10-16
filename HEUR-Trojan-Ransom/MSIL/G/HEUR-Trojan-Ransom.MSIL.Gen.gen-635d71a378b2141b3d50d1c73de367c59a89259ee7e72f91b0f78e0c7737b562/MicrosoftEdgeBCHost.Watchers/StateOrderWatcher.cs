using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StateOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralGlobal()
	{
	}
}
