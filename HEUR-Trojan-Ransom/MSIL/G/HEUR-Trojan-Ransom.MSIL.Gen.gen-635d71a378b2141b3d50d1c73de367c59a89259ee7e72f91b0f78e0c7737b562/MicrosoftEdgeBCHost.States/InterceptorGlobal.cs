using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterceptorGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceComparator()
	{
	}
}
