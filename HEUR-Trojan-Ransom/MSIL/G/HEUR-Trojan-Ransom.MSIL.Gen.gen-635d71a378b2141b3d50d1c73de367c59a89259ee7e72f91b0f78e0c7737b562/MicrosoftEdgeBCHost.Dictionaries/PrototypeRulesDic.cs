using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PrototypeRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceCandidate()
	{
	}
}
