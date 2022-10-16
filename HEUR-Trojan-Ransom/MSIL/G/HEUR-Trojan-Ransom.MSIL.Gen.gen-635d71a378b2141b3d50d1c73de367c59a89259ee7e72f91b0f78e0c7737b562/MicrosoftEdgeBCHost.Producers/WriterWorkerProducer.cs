using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WriterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceError()
	{
	}
}
