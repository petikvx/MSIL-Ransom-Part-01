using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConsumerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceWatcher()
	{
	}
}
