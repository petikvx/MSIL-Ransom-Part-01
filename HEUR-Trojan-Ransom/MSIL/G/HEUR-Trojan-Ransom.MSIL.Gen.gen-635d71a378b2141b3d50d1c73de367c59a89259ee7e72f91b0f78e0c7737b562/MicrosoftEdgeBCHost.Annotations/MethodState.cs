using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MethodState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodState()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceContext()
	{
	}
}
