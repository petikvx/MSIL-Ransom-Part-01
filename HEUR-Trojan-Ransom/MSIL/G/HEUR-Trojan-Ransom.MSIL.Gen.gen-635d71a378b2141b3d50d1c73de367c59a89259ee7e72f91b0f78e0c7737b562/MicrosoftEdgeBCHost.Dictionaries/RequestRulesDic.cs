using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RequestRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceConfig()
	{
	}
}
