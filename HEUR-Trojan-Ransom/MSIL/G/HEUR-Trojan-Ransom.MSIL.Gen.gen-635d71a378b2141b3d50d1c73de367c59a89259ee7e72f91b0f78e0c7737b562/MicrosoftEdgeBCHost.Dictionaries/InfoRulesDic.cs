using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InfoRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceWatcher()
	{
	}
}
