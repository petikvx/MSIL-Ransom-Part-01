using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InterpreterFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneEvent()
	{
	}
}
