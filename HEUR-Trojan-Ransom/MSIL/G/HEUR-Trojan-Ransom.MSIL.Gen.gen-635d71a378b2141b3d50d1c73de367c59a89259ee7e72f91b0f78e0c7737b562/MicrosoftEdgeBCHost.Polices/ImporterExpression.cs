using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralAttr()
	{
	}
}
