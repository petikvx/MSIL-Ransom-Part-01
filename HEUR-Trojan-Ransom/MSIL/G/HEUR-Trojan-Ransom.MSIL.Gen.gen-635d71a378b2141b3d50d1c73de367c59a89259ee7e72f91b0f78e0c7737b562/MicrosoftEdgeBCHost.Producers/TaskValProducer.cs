using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PostOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostOrder()
	{
	}
}
