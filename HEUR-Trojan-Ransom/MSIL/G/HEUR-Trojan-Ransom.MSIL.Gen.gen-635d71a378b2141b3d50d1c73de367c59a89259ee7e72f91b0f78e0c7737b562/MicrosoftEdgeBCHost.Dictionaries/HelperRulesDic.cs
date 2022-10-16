using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class HelperRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceDispatcher()
	{
	}
}
