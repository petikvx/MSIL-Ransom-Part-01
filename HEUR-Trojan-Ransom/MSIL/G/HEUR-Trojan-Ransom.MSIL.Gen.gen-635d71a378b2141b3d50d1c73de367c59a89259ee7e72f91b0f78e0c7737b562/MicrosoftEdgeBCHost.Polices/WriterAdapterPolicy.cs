using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class WriterAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralFacade()
	{
	}
}
