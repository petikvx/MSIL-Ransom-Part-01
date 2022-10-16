using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DecoratorAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralParam()
	{
	}
}
