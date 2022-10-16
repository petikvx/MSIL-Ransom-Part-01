using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExpressionPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralInvocation()
	{
	}
}
