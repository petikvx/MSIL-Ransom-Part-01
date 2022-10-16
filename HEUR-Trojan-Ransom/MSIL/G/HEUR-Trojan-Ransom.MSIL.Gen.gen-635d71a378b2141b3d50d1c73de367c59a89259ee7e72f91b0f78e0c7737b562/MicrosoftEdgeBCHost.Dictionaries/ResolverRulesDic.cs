using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ResolverRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceInvocation()
	{
	}
}
