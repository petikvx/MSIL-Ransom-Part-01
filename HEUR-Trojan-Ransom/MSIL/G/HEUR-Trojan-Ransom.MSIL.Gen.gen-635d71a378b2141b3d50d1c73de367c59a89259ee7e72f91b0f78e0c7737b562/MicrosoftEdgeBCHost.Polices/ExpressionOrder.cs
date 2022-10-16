using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExpressionOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionOrder()
	{
		WriterPropertyProducer.ResolveStub();
		TestTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestTokenizer()
	{
	}
}
