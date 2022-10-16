using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExporterFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetAlgo()
	{
	}
}
