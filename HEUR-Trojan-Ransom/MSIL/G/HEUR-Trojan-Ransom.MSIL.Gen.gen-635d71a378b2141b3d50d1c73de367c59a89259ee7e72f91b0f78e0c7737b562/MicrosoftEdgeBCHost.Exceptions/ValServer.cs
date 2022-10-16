using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ValServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValServer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralExpression()
	{
	}
}
