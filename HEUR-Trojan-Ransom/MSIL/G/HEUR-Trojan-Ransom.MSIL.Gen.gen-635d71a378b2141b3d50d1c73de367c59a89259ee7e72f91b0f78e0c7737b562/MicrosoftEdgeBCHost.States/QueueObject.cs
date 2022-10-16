using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class QueueObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueObject()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralListener()
	{
	}
}
