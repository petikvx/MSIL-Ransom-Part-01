using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ImporterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceUtils()
	{
	}
}
