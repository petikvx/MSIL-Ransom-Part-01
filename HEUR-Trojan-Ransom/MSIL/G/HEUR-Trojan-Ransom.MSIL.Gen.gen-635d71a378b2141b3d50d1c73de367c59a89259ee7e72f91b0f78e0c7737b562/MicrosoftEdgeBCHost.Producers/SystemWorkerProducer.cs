using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SystemWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceCode()
	{
	}
}
