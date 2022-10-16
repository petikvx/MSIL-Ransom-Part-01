using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RequestExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralParser()
	{
	}
}
