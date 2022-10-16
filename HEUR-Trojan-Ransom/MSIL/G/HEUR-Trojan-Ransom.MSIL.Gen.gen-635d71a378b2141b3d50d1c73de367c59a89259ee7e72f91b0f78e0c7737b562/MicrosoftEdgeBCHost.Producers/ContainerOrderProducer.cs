using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContainerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceObserver()
	{
	}
}
