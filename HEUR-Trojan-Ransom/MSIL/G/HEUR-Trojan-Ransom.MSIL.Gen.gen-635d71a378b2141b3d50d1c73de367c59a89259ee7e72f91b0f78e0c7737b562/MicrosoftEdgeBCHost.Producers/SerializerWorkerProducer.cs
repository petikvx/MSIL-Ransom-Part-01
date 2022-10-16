using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SerializerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RunWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunWriter()
	{
	}
}
