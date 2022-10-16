using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PoolAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralInterpreter()
	{
	}
}
