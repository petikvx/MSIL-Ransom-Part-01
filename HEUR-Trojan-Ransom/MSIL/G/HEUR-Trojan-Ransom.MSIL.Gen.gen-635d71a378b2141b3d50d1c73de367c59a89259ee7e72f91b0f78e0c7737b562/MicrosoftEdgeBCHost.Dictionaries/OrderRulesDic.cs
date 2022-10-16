using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class OrderRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceQueue()
	{
	}
}
