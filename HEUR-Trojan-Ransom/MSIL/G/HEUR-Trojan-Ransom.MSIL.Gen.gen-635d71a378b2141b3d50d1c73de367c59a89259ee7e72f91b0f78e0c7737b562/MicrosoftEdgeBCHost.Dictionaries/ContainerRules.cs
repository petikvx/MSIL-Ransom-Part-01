using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContainerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerRules()
	{
		WriterPropertyProducer.ResolveStub();
		CollectListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectListener()
	{
	}
}
