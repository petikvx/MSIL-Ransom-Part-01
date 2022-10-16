using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServiceValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SetupFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupFacade()
	{
	}
}
