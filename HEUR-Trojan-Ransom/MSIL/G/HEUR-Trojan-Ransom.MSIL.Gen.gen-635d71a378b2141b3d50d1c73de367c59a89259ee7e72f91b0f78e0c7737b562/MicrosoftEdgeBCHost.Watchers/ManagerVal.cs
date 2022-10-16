using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ManagerVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerVal()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInfo()
	{
	}
}
