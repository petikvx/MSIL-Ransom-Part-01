using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamsOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceFacade()
	{
	}
}
