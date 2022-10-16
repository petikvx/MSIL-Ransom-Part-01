using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralPredicate()
	{
	}
}
