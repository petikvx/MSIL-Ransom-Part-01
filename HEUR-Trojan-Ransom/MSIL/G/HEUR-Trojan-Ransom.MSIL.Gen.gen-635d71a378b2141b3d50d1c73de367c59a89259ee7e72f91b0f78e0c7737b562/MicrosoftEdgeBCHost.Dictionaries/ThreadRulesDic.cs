using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ThreadRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfacePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfacePredicate()
	{
	}
}
