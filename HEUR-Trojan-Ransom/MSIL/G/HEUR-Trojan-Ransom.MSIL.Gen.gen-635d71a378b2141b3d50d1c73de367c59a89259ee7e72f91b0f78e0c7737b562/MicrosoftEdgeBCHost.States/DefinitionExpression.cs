using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DefinitionExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralParser()
	{
	}
}
