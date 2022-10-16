using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AdapterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceQueue()
	{
	}
}
