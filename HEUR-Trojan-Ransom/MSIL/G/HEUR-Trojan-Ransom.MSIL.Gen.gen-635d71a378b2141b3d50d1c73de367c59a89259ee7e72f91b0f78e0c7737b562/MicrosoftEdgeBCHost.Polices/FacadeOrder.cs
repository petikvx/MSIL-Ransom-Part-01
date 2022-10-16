using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class FacadeOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeOrder()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyPool()
	{
	}
}
