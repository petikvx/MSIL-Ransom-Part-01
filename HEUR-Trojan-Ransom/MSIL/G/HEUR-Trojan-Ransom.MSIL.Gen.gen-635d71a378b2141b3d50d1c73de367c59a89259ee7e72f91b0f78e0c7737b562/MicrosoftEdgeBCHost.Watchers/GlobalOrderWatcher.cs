using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GlobalOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralGlobal()
	{
	}
}
