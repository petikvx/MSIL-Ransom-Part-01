using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DispatcherAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralPrototype()
	{
	}
}
