using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StateContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateContext()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceWatcher()
	{
	}
}
