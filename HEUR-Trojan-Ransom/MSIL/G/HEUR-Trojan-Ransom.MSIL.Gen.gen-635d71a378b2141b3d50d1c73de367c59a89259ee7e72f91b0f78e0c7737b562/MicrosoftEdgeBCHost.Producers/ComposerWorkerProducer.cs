using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComposerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceState()
	{
	}
}
