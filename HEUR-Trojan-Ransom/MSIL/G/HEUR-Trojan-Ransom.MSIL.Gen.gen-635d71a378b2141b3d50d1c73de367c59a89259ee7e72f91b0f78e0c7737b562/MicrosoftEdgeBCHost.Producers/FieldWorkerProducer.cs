using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FieldWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceEvent()
	{
	}
}
