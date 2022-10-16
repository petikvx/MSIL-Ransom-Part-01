using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InfoWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceIdentifier()
	{
	}
}
