using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcessRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceField()
	{
	}
}
