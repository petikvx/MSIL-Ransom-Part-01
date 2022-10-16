using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContextRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceRecord()
	{
	}
}
