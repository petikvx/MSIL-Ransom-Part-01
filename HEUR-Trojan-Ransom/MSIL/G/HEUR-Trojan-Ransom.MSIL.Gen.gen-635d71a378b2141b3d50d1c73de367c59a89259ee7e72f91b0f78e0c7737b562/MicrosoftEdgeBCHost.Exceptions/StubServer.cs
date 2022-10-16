using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StubServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubServer()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralExpression()
	{
	}
}
