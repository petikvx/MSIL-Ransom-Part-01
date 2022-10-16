using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComparatorOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralProxy()
	{
	}
}
