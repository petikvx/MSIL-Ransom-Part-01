using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RecordWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DefineRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineRegistry()
	{
	}
}
