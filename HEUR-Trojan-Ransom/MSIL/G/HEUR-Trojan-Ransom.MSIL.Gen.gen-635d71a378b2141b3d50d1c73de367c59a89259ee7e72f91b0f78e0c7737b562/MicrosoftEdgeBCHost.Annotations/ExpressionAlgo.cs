using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExpressionAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralResolver()
	{
	}
}
