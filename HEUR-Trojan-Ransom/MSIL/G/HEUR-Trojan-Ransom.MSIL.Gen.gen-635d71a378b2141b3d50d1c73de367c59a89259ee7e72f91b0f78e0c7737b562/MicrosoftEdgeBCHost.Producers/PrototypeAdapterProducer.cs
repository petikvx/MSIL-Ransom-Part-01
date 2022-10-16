using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PrototypeAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralGlobal()
	{
	}
}
