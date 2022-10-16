using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceInvocation()
	{
	}
}
