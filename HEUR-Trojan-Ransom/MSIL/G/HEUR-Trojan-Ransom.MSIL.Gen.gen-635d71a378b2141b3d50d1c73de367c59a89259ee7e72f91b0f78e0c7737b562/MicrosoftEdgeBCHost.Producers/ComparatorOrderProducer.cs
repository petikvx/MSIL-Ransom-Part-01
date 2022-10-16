using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComparatorOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceExpression()
	{
	}
}
