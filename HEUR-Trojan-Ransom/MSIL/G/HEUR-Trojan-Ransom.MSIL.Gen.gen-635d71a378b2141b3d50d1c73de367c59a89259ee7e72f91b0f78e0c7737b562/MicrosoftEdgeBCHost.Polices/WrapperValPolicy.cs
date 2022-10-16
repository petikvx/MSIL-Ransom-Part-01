using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WrapperValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CollectProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectProducer()
	{
	}
}
