using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DefinitionWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceFactory()
	{
	}
}
