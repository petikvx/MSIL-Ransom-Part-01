using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RulesBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ViewProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewProducer()
	{
	}
}
