using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ItemRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfacePool()
	{
	}
}
