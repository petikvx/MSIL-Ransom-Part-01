using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StatusFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptAdapter()
	{
	}
}
