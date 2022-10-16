using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PredicateClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateClass()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceInterceptor()
	{
	}
}
