using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttrRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceOrder()
	{
	}
}
