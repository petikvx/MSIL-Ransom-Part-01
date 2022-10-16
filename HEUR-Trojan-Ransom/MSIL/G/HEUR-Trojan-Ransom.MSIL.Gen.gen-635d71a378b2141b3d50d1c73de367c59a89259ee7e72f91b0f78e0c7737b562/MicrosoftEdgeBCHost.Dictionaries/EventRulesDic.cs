using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class EventRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceWatcher()
	{
	}
}
