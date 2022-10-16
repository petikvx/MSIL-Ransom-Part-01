using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class GetterValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralComparator()
	{
	}
}
