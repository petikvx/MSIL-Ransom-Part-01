using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ListAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListAnnotation()
	{
	}
}
