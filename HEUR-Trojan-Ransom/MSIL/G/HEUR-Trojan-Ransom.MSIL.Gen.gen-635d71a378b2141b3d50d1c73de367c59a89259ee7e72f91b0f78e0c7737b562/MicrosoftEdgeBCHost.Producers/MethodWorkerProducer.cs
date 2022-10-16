using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MethodWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceGlobal()
	{
	}
}
