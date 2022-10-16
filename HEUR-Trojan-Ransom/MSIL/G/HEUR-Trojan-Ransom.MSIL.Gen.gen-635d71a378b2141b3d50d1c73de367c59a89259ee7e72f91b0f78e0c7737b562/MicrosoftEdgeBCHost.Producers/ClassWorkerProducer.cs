using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadList()
	{
	}
}
