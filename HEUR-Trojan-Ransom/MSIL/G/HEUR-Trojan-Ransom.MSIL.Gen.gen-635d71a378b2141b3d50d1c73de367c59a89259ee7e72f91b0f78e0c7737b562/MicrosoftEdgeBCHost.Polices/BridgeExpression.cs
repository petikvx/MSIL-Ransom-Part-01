using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BridgeExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeExpression()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralService()
	{
	}
}
