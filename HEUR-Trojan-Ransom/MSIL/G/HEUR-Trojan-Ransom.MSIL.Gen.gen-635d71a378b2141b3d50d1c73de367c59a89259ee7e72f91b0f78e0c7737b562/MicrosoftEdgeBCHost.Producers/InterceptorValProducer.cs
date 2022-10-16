using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterceptorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetComposer()
	{
	}
}
