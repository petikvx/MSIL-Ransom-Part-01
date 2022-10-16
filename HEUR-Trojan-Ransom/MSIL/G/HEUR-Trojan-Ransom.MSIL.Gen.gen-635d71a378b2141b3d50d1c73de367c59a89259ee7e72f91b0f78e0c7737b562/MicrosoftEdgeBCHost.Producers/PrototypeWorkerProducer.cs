using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PrototypeWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceInstance()
	{
	}
}
