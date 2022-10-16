using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParameterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceGlobal()
	{
	}
}
