using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StubExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralService()
	{
	}
}
