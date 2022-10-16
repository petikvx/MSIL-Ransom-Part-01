using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterceptorFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorFacade()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralConsumer()
	{
	}
}
