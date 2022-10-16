using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PublisherOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceConfig()
	{
	}
}
