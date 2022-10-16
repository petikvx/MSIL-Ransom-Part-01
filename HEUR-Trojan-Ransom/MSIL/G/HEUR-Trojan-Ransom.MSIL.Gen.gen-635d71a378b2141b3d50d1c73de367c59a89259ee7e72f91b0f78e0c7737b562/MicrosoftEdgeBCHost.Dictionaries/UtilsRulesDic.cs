using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class UtilsRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		OrderInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderInterfaceStatus()
	{
	}
}
