using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PropertyContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyContext()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceWatcher()
	{
	}
}
