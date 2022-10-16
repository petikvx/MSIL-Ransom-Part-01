using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConsumerValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterceptor()
	{
	}
}
