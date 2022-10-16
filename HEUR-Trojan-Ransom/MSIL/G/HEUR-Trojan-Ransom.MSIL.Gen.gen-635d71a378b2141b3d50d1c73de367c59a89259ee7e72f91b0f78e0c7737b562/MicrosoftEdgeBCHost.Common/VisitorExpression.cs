using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorExpression()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralParser()
	{
	}
}
