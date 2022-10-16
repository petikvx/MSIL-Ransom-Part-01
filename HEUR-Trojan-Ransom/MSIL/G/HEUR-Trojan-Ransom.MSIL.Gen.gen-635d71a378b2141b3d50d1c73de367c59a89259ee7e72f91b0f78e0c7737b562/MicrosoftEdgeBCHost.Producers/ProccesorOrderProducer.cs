using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProccesorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceRegistry()
	{
	}
}
