using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IssuerExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralGlobal()
	{
	}
}
