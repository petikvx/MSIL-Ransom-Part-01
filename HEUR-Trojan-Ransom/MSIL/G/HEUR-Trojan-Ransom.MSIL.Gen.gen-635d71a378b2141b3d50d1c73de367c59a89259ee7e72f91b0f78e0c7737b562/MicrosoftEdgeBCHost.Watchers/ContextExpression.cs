using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContextExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralTest()
	{
	}
}
