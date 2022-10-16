using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolExpression()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralTests()
	{
	}
}
