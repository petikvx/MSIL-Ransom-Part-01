using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class OrderSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralGetter()
	{
	}
}
