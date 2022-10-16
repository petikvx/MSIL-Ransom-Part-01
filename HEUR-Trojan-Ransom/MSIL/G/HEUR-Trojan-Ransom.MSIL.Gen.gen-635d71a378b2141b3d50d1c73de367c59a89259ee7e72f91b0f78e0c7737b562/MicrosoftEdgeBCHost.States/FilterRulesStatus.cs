using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FilterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeTokenizer()
	{
	}
}
