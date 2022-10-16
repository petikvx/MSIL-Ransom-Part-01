using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class UtilsAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralProccesor()
	{
	}
}
