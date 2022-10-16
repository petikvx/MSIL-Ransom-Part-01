using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatField()
	{
	}
}
