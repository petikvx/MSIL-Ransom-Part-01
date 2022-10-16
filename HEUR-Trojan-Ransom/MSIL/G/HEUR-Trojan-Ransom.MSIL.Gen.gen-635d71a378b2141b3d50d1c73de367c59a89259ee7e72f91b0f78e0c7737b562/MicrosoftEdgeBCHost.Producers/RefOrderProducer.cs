using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RefOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralServer()
	{
	}
}
