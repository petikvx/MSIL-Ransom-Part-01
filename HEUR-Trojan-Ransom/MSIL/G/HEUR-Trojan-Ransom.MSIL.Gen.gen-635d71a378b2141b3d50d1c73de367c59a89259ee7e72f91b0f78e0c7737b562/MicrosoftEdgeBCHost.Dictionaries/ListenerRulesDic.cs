using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListenerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceProduct()
	{
	}
}
