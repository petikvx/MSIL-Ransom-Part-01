using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RefAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralInterpreter()
	{
	}
}
