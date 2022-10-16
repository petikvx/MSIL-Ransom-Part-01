using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class HelperAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralRule()
	{
	}
}
