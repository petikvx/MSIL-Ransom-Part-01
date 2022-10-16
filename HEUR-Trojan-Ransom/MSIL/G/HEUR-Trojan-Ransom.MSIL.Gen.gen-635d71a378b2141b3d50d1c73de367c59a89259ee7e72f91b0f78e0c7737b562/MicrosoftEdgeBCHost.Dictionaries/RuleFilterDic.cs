using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RuleFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralService()
	{
	}
}
