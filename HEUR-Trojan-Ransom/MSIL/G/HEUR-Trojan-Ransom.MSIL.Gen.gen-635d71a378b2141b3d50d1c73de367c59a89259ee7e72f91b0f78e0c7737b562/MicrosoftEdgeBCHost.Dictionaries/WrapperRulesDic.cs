using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WrapperRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceAdapter()
	{
	}
}
