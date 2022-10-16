using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExpressionServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionServer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralStrategy()
	{
	}
}
