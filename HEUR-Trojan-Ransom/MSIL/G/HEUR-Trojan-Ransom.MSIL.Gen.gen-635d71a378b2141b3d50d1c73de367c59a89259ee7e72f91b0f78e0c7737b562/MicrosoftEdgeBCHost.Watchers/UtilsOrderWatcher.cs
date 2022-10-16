using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class UtilsOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralGlobal()
	{
	}
}
