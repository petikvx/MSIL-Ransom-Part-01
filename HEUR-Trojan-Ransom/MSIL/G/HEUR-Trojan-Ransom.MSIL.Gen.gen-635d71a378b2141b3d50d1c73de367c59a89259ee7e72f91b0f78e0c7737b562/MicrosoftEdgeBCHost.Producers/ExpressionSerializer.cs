using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExpressionSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralCode()
	{
	}
}
