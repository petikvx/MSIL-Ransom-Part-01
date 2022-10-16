using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterceptorValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		EnableConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableConsumer()
	{
	}
}
