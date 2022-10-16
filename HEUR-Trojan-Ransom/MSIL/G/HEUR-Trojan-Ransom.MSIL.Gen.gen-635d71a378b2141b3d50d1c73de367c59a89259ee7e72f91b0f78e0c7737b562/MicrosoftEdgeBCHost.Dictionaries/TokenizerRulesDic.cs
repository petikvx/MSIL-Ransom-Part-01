using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TokenizerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceMock()
	{
	}
}
