using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class QueueBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyField()
	{
	}
}
