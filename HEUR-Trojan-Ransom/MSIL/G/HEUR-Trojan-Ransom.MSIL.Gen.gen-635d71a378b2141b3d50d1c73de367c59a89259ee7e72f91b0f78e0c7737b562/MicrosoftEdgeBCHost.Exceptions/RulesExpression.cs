using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RulesExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralService()
	{
	}
}
