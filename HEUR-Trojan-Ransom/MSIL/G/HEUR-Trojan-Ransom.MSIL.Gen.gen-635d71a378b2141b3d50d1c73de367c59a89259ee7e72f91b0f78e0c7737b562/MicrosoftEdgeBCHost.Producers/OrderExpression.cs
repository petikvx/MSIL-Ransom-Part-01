using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class OrderExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralTest()
	{
	}
}
