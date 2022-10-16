using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PoolRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceFilter()
	{
	}
}
