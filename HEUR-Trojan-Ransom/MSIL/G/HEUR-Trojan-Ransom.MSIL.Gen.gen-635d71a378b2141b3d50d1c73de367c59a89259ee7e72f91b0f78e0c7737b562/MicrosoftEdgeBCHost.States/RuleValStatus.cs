using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RuleValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralDispatcher()
	{
	}
}
