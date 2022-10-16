using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SetterOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceProducer()
	{
	}
}
