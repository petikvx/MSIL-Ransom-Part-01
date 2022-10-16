using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralInitializer()
	{
	}
}
