using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FacadePropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadePropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralHelper()
	{
	}
}
