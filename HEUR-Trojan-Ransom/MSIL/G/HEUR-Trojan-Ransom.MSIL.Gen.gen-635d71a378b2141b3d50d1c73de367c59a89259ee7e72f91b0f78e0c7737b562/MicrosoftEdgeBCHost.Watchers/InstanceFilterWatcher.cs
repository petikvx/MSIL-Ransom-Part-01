using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InstanceFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CollectVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectVisitor()
	{
	}
}
