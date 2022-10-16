using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReponseAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FlushLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushLiteralAlgo()
	{
	}
}
