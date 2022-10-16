using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RegRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceProducer()
	{
	}
}
