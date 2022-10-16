using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RuleReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleReponse()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralIssuer()
	{
	}
}
