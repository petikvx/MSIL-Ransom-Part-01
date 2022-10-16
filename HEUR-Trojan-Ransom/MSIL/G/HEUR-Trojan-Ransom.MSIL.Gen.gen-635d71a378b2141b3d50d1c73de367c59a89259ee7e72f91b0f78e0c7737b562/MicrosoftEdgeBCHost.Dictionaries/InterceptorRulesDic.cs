using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterceptorRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfacePredicate()
	{
	}
}
