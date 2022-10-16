using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WriterState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterState()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceConfiguration()
	{
	}
}
