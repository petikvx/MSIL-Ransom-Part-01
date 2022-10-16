using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExpressionDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralRequest()
	{
	}
}
