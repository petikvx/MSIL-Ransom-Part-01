using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValueExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralParser()
	{
	}
}
