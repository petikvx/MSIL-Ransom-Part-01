using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObjectWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StopTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopTokenizer()
	{
	}
}
