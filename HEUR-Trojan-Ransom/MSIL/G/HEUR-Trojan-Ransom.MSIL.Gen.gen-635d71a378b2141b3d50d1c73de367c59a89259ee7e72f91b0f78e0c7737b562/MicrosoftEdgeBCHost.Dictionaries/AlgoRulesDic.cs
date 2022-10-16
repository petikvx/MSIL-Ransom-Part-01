using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AlgoRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceConfiguration()
	{
	}
}
