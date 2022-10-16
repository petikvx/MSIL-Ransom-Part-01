using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceReponse()
	{
	}
}
