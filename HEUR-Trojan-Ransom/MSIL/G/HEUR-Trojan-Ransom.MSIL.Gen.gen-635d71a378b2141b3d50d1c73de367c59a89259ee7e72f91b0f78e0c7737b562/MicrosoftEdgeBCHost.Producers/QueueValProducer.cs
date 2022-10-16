using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class QueueValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveAttr()
	{
	}
}
