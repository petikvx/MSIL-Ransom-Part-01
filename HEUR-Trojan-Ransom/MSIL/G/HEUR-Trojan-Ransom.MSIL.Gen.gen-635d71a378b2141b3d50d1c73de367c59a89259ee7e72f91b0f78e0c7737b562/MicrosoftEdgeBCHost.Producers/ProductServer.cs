using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProductServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductServer()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralFacade()
	{
	}
}
