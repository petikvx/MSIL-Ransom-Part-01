using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProducerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotLiteralPrinter()
	{
	}
}
