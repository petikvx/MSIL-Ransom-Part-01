using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class VisitorFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeUtils()
	{
	}
}
