using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FactoryAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralMap()
	{
	}
}
