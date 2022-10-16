using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConsumerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostStatus()
	{
	}
}
