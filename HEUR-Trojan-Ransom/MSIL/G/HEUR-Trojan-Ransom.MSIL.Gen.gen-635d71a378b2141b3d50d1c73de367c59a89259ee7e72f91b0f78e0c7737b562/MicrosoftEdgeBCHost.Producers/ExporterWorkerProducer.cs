using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExporterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceRecord()
	{
	}
}
