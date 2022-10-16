using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InterceptorFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectIndexer()
	{
	}
}
