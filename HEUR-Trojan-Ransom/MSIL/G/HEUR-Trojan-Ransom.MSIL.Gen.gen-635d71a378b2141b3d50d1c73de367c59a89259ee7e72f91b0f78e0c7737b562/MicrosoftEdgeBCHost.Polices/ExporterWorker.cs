using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExporterWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterWorker()
	{
		WriterPropertyProducer.ResolveStub();
		DisableSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableSerializer()
	{
	}
}
