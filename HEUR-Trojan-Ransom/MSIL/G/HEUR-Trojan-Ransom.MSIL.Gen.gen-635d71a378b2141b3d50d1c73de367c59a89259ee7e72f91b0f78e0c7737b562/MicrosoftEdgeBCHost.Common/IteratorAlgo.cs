using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IteratorAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralTag();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralTag()
	{
	}
}
