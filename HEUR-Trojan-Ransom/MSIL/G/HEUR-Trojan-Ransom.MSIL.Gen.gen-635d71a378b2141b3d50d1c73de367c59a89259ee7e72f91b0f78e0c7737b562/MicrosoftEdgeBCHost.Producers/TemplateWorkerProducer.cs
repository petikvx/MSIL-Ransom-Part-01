using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TemplateWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceCollection()
	{
	}
}
