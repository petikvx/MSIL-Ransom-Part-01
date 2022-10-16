using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ModelAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralPrinter()
	{
	}
}
