using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IteratorState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorState()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceProperty()
	{
	}
}
