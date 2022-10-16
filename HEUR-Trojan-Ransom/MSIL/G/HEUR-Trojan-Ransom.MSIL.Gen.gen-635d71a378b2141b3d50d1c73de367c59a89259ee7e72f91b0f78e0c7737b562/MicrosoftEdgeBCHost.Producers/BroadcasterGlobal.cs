using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BroadcasterGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceTemplate()
	{
	}
}
