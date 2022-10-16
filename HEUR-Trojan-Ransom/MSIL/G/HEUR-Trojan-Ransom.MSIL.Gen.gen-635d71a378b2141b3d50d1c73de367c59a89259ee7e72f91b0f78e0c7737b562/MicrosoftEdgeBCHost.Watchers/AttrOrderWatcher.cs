using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AttrOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralProperty()
	{
	}
}
