using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParserExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralGlobal()
	{
	}
}
