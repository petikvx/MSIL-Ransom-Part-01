using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TestsRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceTokenizer()
	{
	}
}
