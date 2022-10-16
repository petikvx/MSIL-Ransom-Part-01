using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ListOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceSerializer()
	{
	}
}
