using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExporterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralSingleton()
	{
	}
}
