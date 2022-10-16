using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ItemValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralValue()
	{
	}
}
