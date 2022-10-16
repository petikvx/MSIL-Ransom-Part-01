using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SetterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallListener()
	{
	}
}
