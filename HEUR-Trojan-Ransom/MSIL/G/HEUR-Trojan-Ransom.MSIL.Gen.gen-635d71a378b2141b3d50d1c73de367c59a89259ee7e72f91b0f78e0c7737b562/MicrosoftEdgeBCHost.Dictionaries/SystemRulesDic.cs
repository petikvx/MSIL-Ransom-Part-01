using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SystemRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfacePredicate()
	{
	}
}
