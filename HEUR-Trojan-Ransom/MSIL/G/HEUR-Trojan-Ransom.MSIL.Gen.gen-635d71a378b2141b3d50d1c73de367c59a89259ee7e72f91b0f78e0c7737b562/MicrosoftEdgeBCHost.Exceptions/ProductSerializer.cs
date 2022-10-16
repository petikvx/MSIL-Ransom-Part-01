using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProductSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralEvent()
	{
	}
}
