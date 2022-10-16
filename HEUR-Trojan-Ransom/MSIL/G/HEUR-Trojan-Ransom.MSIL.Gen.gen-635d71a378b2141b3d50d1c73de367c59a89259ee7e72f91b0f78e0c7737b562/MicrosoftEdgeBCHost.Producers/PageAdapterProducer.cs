using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PageAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralFacade()
	{
	}
}
