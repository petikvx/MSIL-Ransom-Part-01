using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RulesFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceObserver()
	{
	}
}
