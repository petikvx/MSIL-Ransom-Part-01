using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContextOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CancelTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelTokenizer()
	{
	}
}
