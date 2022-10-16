using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RulesServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesServer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralExpression()
	{
	}
}
