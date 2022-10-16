using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExpressionRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterceptor()
	{
	}
}
