using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RuleServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleServer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralPredicate()
	{
	}
}
