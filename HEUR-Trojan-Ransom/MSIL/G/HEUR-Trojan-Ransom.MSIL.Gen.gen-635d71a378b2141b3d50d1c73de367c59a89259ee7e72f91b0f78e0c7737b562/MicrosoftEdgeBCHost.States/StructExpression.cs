using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StructExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructExpression()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralAttr()
	{
	}
}
