using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ValRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyTokenizer()
	{
	}
}
