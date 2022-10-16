using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InvocationOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceField()
	{
	}
}
