using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExpressionAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralRegistry()
	{
	}
}
