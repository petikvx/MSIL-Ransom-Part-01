using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralMapper()
	{
	}
}
