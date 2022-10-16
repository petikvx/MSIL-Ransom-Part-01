using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GetterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralWrapper()
	{
	}
}
