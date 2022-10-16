using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class UtilsAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralTokenizer()
	{
	}
}
