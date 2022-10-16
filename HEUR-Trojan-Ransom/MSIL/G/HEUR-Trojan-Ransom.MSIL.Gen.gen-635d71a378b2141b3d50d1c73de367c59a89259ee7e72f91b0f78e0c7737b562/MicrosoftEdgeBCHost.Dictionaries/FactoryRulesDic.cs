using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FactoryRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceParams()
	{
	}
}
