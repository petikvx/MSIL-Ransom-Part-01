using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RequestSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralAlgo()
	{
	}
}
