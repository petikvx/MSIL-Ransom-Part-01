using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DescriptorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceService()
	{
	}
}
