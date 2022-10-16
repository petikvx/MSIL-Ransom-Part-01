using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class GetterValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceState()
	{
	}
}
