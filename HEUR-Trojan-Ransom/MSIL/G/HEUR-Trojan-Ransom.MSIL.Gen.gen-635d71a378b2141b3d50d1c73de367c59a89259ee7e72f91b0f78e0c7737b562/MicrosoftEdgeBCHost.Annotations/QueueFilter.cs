using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class QueueFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueFilter()
	{
		WriterPropertyProducer.ResolveStub();
		RunComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunComposer()
	{
	}
}
