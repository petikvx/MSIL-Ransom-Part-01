using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DispatcherValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatRegistry()
	{
	}
}
