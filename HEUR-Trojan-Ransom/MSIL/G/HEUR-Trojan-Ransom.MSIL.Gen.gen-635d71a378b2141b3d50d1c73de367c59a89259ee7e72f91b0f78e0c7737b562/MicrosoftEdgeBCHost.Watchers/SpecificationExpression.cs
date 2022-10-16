using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SpecificationExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralAttr()
	{
	}
}
