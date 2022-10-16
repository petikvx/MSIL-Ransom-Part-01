using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BroadcasterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceAuthentication()
	{
	}
}
