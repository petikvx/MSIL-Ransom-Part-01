using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AuthenticationRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AuthenticationRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceDispatcher()
	{
	}
}
